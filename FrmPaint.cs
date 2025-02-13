using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniTools
{
    public partial class FrmPaint : Form
    {
        public FrmPaint()
        {
            InitializeComponent();
        }


        /////////////////////////////////////////////////////////////////////
        // CLICK EVENTS OF THE BUTTONS (EXIT, MAXIMIZE,  RESTORE AND MINIMIZE)
        /////////////////////////////////////////////////////////////////////

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximize.Visible = false;
            BtnRestore.Visible = true;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestore.Visible = false;
            BtnMaximize.Visible = true;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /////////////////////////////////////////////////////////////////////
        /// This method allows the user to move the form by clicking on the panel.
        //////////////////////////////////////////////////////////////////////


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void LblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(Properties.Resources.lapiz);

            int newWidth = 32;  
            int newHeight = 32; 
            Bitmap resizedBitmap = new Bitmap(bitmap, newWidth, newHeight);

            IntPtr hIcon = resizedBitmap.GetHicon();
            Cursor customCursor = new Cursor(hIcon);

            this.Cursor = customCursor;
        }

        /////////////////////////////////////////////////////////////////////
        /// This method allows the user to draw on the panel.\
        /////////////////////////////////////////////////////////////////////

       

        private void BtnBlack_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Black;
        }

        private void BtnDarkGray_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkGray;
        }

        private void BtnGray_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Gray;
        }

        private void BtnDarkRed_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkRed;
        }

        private void BtnMaroon_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Maroon;
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Red;
        }

        private void BtnDarkBrown_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.SaddleBrown;
        }

        private void BtnBrown_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Brown;
        }

        private void BtnDarkOrange_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkOrange;
        }

        private void BtnDarkOlive_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.OliveDrab;
        }

        private void BtnOlive_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Olive;
        }

        private void BtnDarkLime_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LimeGreen;
        }

        private void BtnDarkGreen_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkGreen;
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Green;
        }

        private void BtnGreen2_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.ForestGreen;
        }

        private void BtnDarkTeal_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Teal;
        }

        private void BtnTeal_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.MediumTurquoise;
        }

        private void BtnDarkCyan_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkCyan;
        }

        private void BtnDarkNavy_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Navy;
        }

        private void BtnNavy_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.MediumBlue;
        }

        private void BtnDarkBlue_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkBlue;
        }

        private void BtnUltraDarkPurple_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Indigo;
        }

        private void BtnDarkPurple_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Purple;
        }

        private void BtnDarkMagenta_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.DarkMagenta;
        }

        private void BtnSilver_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Silver;
        }

        private void BtnLightSilver_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightGray;
        }

        private void BtnWhite_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.White;
        }

        private void BtnRed1_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.IndianRed;
        }

        private void BtnLightRed_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightCoral;
        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightSalmon;
        }

        private void BtnOrange_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Orange;
        }

        private void BtnLightOrange_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.SandyBrown;
        }

        private void BtnUltraLightOrange_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.PeachPuff;
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Yellow;
        }

        private void BtnLightYellow_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightYellow;
        }

        private void BtnUltraLightYellow_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LemonChiffon;
        }

        private void BtnLime_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Lime;
        }

        private void BtnLightGreen_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightGreen;
        }

        private void BtnLightLime_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.PaleGreen;
        }

        private void BtnCyan_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Cyan;
        }

        private void BtnLightBlue_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightBlue;
        }

        private void BtnLightCyan_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.PaleTurquoise;
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Blue;
        }

        private void BtnLightPurple_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Plum;
        }

        private void BtnUltraLightPurple_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Thistle;
        }

        private void BtnMagenta_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Magenta;
        }

        private void BtnPink_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.Pink;
        }

        private void BtnLightpink_Click(object sender, EventArgs e)
        {
            pictureBoxPaint.BackColor = Color.LightPink;
        }
    }
}
