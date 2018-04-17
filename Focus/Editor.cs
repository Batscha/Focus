using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Imaging.Filters;

namespace Focus
{
    public partial class Editor : Form
    {
        string Path;
        Bitmap BMPOriginal;
        Bitmap BMPEdit;

        int OriginalHeight;
        int OriginalWidth;

        public Editor(string path)
        {
            InitializeComponent();
            Path = path;
            BMPOriginal = new Bitmap(Image.FromFile(path));
            BMPEdit = new Bitmap(BMPOriginal);

            OriginalHeight = BMPOriginal.Height;
            OriginalWidth = BMPOriginal.Width;
            numericUpDownHeight.Value = OriginalHeight;
            numericUpDownWidth.Value = OriginalWidth;

            pictureBoxMain.Image = BMPOriginal;
            textBoxName.Text = Dateiendungen.NameOhneEndung(Images.getImageName(Path)) + "_Bearbeitet";
            labelHöhePX.Text = BMPOriginal.Height.ToString() + " px";
            labelBreitePX.Text = BMPOriginal.Width.ToString() + " px";
            labelErstelldatum.Text = "Erstelldatum " + File.GetCreationTime(Path) + " Uhr";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonResetSize_Click(object sender, EventArgs e)
        {
            //BMPEdit = BMP;
            //numericUpDownHeight.Value = OriginalHeight;
            //numericUpDownWidth.Value = OriginalWidth;
            //labelHöhePX.Text = OriginalHeight.ToString() + " px";
            //labelBreitePX.Text = OriginalWidth.ToString() + " px";
        }

        private void bunifuFlatButtonSave_Click(object sender, EventArgs e)
        {
            //Überprüfe ob Name bereits vorhanden
            //Save
            Form Main = Application.OpenForms[0];
            ((FormMain)Main).RefreshImages();
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {        
            pictureBoxMain.Image = EditImage.Resize(BMPEdit,Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
        }

        private void Change(object sender, EventArgs e)
        {
            pictureBoxMain.Image = EditImage.Edit(BMPEdit, trackBarContrast.Value, trackBarBrightness.Value , trackBarGamma.Value, checkBoxOilPainting.Checked);
        }
    }
}
