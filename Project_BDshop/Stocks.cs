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
using System.IO;


namespace Project_BDshop
{
    public partial class Stocks : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showstock()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stock";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock2.DataSource = ds.Tables[0].DefaultView;
        }
        public Stocks()
        {
            InitializeComponent();
            showstock();
        }
        private void Stocks_Load(object sender, EventArgs e)
        {
            showstock();
        }

        private void dataGridViewstock2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewstock2.CurrentRow.Selected = true;
                int selectedRows = dataGridViewstock2.CurrentCell.RowIndex;
                int editid = Convert.ToInt32(dataGridViewstock2.Rows[selectedRows].Cells["ID"].Value);
                textBoxSbrands.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Brands"].FormattedValue.ToString();
                textBoxSname.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Nameproduct"].FormattedValue.ToString();
                textBoxSprice.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                textBoxStype.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                textBoxSsize.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                textBoxSamount.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                textBoxSdetail.Text = dataGridViewstock2.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();

                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Image FROM stock WHERE ID =\"{ editid }\"", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pictureBoxSimage.Image = new Bitmap(ms);
                }
            }
            catch (Exception) { }
        }
        private void buttonSadd_Click(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            byte[] image = null;
            //pictureBox3.ImageLocation = textLocation.Text;
            string filepath = textBoxSlocation.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            string sql = $" INSERT INTO stock (Brands,Nameproduct,Price,Size,Type,Detail,Amount,Image) VALUES(\"{ textBoxSbrands.Text}\",\"{textBoxSname.Text}\",\"{ textBoxSprice.Text}\",\"{ textBoxSsize.Text}\",\"{ textBoxStype.Text}\",\"{ textBoxSdetail.Text}\",\"{ textBoxSamount.Text}\",@Imgg)";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
                int x = cmd.ExecuteNonQuery();
                conn.Close();
                showstock();
            }
            MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSbrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSimage.Image = new Bitmap(open.FileName);
                textBoxSlocation.Text = open.FileName;
            }
        }
        private void buttonSedit_Click(object sender, EventArgs e)
        {
            int selectedRows = dataGridViewstock2.CurrentCell.RowIndex;
            int editid = Convert.ToInt32(dataGridViewstock2.Rows[selectedRows].Cells["ID"].Value);
            MySqlConnection conn = databaseConnection();
            byte[] image = null;
            string filepath = textBoxSlocation.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            String sql = "UPDATE  stock SET Brands = '" + textBoxSbrands.Text + "',Nameproduct = '" + textBoxSname.Text + "',Price ='" + textBoxSprice.Text + "',Size= '" + textBoxSsize.Text + "',Type= '" + textBoxStype.Text + "',Detail= '" + textBoxSdetail.Text + "',Amount= '" + textBoxSamount.Text + "',Image= @imgg WHERE ID = '" + editid + "'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {

                MessageBox.Show("ข้อมูลแก้ไขสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showstock();
            }
        }
        private void buttonSdelete_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridViewstock2.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataGridViewstock2.Rows[selectedRow].Cells["id"].Value);
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            String sql = "DELETE FROM stock WHERE id = '" + deleteId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("ข้อมูลถูกลบสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                showstock();
            }
        }

        private void buttonSsearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM stock WHERE  Brands= \"{textBoxSsearch.Text}\" OR Nameproduct = \"{textBoxSsearch.Text}\" OR Price = \"{textBoxSsearch.Text}\" OR Size = \"{textBoxSsearch.Text}\"OR Type = \"{textBoxSsearch.Text}\" OR Amount = \"{textBoxSsearch.Text}\" OR ID = \"{textBoxSsearch.Text}\"" ;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock2.DataSource = ds.Tables[0].DefaultView;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("คุณต้องการออกจากระบบหรือไม่? ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login To = new Login();
                To.Show();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage To = new Homepage();
            To.Show();
        }
        private void button1_Click(object sender, EventArgs e) // ปุ่มรีเฟรช
        {
            showstock();
        }
        

    }
}
