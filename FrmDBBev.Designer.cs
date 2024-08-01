namespace WFA240801
{
    partial class FrmDBBev
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvSzemelyek = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNev = new DataGridViewTextBoxColumn();
            colSzul = new DataGridViewTextBoxColumn();
            colJogsi = new DataGridViewCheckBoxColumn();
            colFizu = new DataGridViewTextBoxColumn();
            tbxKereso = new TextBox();
            btnUjRekord = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSzemelyek).BeginInit();
            SuspendLayout();
            // 
            // dgvSzemelyek
            // 
            dgvSzemelyek.AllowUserToAddRows = false;
            dgvSzemelyek.AllowUserToDeleteRows = false;
            dgvSzemelyek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSzemelyek.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSzemelyek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSzemelyek.Columns.AddRange(new DataGridViewColumn[] { colID, colNev, colSzul, colJogsi, colFizu });
            dgvSzemelyek.Location = new Point(12, 52);
            dgvSzemelyek.Name = "dgvSzemelyek";
            dgvSzemelyek.ReadOnly = true;
            dgvSzemelyek.RowHeadersVisible = false;
            dgvSzemelyek.RowHeadersWidth = 51;
            dgvSzemelyek.Size = new Size(1158, 389);
            dgvSzemelyek.TabIndex = 0;
            // 
            // colID
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colID.DefaultCellStyle = dataGridViewCellStyle1;
            colID.FillWeight = 1F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colNev
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colNev.DefaultCellStyle = dataGridViewCellStyle2;
            colNev.FillWeight = 3F;
            colNev.HeaderText = "Név";
            colNev.MinimumWidth = 6;
            colNev.Name = "colNev";
            colNev.ReadOnly = true;
            // 
            // colSzul
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSzul.DefaultCellStyle = dataGridViewCellStyle3;
            colSzul.FillWeight = 2F;
            colSzul.HeaderText = "Születési dátum";
            colSzul.MinimumWidth = 6;
            colSzul.Name = "colSzul";
            colSzul.ReadOnly = true;
            // 
            // colJogsi
            // 
            colJogsi.FillWeight = 1F;
            colJogsi.HeaderText = "Jogosítvány?";
            colJogsi.MinimumWidth = 6;
            colJogsi.Name = "colJogsi";
            colJogsi.ReadOnly = true;
            // 
            // colFizu
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            colFizu.DefaultCellStyle = dataGridViewCellStyle4;
            colFizu.FillWeight = 2F;
            colFizu.HeaderText = "Fizetés";
            colFizu.MinimumWidth = 6;
            colFizu.Name = "colFizu";
            colFizu.ReadOnly = true;
            colFizu.Resizable = DataGridViewTriState.True;
            colFizu.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // tbxKereso
            // 
            tbxKereso.Location = new Point(12, 12);
            tbxKereso.Name = "tbxKereso";
            tbxKereso.PlaceholderText = "adatok név alapján történő szűréséhez gépeljen ide....";
            tbxKereso.Size = new Size(899, 34);
            tbxKereso.TabIndex = 1;
            // 
            // btnUjRekord
            // 
            btnUjRekord.Font = new Font("Segoe UI", 10F);
            btnUjRekord.Location = new Point(917, 12);
            btnUjRekord.Name = "btnUjRekord";
            btnUjRekord.Size = new Size(253, 34);
            btnUjRekord.TabIndex = 2;
            btnUjRekord.Text = "új rekord hozzáadása";
            btnUjRekord.UseVisualStyleBackColor = true;
            // 
            // FrmDBBev
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(btnUjRekord);
            Controls.Add(tbxKereso);
            Controls.Add(dgvSzemelyek);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmDBBev";
            Text = "Adattábla megjelenítés, módosítás, szűrés";
            ((System.ComponentModel.ISupportInitialize)dgvSzemelyek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSzemelyek;
        private TextBox tbxKereso;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNev;
        private DataGridViewTextBoxColumn colSzul;
        private DataGridViewCheckBoxColumn colJogsi;
        private DataGridViewTextBoxColumn colFizu;
        private Button btnUjRekord;
    }
}
