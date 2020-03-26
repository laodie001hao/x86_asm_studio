using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace x86_asm_studio
{
    partial class x86_asm_studio
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(
            byte[] section, byte[] key, byte[] val, byte[] filePath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(
            byte[] section, byte[] key, byte[] def, byte[] buffer, int size, byte[] filePath);

        private void makeConfigFile()
        {
            if (!File.Exists(configFile)) {
                File.Create(configFile);
            }
        }
        private void saveConfig(string section, string key, string val)
        {
            long retval = WritePrivateProfileString(
                Encoding.ASCII.GetBytes(section),
                Encoding.ASCII.GetBytes(key),
                Encoding.ASCII.GetBytes(val),
                Encoding.ASCII.GetBytes(configFile));

            if (key == "Emulator") {
                emulator = val;
            } else if (key == "Image") {
                image = val;
            } else if (key == "Compiler") {
                compiler = val;
            } else if (key == "dd"){
                dd = val;
            } else { 
            }
        }

        private string loadConfig(string section, string key)
        {
            byte[] buf = new byte[1024];
            long retval = GetPrivateProfileString(
                Encoding.ASCII.GetBytes(section),
                Encoding.ASCII.GetBytes(key),
                Encoding.ASCII.GetBytes("Select place"),
                buf, 1024,
                Encoding.ASCII.GetBytes(configFile));
            string val = Encoding.ASCII.GetString(buf);

            //char[] delimiter = new char[1] { '\0' }; // Remove '\0' in result
            //val = val.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)[0];
            val = val.Replace("\0", string.Empty);
            if (key == "Emulator") {
                emulator = val;
            } else if (key == "Image") {
                image = val;
            } else if (key == "Compiler") {
                compiler = val;
            } else if (key == "DD") {
                dd = val;
            } else { 
            }

            return val;
        }

        private void doCompile(string fullName, ref string output)
        {
            string srcName = cd(fullName);
            string destName = srcName.Replace("asm", "bin");
            string args = string.Empty;
            args += srcName;
            args += " -f bin ";
            args += " -o ";
            args += destName;
            File.Delete(destName);
            runAutoTerminateTool(compiler, args, ref output);
        }

        private void makeImage(string fullName,string blksz, string blkcnt, int unit, ref string output) 
        {
            string srcName = cd(fullName).Replace("asm", "bin");
            string destName = srcName.Replace("bin", "img");
            string args = string.Empty;
            args += "if=";
            args += srcName;
            args += " bs=";
            args += blksz;
            args += unit;
            switch (unit) {
                case 0:
                    break;
                case 1:
                    args += "K";
                    break;
                case 2:
                    args += "M";
                    break;
                default:
                    break;
            }
            args += " count=";
            args += blkcnt;
            args += " of=";
            args += destName;
            File.Delete(destName);
            runAutoTerminateTool(dd, args, ref output);
        }

        private void startEmulator(string fullName, string[] ops)
        {
            string imgName = cd(fullName).Replace("asm", "img");
            string args = string.Empty;
            args += imgName;
            runManualTerminateTool(emulator, args);
        }

        private void runAutoTerminateTool(string cmd, string args, ref string output)
        {
            try {
                using (Process process = new Process())
                {
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = cmd;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.Start();
                    for (StreamReader reader = process.StandardOutput; !reader.EndOfStream; output += "\r\n") {
                        output += reader.ReadLine();
                    }
                    for (StreamReader reader = process.StandardError; !reader.EndOfStream; output += "\r\n") {
                        output += reader.ReadLine();
                    }
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void runManualTerminateTool(string cmd, string args)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.FileName = cmd;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string cd(string fullName)
        {
            string file = string.Empty;
            string path = string.Empty;
            string[] delimiter = new string[1] { "\\" };

            var partName = fullName.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            file = partName[partName.Length - 1];
            path = fullName.Replace(file, "");

            Directory.SetCurrentDirectory(path);

            return file;
        }
        
        private string emulator = string.Empty;
        private string image = string.Empty;
        private string compiler = string.Empty;
        private string dd = string.Empty;
        private string configFile = Environment.GetEnvironmentVariable("HOMEDRIVE") + 
            Environment.GetEnvironmentVariable("HOMEPATH") + "\\x86_asm_studio.ini";
    }
}
