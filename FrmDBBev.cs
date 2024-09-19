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
            dgvSzemelyek.CellClick += DgvSzemelyek_CellClick;

            //TODO: módosítás, törlés
        }

        private void DgvSzemelyek_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            _ = new FrmReszletek(
                id: (int)dgvSzemelyek[0, e.RowIndex].Value,
                nev: $"{dgvSzemelyek[1, e.RowIndex].Value}",
                szul: DateTime.Parse($"{dgvSzemelyek[2, e.RowIndex].Value}"),
                jogsi: (bool)dgvSzemelyek[3, e.RowIndex].Value,
                fizetes: int.Parse(dgvSzemelyek[4, e.RowIndex].Value.ToString()!.Replace(" Ft", "").Replace(" ", ""))).ShowDialog();
            tbxKereso.Text = string.Empty;
            Query();
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
                    $"{reader["fizetes"]} Ft");
            }
        }

    }
}
