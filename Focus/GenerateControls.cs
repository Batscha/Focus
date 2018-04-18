using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Focus
{
    class GenerateControls
    {
        public static Panel StartScreen(FormMain F, Button ButtonDirectory, Button ButtonSaveDirectory, Button ButtonStart)
        {
            Panel StartScreen = new Panel();
            StartScreen.Location = new Point(0, 0);
            StartScreen.Size = F.Size;
            StartScreen.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);

            ButtonDirectory.Location = new Point(50, 360);
            ButtonSaveDirectory.Location = new Point(50, 410);
            ButtonStart.Location = new Point(50, 460);

            PictureBox PictureBoxIcon = new PictureBox();
            PictureBoxIcon.Location = new Point(50, 50);
            PictureBoxIcon.Size = new Size(300, 300);
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxIcon.Image = Focus.Properties.Resources.Camera_2_icon;

            StartScreen.Controls.Add(PictureBoxIcon);
            StartScreen.Controls.Add(ButtonDirectory);
            StartScreen.Controls.Add(ButtonSaveDirectory);
            StartScreen.Controls.Add(ButtonStart);
            return StartScreen;
        }
    }
}
