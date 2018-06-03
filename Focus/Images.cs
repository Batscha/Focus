using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Focus
{
    class Images
    {
        public static List<String> getImagesinFolder(String path)
        {
            List<string> AllFiles = new List<string>();
            List<string> ImagePaths = new List<string>();

            AllFiles.AddRange(System.IO.Directory.GetFiles(@"" + path, "*", System.IO.SearchOption.AllDirectories).ToList());

            foreach (string s in AllFiles)
            {
                if (s.Contains(".png") || s.Contains(".jpg") ||
                    s.Contains(".jpeg") || s.Contains(".gif") || s.Contains(".JPG"))
                {
                    ImagePaths.Add(s);
                }
                Debug.WriteLine(s);
            }

            //ImagePaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.png", System.IO.SearchOption.AllDirectories).ToList());
            //ImagePaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.jpg", System.IO.SearchOption.AllDirectories).ToList());
            //ImagePaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.jpeg", System.IO.SearchOption.AllDirectories).ToList());
            //ImagePaths.AddRange(System.IO.Directory.GetFiles(@"" + path, "*.gif", System.IO.SearchOption.AllDirectories).ToList());
            return ImagePaths;
        }



        public static String getImageName(String path)
        {
            List<Char> chars = path.ToList();
            Char actuall = '#';
            int pos = path.Length - 1;
            String imagename = "";
            while (actuall != '\\')
            {
                actuall = path[pos];
                pos -= 1;

            }
            for (int i = pos + 2; i < path.Length; i++)
            {
                imagename = imagename + path[i];
            }
            return imagename;

        }

        public static void Save(string path, string savepath, string name, string endung)
        {
            Image I = Image.FromFile(path);
            I.Save(savepath + @"\" + name + endung);
        }
    }
}
