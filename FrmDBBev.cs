using Microsoft.Data.SqlClient;

namespace WFA240801
{
    public partial class FrmDBBev : Form
    {
        public FrmDBBev()
        {
            InitializeComponent();
            this.Load += Query;
            tbxKereso.TextChanged += Query;
            btnUjRekord.Click += BtnUjRekord_Click;

            //TODO: módosítás, törlés
        }

        private void BtnUjRekord_Click(object? sender, EventArgs e)
        {
            _ = new FrmReszletek().ShowDialog();
            tbxKereso.Text = string.Empty;
            Query();
        }

        private void Query(object? sender = null, EventArgs e = null!)
        {
            dgvSzemelyek.Rows.Clear();

            using SqlConnection connection = new(Program.connstr);
            connection.Open();
            SqlCommand query = new(
                $"SELECT * FROM szemelyek " +
                $"WHERE nev LIKE '%{tbxKereso.Text}%';",
                connection);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                dgvSzemelyek.Rows.Add(
                    reader["id"],
                    reader["nev"],
                    ((DateTime)reader["szul"]).ToString("yyyy-MM-dd"),
                    reader["jogositvany"],
                    $"{reader["fizetes"]:N0} Ft");
            }
        }

    }
}
