using Microsoft.Data.SqlClient;

namespace WFA240801
{
    public partial class FrmReszletek : Form
    {
        public FrmReszletek(
            int id = 0, 
            string nev = null,
            DateTime? szul = null,
            bool jogsi = false,
            int fizetes = 300000)
        {
            InitializeComponent();
            btnMain.Click += BtnMain_Click;

            nudID.Value = id;
            tbxNev.Text = nev;
            if(szul is not null) dtpSzul.Value = (DateTime)szul;
            chbJogsi.Checked = jogsi;
            nudFizu.Value = fizetes;

            if (nudID.Value == 0)
            {
                btnMain.BackColor = Color.LightGreen;
                btnMain.Text = "Hozzáadás";
                btnTorles.Enabled = false;
            }
            else
            {
                btnMain.BackColor = Color.LightBlue;
                btnMain.Text = "Módosítás";
                btnTorles.Enabled = true;
            }

            btnTorles.Click += BtnTorles_Click;
        }

        private void BtnTorles_Click(object? sender, EventArgs e)
        {
            var res = MessageBox.Show(
                caption: "TÖRLÉS",
                text: "biztosan törölni kívánja a rekordot?",
                buttons: MessageBoxButtons.YesNoCancel,
                icon: MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;

            using SqlConnection connection = new(Program.connstr);
            connection.Open();

            SqlCommand command = new(
                $"DELETE FROM szemelyek WHERE id = {nudID.Value};",
                connection);

            SqlDataAdapter adapter = new() { DeleteCommand = command };
            adapter.DeleteCommand.ExecuteNonQuery();
            this.Dispose();
        }

        private void BtnMain_Click(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Program.connstr);
            connection.Open();

            if (nudID.Value == 0)
            {
                SqlCommand command = new(
                    $"INSERT INTO szemelyek VALUES " +
                    $"('{tbxNev.Text}'," +
                    $" '{dtpSzul.Value:yyyy-MM-dd}'," +
                    $" {(chbJogsi.Checked ? 1 : 0)}," +
                    $" {nudFizu.Value});",
                    connection);
                SqlDataAdapter adapter = new() { InsertCommand = command };
                if (Megerosites() == DialogResult.Yes)
                {
                    adapter.InsertCommand.ExecuteNonQuery();
                    this.Dispose();
                }
            }
            else
            {
                SqlCommand command = new(
                    $"UPDATE szemelyek SET " +
                    $"nev = '{tbxNev.Text}', " +
                    $"szul = '{dtpSzul.Value:yyyy-MM-dd}', " +
                    $"jogositvany = {(chbJogsi.Checked ? 1 : 0)}, " +
                    $"fizetes = {nudFizu.Value} " +
                    $"WHERE id = {nudID.Value};",
                    connection);
                SqlDataAdapter adapter = new() { UpdateCommand = command };
                if (Megerosites() == DialogResult.Yes)
                {
                    adapter.UpdateCommand.ExecuteNonQuery();
                    this.Dispose();
                }
            }
        }

        public DialogResult Megerosites()
        {
            return MessageBox.Show(
                caption: nudID.Value == 0 ? "ÚJ REKORD FELVÉTELE" : "REKORD MÓDOSÍTÁSA",
                text: nudID.Value == 0 
                    ? "Biztos hozzá szeretné adni az adatabázishoz?" 
                    : "Biztosan módosítani kívánja az adatokat?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);
        }
    }
}
