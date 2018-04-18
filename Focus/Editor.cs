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
using System.Diagnostics;

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
            BMPEdit = EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonResetSize_Click(object sender, EventArgs e)
        {
            trackBarBrightness.Value = 0;
            trackBarContrast.Value = 0;
            trackBarGamma.Value = 22;
            pictureBoxMain.Image = BMPOriginal;
            BMPEdit = BMPOriginal;
            numericUpDownHeight.Value = OriginalHeight;
            numericUpDownWidth.Value = OriginalWidth;
            labelHöhePX.Text = OriginalHeight.ToString() + " px";
            labelBreitePX.Text = OriginalWidth.ToString() + " px";
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
            trackBarBrightness.Value = 0;
            trackBarContrast.Value = 0;
            trackBarGamma.Value = 22;
            BMPEdit = (Bitmap)pictureBoxMain.Image;
            buttonResize.BackColor = Color.White;
        }

        private void Change(object sender, EventArgs e)
        {
            buttonResize.BackColor = Color.IndianRed;
            BackgroundWorker g = new BackgroundWorker();
            pictureBoxLoadingGIF.Visible = true;
            pictureBoxLoadingGIF.Enabled = true;
            g.DoWork += G_DoWork;
            g.RunWorkerCompleted += G_RunWorkerCompleted;
            g.RunWorkerAsync();
        }

        private void G_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBoxLoadingGIF.Visible = false;
            pictureBoxLoadingGIF.Enabled = false;
        }

        private void G_DoWork(object sender, DoWorkEventArgs e)
        {
            pictureBoxMain.Invoke(new Action(() =>
            {
                pictureBoxMain.Image = EditImage.Edit(EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value)), trackBarContrast.Value, trackBarBrightness.Value, trackBarGamma.Value, false); EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
            }
            ));
        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownWidth.Value != BMPOriginal.Width)
            {
                buttonResize.BackColor = Color.IndianRed;
            }
            else
            {
                buttonResize.BackColor = Color.White;
            }
            pictureBoxMain.Image = EditImage.Edit(EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value)), trackBarContrast.Value, trackBarBrightness.Value, trackBarGamma.Value, false); EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            if(BMPOriginal.Height != numericUpDownHeight.Value)
            {
                buttonResize.BackColor = Color.IndianRed;
            }
            else
            {
                buttonResize.BackColor = Color.White;
            }
             pictureBoxMain.Image = EditImage.Edit(EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value)), trackBarContrast.Value, trackBarBrightness.Value, trackBarGamma.Value, false);EditImage.Resize(BMPEdit, Convert.ToInt32(numericUpDownWidth.Value), Convert.ToInt32(numericUpDownHeight.Value));
        }
    }
}
