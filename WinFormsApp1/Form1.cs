using Npgsql;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi-gifto";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dataGridView1.DataSource = null;
                sql = "select * from emp_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                txtNama.Text = r.Cells["_nama"].Value.ToString();
                txtDep.Text = r.Cells["id_dep"].Value.ToString();
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                sql = @"select * from emp_insert(:_nama, :id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", txtNama.Text);
                cmd.Parameters.AddWithValue("_id_dep", txtDep.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Insert Data Success", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                loadData();
                txtNama.Text = txtDep.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Fail " + ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih Baris Data", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }
            try
            {
                conn = new NpgsqlConnection();
            }
            catch (Exception ex)
            {

            }
                
        }
    }
}