using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UniTools
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////
        // CLICK EVENTS OF THE BUTTONS (EXIT, MAXIMIZE,  RESTORE AND MINIMIZE)
        /////////////////////////////////////////////////////////////////////
  
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
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

        private void pannel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator calculadora = new FrmCalculator(); 
            calculadora.Show();
        }

        private void BtnTextEditor_Click(object sender, EventArgs e)
        {
            FrmTextEditor textEditor = new FrmTextEditor();  
            textEditor.Show();  
        }

        private void BtnPaint_Click(object sender, EventArgs e)
        {
            FrmPaint paint = new FrmPaint();
            paint.Show();
        }
    }
}