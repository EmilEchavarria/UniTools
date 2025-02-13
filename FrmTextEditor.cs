using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using Xceed.Words.NET;
using iText.Layout.Properties;

namespace UniTools
{
    public partial class FrmTextEditor : Form
    {
        public FrmTextEditor()
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




        /////////////////////////////////////////////////////////////////////
        ////CONFIGURATION OF ARCHIV MENU 
        //////////////////////////////////////////////////////////////////////




        private void NuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)  //This method allows the user to create a new tab in the text editor.
        {
            TabPage nuevaPestaña = new TabPage("Nueva Pestaña")
            {
                Dock = DockStyle.Fill
            };

            RichTextBox richTextBox = new RichTextBox //This method allows the user to create a new tab in the text editor.
            {
                Multiline = true, 
                Dock = DockStyle.Fill,
                ScrollBars = RichTextBoxScrollBars.Both,
                BackColor = Color.FromArgb(0, 10, 37),
                ForeColor = Color.Snow,
                Font = new Font("Consolas", 16)
            };

            nuevaPestaña.Controls.Add(richTextBox);
            TabControl.TabPages.Add(nuevaPestaña);
            TabControl.SelectedTab = nuevaPestaña;
        }



        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)  //This method allows the user to create a new window in the text editor.
        {
            FrmTextEditor textEditor = new FrmTextEditor();
            textEditor.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)    //This method allows the user to exit the text editor.
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) //This method allows the user to open a file in the text editor.
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Filter for text files
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = System.IO.File.ReadAllText(filePath);

                    TabPage nuevaPestaña = new TabPage(System.IO.Path.GetFileName(filePath)) // Create a new tab with the name of the file
                    {
                        Dock = DockStyle.Fill
                    };

                    RichTextBox richTextBox = new RichTextBox
                    {
                        Multiline = true,
                        Dock = DockStyle.Fill,
                        ScrollBars = RichTextBoxScrollBars.Both,
                        BackColor = Color.FromArgb(0, 20, 47),
                        ForeColor = Color.Snow,
                        Font = new Font("Consolas", 16),
                        Text = fileContent
                    };

                    nuevaPestaña.Controls.Add(richTextBox);
                    TabControl.TabPages.Add(nuevaPestaña);
                    TabControl.SelectedTab = nuevaPestaña;
                }
            }
        }

        private void guardatToolStripMenuItem_Click(object sender, EventArgs e) 
        { ///This method allows the user to save a file in the text editor.
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    System.IO.File.WriteAllText(filePath, richTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna pestaña seleccionada o la pestaña no contiene un RichTextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //This method allows the user to save a file in the text editor.
        {
            if (keyData == (Keys.Control | Keys.S)) // Ctrl + S
            {
                guardatToolStripMenuItem_Click(this, new EventArgs()); 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new SaveFileDialog  object 
            SaveFileDialog saveFileDialog = new SaveFileDialog();//This method allows the user to save a file in the text editor.
            saveFileDialog.Filter = "Archivo PDF (*.pdf)|*.pdf"; // Filter for PDF files
            saveFileDialog.Title = "Guardar como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GuardarComoPdf(filePath); // Save the file as PDF
            }
        }

        private void GuardarComoPdf(string filePath)  
        {
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = filePath;

            printDoc.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            printDoc.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawString(RtxtMainText.Text, new Font("Arial", 12), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top);
            };

            printDoc.Print();
        }

     
     


            private void imprimirToolStripMenuItem_Click(object sender, EventArgs e) //This method allows the user to print a file in the text editor.
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox) // Check if the selected tab contains a RichTextBox
            {
                PrintDocument printDocument = new PrintDocument(); // Create a new PrintDocument object
                printDocument.PrintPage += (s, ev) => // Print the content of the RichTextBox
                {
                    int charactersOnPage = 0;
                    int linesPerPage = 0;

                    ev.Graphics.MeasureString(richTextBox.Text, richTextBox.Font, ev.MarginBounds.Size,  // Measure the string within the bounds of the page
                        StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

                    ev.Graphics.DrawString(richTextBox.Text.Substring(0, charactersOnPage), richTextBox.Font,
                        Brushes.Black, ev.MarginBounds, StringFormat.GenericTypographic);

                    richTextBox.Text = richTextBox.Text.Substring(charactersOnPage); // Remove the printed characters from the RichTextBox

                    ev.HasMorePages = (richTextBox.Text.Length > 0);
                };

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna pestaña seleccionada o la pestaña no contiene un RichTextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cerrarPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null)
            {
                TabControl.TabPages.Remove(TabControl.SelectedTab);
            }
            else
            {
                MessageBox.Show("No hay ninguna pestaña seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cerrarVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                if (richTextBox.CanUndo)
                {
                    richTextBox.Undo();
                }
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.Cut();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.Copy();
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.Paste();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.SelectedText = "";
            }
        }

       

       

       
       
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.SelectAll();
            }
        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.ZoomFactor += 0.1f;
            }
        }

        private void alejarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.ZoomFactor -= 0.1f;
            }
        }

        private void fechaYHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TabControl.SelectedTab != null && TabControl.SelectedTab.Controls[0] is RichTextBox richTextBox)
            {
                richTextBox.AppendText(DateTime.Now.ToString("g"));
            }
        }

       
    }
}
