using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MailCollector.utils
{
    public struct EmbeddedIconInfo
    {
        public string FileName;
        public int IconIndex;
    }

    public class FileIcon
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIconA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr ExtractIcon(int hInst, string lpszExeFileName, int nIconIndex);


        protected static EmbeddedIconInfo getEmbeddedIconInfo(string fileAndParam)
        {
            EmbeddedIconInfo embeddedIcon = new EmbeddedIconInfo();

            if (String.IsNullOrEmpty(fileAndParam))
                return embeddedIcon;

            //Use to store the file contains icon.
            string fileName = String.Empty;

            //The index of the icon in the file.
            int iconIndex = 0;
            string iconIndexString = String.Empty;

            int commaIndex = fileAndParam.IndexOf(",");
            //if fileAndParam is some thing likes this: 
            //"C:\\Program Files\\NetMeeting\\conf.exe,1".
            if (commaIndex > 0)
            {
                fileName = fileAndParam.Substring(0, commaIndex);
                iconIndexString = fileAndParam.Substring(commaIndex + 1);
            }
            else
                fileName = fileAndParam;

            if (!String.IsNullOrEmpty(iconIndexString))
            {
                //Get the index of icon.
                iconIndex = int.Parse(iconIndexString);
                if (iconIndex < 0)
                    iconIndex = 0;  //To avoid the invalid index.
            }

            embeddedIcon.FileName = fileName;
            embeddedIcon.IconIndex = iconIndex;

            return embeddedIcon;
        }

        public static Icon ExtractIconFromFile(string fileAndParam)
        {
            try
            {
                EmbeddedIconInfo embeddedIcon = getEmbeddedIconInfo(fileAndParam);

                //Gets the handle of the icon.
                IntPtr lIcon = ExtractIcon(0, embeddedIcon.FileName, embeddedIcon.IconIndex);

                //Gets the real icon.
                return Icon.FromHandle(lIcon);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public static string Extension_GetExePath(string strExtension)
        {
            //We need a leading dot, so add it if it's missing.
            if (!strExtension.StartsWith(".")) strExtension = "." + strExtension;

            //Get the class-name associated with the passed extension
            Microsoft.Win32.RegistryKey rkClassName = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(strExtension);
            //Exit, if not found
            if (rkClassName == null) return string.Empty;
            
            string strClassName = rkClassName.GetValue("").ToString();

            //Get the shell-command for the retrieved executable 
            //This key is found at HKCR\[ClassName]\shell\open\command\(Default)
            //One or more of the paths may be missing, so each of them is being tested
            //separately.
            Microsoft.Win32.RegistryKey rkShellCommandRoot = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(strClassName);
            
            if (rkShellCommandRoot == null) return string.Empty;

            Microsoft.Win32.RegistryKey rkShell = rkShellCommandRoot.OpenSubKey("shell");
            if (rkShell == null) return string.Empty;

            Microsoft.Win32.RegistryKey rkOpen
               = rkShell.OpenSubKey("open");
            if (rkOpen == null) return string.Empty;

            Microsoft.Win32.RegistryKey rkCommand
               = rkOpen.OpenSubKey("command");
            if (rkCommand == null) return string.Empty;

            string strShellCommand = rkCommand.GetValue("").ToString();

            //The shell-command may contain additional parameters and may be wrapped in double quotes,
            //so parse out the exe-path.
            string strExePath;
            if (strShellCommand.StartsWith(@""""))
                //Extract path (wrapped in double-quotes)
                strExePath = strShellCommand.Split('"')[1];
            else
                //Extract first word (until first space char)
                strExePath = strShellCommand.Split(' ')[0];

            return strExePath;
        }

    }
}
