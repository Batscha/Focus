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

            StartScreen = GenerateControls.StartScreen(this, buttonStart);
            Controls.Add(StartScreen);

            ButtonSave.Select(); // Damit anfangs kein Button auf der Startseite ausgewählt ist :D
        }

        List<string> imagepaths = new List<string>();
        List<string> AlreadyUsed = new List<string>();
        Dictionary<string, string> nametopath = new Dictionary<string, string>();
        Panel StartScreen;

        public void RefreshImages()
        {
            imagepaths.Clear();
            nametopath.Clear();
            flowLayoutPanelPictures.Controls.Clear();
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

                            flowLayoutPanelPictures.Controls.Add(image);
                        }
                        else
                        {
                            image.Width = 256;
                            image.Height = 150;
                            image.SizeMode = PictureBoxSizeMode.Zoom;
                            image.Name = Images.getImageName(path);
                            image.Visible = true;
                            image.Image = ThisImage;
                            image.Click += Image_Click;

                            flowLayoutPanelPictures.Controls.Add(image);
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogMain.ShowDialog() == DialogResult.OK)
            {
                Variablen.Path = folderBrowserDialogMain.SelectedPath;
                imagepaths = Images.getImagesinFolder(Variablen.Path);
                if (imagepaths.Count != 0)
                {
                    StartScreen.Hide();

                    flowLayoutPanelPictures.Show();
                    flowLayoutPanelRecently.Show();
                    panelPreview.Show();

                    RefreshImages();
                }
                else
                {
                    buttonStart_Click(sender, e); // keine Bilder
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach (Control C in StartScreen.Controls)
            {
                C.Location = new Point(StartScreen.Size.Width / 2 - C.Size.Width / 2 - 10, C.Location.Y); // -10 als Ausgleich
            }
        }
    }
}
