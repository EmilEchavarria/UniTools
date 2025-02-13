namespace UniTools
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnPlusMinus = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDecimalPoint = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnSquareRoot = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnReciprocal = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.BtnPercentage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.LblHeader.Location = new System.Drawing.Point(-1, -1);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(341, 38);
            this.LblHeader.TabIndex = 26;
            this.LblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblHeader_MouseDown);
            // 
            // LblResult
            // 
            this.LblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(223)))), ((int)(((byte)(236)))));
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(6, 48);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(329, 72);
            this.LblResult.TabIndex = 25;
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.LblName.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblName.Location = new System.Drawing.Point(43, 11);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(68, 17);
            this.LblName.TabIndex = 27;
            this.LblName.Text = "UniTools";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.pictureBox2.Image = global::UniTools.Properties.Resources.icon_100x100;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.Image = global::UniTools.Properties.Resources.image__4_;
            this.BtnMinimize.Location = new System.Drawing.Point(285, 10);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(17, 17);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 30;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(53)))), ((int)(((byte)(80)))));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Image = global::UniTools.Properties.Resources.image__1_;
            this.BtnExit.Location = new System.Drawing.Point(311, 10);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(17, 17);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExit.TabIndex = 31;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnSubtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubtraction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnSubtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSubtraction.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtraction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSubtraction.Location = new System.Drawing.Point(252, 323);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(83, 67);
            this.BtnSubtraction.TabIndex = 16;
            this.BtnSubtraction.Text = "−";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnSubtraction_Click);
            // 
            // Btn6
            // 
            this.Btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn6.Location = new System.Drawing.Point(171, 323);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(83, 67);
            this.Btn6.TabIndex = 15;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn1
            // 
            this.Btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Location = new System.Drawing.Point(6, 387);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(83, 67);
            this.Btn1.TabIndex = 17;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn5
            // 
            this.Btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn5.Location = new System.Drawing.Point(89, 323);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(83, 67);
            this.Btn5.TabIndex = 14;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn2
            // 
            this.Btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Location = new System.Drawing.Point(89, 387);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(83, 67);
            this.Btn2.TabIndex = 18;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn4
            // 
            this.Btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn4.Location = new System.Drawing.Point(6, 322);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(83, 67);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn3
            // 
            this.Btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn3.Location = new System.Drawing.Point(171, 387);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(83, 67);
            this.Btn3.TabIndex = 19;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnMultiplication.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiplication.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMultiplication.Location = new System.Drawing.Point(252, 258);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(83, 67);
            this.BtnMultiplication.TabIndex = 12;
            this.BtnMultiplication.Text = "X";
            this.BtnMultiplication.UseVisualStyleBackColor = false;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnMultiplication_Click);
            // 
            // BtnAddition
            // 
            this.BtnAddition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnAddition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddition.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnAddition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddition.Location = new System.Drawing.Point(252, 387);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(83, 67);
            this.BtnAddition.TabIndex = 20;
            this.BtnAddition.Text = "+";
            this.BtnAddition.UseVisualStyleBackColor = false;
            this.BtnAddition.Click += new System.EventHandler(this.BtnAddition_Click);
            // 
            // Btn9
            // 
            this.Btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn9.Location = new System.Drawing.Point(170, 258);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(83, 67);
            this.Btn9.TabIndex = 11;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnPlusMinus
            // 
            this.BtnPlusMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BtnPlusMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnPlusMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlusMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPlusMinus.Location = new System.Drawing.Point(6, 453);
            this.BtnPlusMinus.Name = "BtnPlusMinus";
            this.BtnPlusMinus.Size = new System.Drawing.Size(83, 67);
            this.BtnPlusMinus.TabIndex = 21;
            this.BtnPlusMinus.Text = "+/-";
            this.BtnPlusMinus.UseVisualStyleBackColor = false;
            this.BtnPlusMinus.Click += new System.EventHandler(this.BtnPlusMinus_Click);
            // 
            // Btn8
            // 
            this.Btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn8.Location = new System.Drawing.Point(89, 258);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(83, 67);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn0
            // 
            this.Btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn0.Location = new System.Drawing.Point(89, 453);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(83, 67);
            this.Btn0.TabIndex = 22;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // Btn7
            // 
            this.Btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn7.Location = new System.Drawing.Point(6, 258);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(83, 67);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnDecimalPoint
            // 
            this.BtnDecimalPoint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDecimalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BtnDecimalPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDecimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnDecimalPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnDecimalPoint.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecimalPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDecimalPoint.Location = new System.Drawing.Point(171, 453);
            this.BtnDecimalPoint.Name = "BtnDecimalPoint";
            this.BtnDecimalPoint.Size = new System.Drawing.Size(83, 67);
            this.BtnDecimalPoint.TabIndex = 23;
            this.BtnDecimalPoint.Text = ".";
            this.BtnDecimalPoint.UseVisualStyleBackColor = false;
            this.BtnDecimalPoint.Click += new System.EventHandler(this.BtnDecimalPoint_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnDivision.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDivision.Location = new System.Drawing.Point(252, 193);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(83, 67);
            this.BtnDivision.TabIndex = 8;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEqual.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnEqual.FlatAppearance.BorderSize = 14;
            this.BtnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnEqual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEqual.Location = new System.Drawing.Point(252, 453);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(83, 67);
            this.BtnEqual.TabIndex = 24;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnSquareRoot
            // 
            this.BtnSquareRoot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BtnSquareRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSquareRoot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnSquareRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSquareRoot.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquareRoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSquareRoot.Location = new System.Drawing.Point(170, 193);
            this.BtnSquareRoot.Name = "BtnSquareRoot";
            this.BtnSquareRoot.Size = new System.Drawing.Size(83, 67);
            this.BtnSquareRoot.TabIndex = 7;
            this.BtnSquareRoot.Text = "²√χ";
            this.BtnSquareRoot.UseVisualStyleBackColor = false;
            this.BtnSquareRoot.Click += new System.EventHandler(this.BtnSquareRoot_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BtnSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSquare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSquare.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSquare.Location = new System.Drawing.Point(88, 193);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(83, 67);
            this.BtnSquare.TabIndex = 6;
            this.BtnSquare.Text = "χ²";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // BtnReciprocal
            // 
            this.BtnReciprocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnReciprocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.BtnReciprocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReciprocal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnReciprocal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnReciprocal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReciprocal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReciprocal.Location = new System.Drawing.Point(6, 193);
            this.BtnReciprocal.Name = "BtnReciprocal";
            this.BtnReciprocal.Size = new System.Drawing.Size(83, 67);
            this.BtnReciprocal.TabIndex = 5;
            this.BtnReciprocal.Text = "1/x";
            this.BtnReciprocal.UseVisualStyleBackColor = false;
            this.BtnReciprocal.Click += new System.EventHandler(this.BtnReciprocal_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClear.Location = new System.Drawing.Point(170, 128);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(83, 67);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnBackspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackspace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBackspace.Image = global::UniTools.Properties.Resources.Backspace27x27;
            this.BtnBackspace.Location = new System.Drawing.Point(252, 128);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(83, 67);
            this.BtnBackspace.TabIndex = 4;
            this.BtnBackspace.UseVisualStyleBackColor = false;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnClearEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnClearEntry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClearEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClearEntry.Location = new System.Drawing.Point(88, 128);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(83, 67);
            this.BtnClearEntry.TabIndex = 2;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = false;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // BtnPercentage
            // 
            this.BtnPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.BtnPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPercentage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnPercentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnPercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercentage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPercentage.Location = new System.Drawing.Point(6, 128);
            this.BtnPercentage.Name = "BtnPercentage";
            this.BtnPercentage.Size = new System.Drawing.Size(83, 67);
            this.BtnPercentage.TabIndex = 1;
            this.BtnPercentage.Text = "%";
            this.BtnPercentage.UseVisualStyleBackColor = false;
            this.BtnPercentage.Click += new System.EventHandler(this.BtnPercentage_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(340, 525);
            this.Controls.Add(this.BtnPercentage);
            this.Controls.Add(this.BtnClearEntry);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnReciprocal);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSquareRoot);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnDecimalPoint);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnPlusMinus);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnAddition);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnMultiplication);
            this.Controls.Add(this.Btn3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalculator";
            this.Text = "frmCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnMultiplication;
        private System.Windows.Forms.Button BtnAddition;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnPlusMinus;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDecimalPoint;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnSquareRoot;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnReciprocal;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.Button BtnPercentage;
    }
}