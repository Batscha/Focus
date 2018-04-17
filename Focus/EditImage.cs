using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;
using System.Windows.Forms;

namespace Focus
{
    public class EditImage
    {
        public static Bitmap Edit(Bitmap BMPEdit, int contrast, int brightness, int gamma, bool OilP)
        {
            if (contrast != 1)//Contrast
            {
                ContrastCorrection ContrastC = new ContrastCorrection(contrast);
                BMPEdit = ContrastC.Apply(BMPEdit);
            }
            if (brightness != 1)//Brightness
            {
                BrightnessCorrection BrightnessC = new BrightnessCorrection(brightness);
                BMPEdit = BrightnessC.Apply(BMPEdit);
            }
            //if (gamma != 0)
            //{
            //    GammaCorrection GammaC = new GammaCorrection(gamma);
            //    BMPEdit = GammaC.Apply(BMPEdit);
            //}
            if (OilP)
            {
                OilPainting OilPaint = new OilPainting(10);
                BMPEdit = OilPaint.Apply(BMPEdit);
            }



            return BMPEdit;
        }

        public static Bitmap Resize(Bitmap BMPEdit, int NewWidth, int NewHeight)
        {
            ResizeBilinear filter = new ResizeBilinear(NewWidth, NewHeight);
            BMPEdit = filter.Apply(BMPEdit);
            return BMPEdit;
        }
    }
}
