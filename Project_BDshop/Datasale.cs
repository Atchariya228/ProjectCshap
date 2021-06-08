using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project_BDshop
{
    public partial class Datasale : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showsaledatatrueadmin()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DateTime,Username,Brands,Nameproduct,Price,Amount,Size FROM saledata WHERE Status = '" + "YP" + "' ";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewSaledata.DataSource = ds.Tables[0].DefaultView;
        }
        private void showsaledatatrue()    
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT DateTime,Username,Brands,Nameproduct,Price,Amount,Size FROM saledata WHERE Status = '" + "YP" + "' AND Username = '"+Program.Username+"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewSaledata.DataSource = ds.Tables[0].DefaultView;
        }
        public Datasale()
        {
            InitializeComponent();
        }
        private void Datasale_Load(object sender, EventArgs e)
        {
            if (Program.Username == "admin")
            {
                showsaledatatrueadmin();
            }
            else
            {
                showsaledatatrue();
            }
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage to = new Homepage();
            to.Show();
        }
        private void dataGridViewSaledata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewSaledata.CurrentRow.Selected = true;
            }
            catch (Exception) { }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            showsaledatatrue();
        }
    }
}
