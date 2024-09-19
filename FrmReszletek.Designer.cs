namespace WFA240801
{
    partial class FrmReszletek
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
            lblUI01 = new Label();
            tbxNev = new TextBox();
            nudFizu = new NumericUpDown();
            dtpSzul = new DateTimePicker();
            chbJogsi = new CheckBox();
            lblMain = new Label();
            nudID = new NumericUpDown();
            lblUI02 = new Label();
            lblUI03 = new Label();
            lblUI04 = new Label();
            btnMain = new Button();
            btnTorles = new Button();
            ((System.ComponentModel.ISupportInitialize)nudFizu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudID).BeginInit();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Font = new Font("Segoe UI", 10F);
            lblUI01.Location = new Point(12, 70);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(27, 23);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "ID";
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(72, 96);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(259, 34);
            tbxNev.TabIndex = 1;
            // 
            // nudFizu
            // 
            nudFizu.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudFizu.Location = new Point(209, 173);
            nudFizu.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFizu.Name = "nudFizu";
            nudFizu.Size = new Size(122, 34);
            nudFizu.TabIndex = 3;
            nudFizu.TextAlign = HorizontalAlignment.Right;
            nudFizu.ThousandsSeparator = true;
            nudFizu.Value = new decimal(new int[] { 350000, 0, 0, 0 });
            // 
            // dtpSzul
            // 
            dtpSzul.Format = DateTimePickerFormat.Short;
            dtpSzul.Location = new Point(12, 173);
            dtpSzul.Name = "dtpSzul";
            dtpSzul.Size = new Size(191, 34);
            dtpSzul.TabIndex = 2;
            dtpSzul.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // chbJogsi
            // 
            chbJogsi.AutoSize = true;
            chbJogsi.FlatStyle = FlatStyle.System;
            chbJogsi.Location = new Point(33, 223);
            chbJogsi.Name = "chbJogsi";
            chbJogsi.Size = new Size(275, 33);
            chbJogsi.TabIndex = 4;
            chbJogsi.Text = "rendelkezik jogosítvánnyal";
            chbJogsi.TextAlign = ContentAlignment.MiddleCenter;
            chbJogsi.TextImageRelation = TextImageRelation.ImageAboveText;
            chbJogsi.UseVisualStyleBackColor = true;
            // 
            // lblMain
            // 
            lblMain.Font = new Font("Segoe UI", 12F);
            lblMain.Location = new Point(12, 9);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(319, 50);
            lblMain.TabIndex = 0;
            lblMain.Text = "új személy adatai:";
            lblMain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudID
            // 
            nudID.Enabled = false;
            nudID.InterceptArrowKeys = false;
            nudID.Location = new Point(12, 96);
            nudID.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudID.Name = "nudID";
            nudID.ReadOnly = true;
            nudID.Size = new Size(54, 34);
            nudID.TabIndex = 2;
            nudID.TabStop = false;
            nudID.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Font = new Font("Segoe UI", 10F);
            lblUI02.Location = new Point(72, 70);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(44, 23);
            lblUI02.TabIndex = 0;
            lblUI02.Text = "Név:";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Font = new Font("Segoe UI", 10F);
            lblUI03.Location = new Point(12, 147);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(135, 23);
            lblUI03.TabIndex = 0;
            lblUI03.Text = "Születési dátum:";
            // 
            // lblUI04
            // 
            lblUI04.AutoSize = true;
            lblUI04.Font = new Font("Segoe UI", 10F);
            lblUI04.Location = new Point(213, 147);
            lblUI04.Name = "lblUI04";
            lblUI04.Size = new Size(65, 23);
            lblUI04.TabIndex = 0;
            lblUI04.Text = "Fizetés:";
            // 
            // btnMain
            // 
            btnMain.Location = new Point(12, 274);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(240, 52);
            btnMain.TabIndex = 5;
            btnMain.Text = "---------";
            btnMain.UseVisualStyleBackColor = true;
            // 
            // btnTorles
            // 
            btnTorles.BackColor = Color.Coral;
            btnTorles.Enabled = false;
            btnTorles.Location = new Point(258, 274);
            btnTorles.Name = "btnTorles";
            btnTorles.Size = new Size(73, 52);
            btnTorles.TabIndex = 5;
            btnTorles.Text = "Törlés";
            btnTorles.UseVisualStyleBackColor = false;
            // 
            // FrmReszletek
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 338);
            Controls.Add(btnTorles);
            Controls.Add(btnMain);
            Controls.Add(chbJogsi);
            Controls.Add(dtpSzul);
            Controls.Add(nudID);
            Controls.Add(nudFizu);
            Controls.Add(tbxNev);
            Controls.Add(lblMain);
            Controls.Add(lblUI04);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmReszletek";
            Text = "FrmReszletek";
            ((System.ComponentModel.ISupportInitialize)nudFizu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private TextBox tbxNev;
        private NumericUpDown nudFizu;
        private DateTimePicker dtpSzul;
        private CheckBox chbJogsi;
        private Label lblMain;
        private NumericUpDown nudID;
        private Label lblUI02;
        private Label lblUI03;
        private Label lblUI04;
        private Button btnMain;
        private Button btnTorles;
    }
}