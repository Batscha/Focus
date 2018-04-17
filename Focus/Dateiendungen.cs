using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Focus
{
    class Dateiendungen
    {
        public static string NameOhneEndung(string FullName)
        {
            if (FullName.Contains(".jpg"))
            {
                Variablen.Endung = ".jpg";
                return FullName.Remove(FullName.Length - 4);
            }
            if (FullName.Contains(".JPG"))
            {
                Variablen.Endung = ".JPG";
                return FullName.Remove(FullName.Length - 4);
            }
            if (FullName.Contains(".png"))
            {
                Variablen.Endung = ".png";
                return FullName.Remove(FullName.Length - 4);
            }
            if (FullName.Contains(".gif"))
            {
                Variablen.Endung = ".gif";
                return FullName.Remove(FullName.Length - 4);
            }
            if (FullName.Contains(".jpeg"))
            {
                Variablen.Endung = ".jpeg";
                return FullName.Remove(FullName.Length - 5);
            }
            return FullName;
        }

    }
}
