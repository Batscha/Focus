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
        public static Panel StartScreen(FormMain F, Button ButtonStart)
        {
            Panel StartScreen = new Panel();
            StartScreen.Location = new Point(0, 0);
            StartScreen.Size = F.Size;
            StartScreen.BackColor = Color.FromArgb(26, 10, 51);
            StartScreen.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);

            ButtonStart.Location = new Point(0, 500);

            PictureBox PictureBoxIcon = new PictureBox();
            PictureBoxIcon.Location = new Point(0, 200);
            PictureBoxIcon.Size = new Size(300, 300);
            PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxIcon.Image = Focus.Properties.Resources.Camera_2_icon;

            StartScreen.Controls.Add(PictureBoxIcon);
            StartScreen.Controls.Add(ButtonStart);
            return StartScreen;
        }
    }
}
