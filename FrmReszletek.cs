using Microsoft.Data.SqlClient;

namespace WFA240801
{
    public partial class FrmReszletek : Form
    {
        public FrmReszletek()
        {
            InitializeComponent();
            btnMain.Click += BtnMain_Click;
        }

        private void BtnMain_Click(object? sender, EventArgs e)
        {
            using SqlConnection connection = new(Program.connstr);
            connection.Open();

            SqlCommand command = new(
                $"INSERT INTO szemelyek VALUES " +
                $"('{tbxNev.Text}'," +
                $" '{dtpSzul.Value:yyyy-MM-dd}'," +
                $" {(chbJogsi.Checked ? 1 : 0)}," +
                $" {nudFizu.Value});",
                connection);

            SqlDataAdapter adapter = new() { InsertCommand = command };

            adapter.InsertCommand.ExecuteNonQuery();

            this.Dispose();
        }
    }
}
