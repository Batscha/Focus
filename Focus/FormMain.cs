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

namespace Focus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            Panel StartScreen = GenerateControls.StartScreen(this, buttonDirectory, buttonSaveDirectory, buttonStart);
            Controls.Add(StartScreen);



            ButtonSave.Select(); // Damit anfangs kein Button auf der Startseite ausgewählt ist :D
        }

        List<string> imagepaths = new List<string>();
        List<string> AlreadyUsed = new List<string>();
        Dictionary<string, string> nametopath = new Dictionary<string, string>();

        public void RefreshImages()
        {
            imagepaths.Clear();
            AlreadyUsed.Clear();
            nametopath.Clear();
            flowLayoutPanelPictures.Controls.Clear();

            if (Variablen.PicturesInFolder)
            {
                try
                {
                    imagepaths = Images.getImagesinFolder(Variablen.Path);
                    String firstpath = "";

                    foreach (String path in imagepaths)
                    {
                        if (!nametopath.ContainsKey(Images.getImageName(path)))
                        {
                            if (firstpath == "")
                            {
                                firstpath = path;
                            }
                            nametopath.Add(Images.getImageName(path), path);
                            PictureBox image = new PictureBox();
                            Image ThisImage = Image.FromFile(path);
                            if (ThisImage.Width >= ThisImage.Height)
                            {
                                image.Width = 256;
                                image.Height = 150;
                                image.SizeMode = PictureBoxSizeMode.StretchImage;
                                image.Name = Images.getImageName(path);
                                image.Visible = true;
                                image.Image = ThisImage;
                                image.Click += Image_Click;

                                AlreadyUsed.Add(Images.getImageName(path));
                                flowLayoutPanelPictures.Controls.Add(image);
                            }
                            else
                            {
                                image.Width = 125;
                                image.Height = 175;
                                image.SizeMode = PictureBoxSizeMode.StretchImage;
                                image.Name = Images.getImageName(path);
                                image.Visible = true;
                                image.Image = ThisImage;
                                image.Click += Image_Click;

                                AlreadyUsed.Add(Images.getImageName(path));
                                flowLayoutPanelPictures.Controls.Add(image);

                                bool Go = true;
                                foreach (string p in imagepaths)
                                {
                                    if (Go)
                                    {
                                        if (!AlreadyUsed.Contains(Images.getImageName(p)))
                                        {
                                            if (!(Image.FromFile(p).Width >= Image.FromFile(p).Height))
                                            {
                                                nametopath.Add(Images.getImageName(p), p);
                                                PictureBox I = new PictureBox();
                                                I.Width = 125;
                                                I.Height = 175;
                                                I.SizeMode = PictureBoxSizeMode.StretchImage;
                                                I.Name = Images.getImageName(p);
                                                I.Visible = true;
                                                I.Image = Image.FromFile(p);
                                                I.Click += Image_Click;

                                                AlreadyUsed.Add(Images.getImageName(p));
                                                flowLayoutPanelPictures.Controls.Add(I);
                                                Go = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    UpdatePreviewImage(firstpath);

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            else
            {
                MessageBox.Show("No Pics in Folder");
            }
        }
        private void Image_Click(object sender, EventArgs e)
        {
            UpdatePreviewImage(nametopath[((PictureBox)sender).Name]);
        }

        private void UpdatePreviewImage(string path)
        {
            Variablen.PreviewImagePath = path;
            pictureBoxPreview.Image = Image.FromFile(path);
            textBoxName.Text = Dateiendungen.NameOhneEndung(Images.getImageName(path));
        }

        private void SpeicherortWählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSaveDirectory_Click(sender, e);
        }

        private void UrsprungsverzeichnisWählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDirectory_Click(sender, e);
        }

        private void buttonOpenInEditor_Click(object sender, EventArgs e)
        {
            if (Variablen.PreviewImagePath != null)
            {
                Editor E = new Editor(Variablen.PreviewImagePath);
                E.ShowDialog();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Images.Save(Variablen.PreviewImagePath, Variablen.SpeicherortPath, textBoxName.Text, Variablen.Endung);
        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogMain.ShowDialog() == DialogResult.OK)
            {
                Variablen.Path = folderBrowserDialogMain.SelectedPath;
                Variablen.PicturesInFolder = PicturesInFolder();

            }
        }

        private void buttonSaveDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSpeicherort.ShowDialog() == DialogResult.OK)
            {
                Variablen.SpeicherortPath = folderBrowserDialogSpeicherort.SelectedPath;
                //ButtonChooseSpeicherort.Hide();
            }
        }

        private bool PicturesInFolder()
        {
            bool B = false;
            try
            {
                Images.getImagesinFolder(Variablen.Path);
                B = true;
            }
            catch{}
            return B;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            RefreshImages();
        }
    }
}
