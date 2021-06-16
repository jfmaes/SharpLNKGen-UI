using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using SharpLnkGui;
using Trinet.Core.IO.Ntfs;

namespace LnkGen_Forms
{
    static class Program
    {
        public static Dictionary<string, string> alternateDataStreams = new Dictionary<string, string>();
        public static bool expertMode = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public static void AddADS(String LNKPath)
        {
            foreach (var item in Program.alternateDataStreams)
            {
                var sfh = PinvokeAndStructs.CreateFile(LNKPath + ":" + item.Key,
                    PinvokeAndStructs.EFileAccess.GenericRead | PinvokeAndStructs.EFileAccess.GenericWrite,
                    PinvokeAndStructs.EFileShare.Read,
                    IntPtr.Zero,
                    PinvokeAndStructs.ECreationDisposition.CreateAlways,
                    PinvokeAndStructs.EFileAttributes.Normal,
                    IntPtr.Zero);

                if (sfh.IsInvalid)
                {
                    Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
                }
                using (FileStream fs = new FileStream(sfh, FileAccess.Write))
                {
                    byte[] filebytes = System.IO.File.ReadAllBytes(Path.Combine(LNKPath, item.Value));
                    fs.Write(filebytes, 0, filebytes.Length);
                }
                sfh.Close();
            }
        }

        public static Dictionary<string, string> ListADS(String LNKPath)
        {
            Dictionary<string, string> alternateDataStreams = new Dictionary<string, string>();
            FileInfo file = new FileInfo(LNKPath);
            foreach (AlternateDataStreamInfo s in file.ListAlternateDataStreams())
            {
                alternateDataStreams.Add(s.Name, s.FullPath);
            }

            return alternateDataStreams;
        }

        public static void CreateLnk(String Path = "", String TargetPath = "", bool bamboozle = false, String Arguments = "", String IconLocation = "", String Description = "")
        {
            String args = "";
            if (bamboozle)
            {
                String deceptioniseverywhere = "";
                deceptioniseverywhere = new StringBuilder().Insert(0, " ", 256).ToString();
                args += deceptioniseverywhere + @Arguments;
            }
            else { args = @Arguments; }

            IWshShell ws = new WshShell();
            IWshShortcut sc = (IWshShortcut)ws.CreateShortcut(Path);
            sc.WindowStyle = 1;
            sc.TargetPath = TargetPath;
            sc.IconLocation = IconLocation;
            sc.Arguments = args;
            sc.Description = Description;
            sc.Save();
        }

    }
}
