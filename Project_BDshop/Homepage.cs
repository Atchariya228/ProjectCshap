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
    public partial class Homepage : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project;"; 
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showstock() // DB stock  
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
            dataGridViewstock.DataSource = ds.Tables[0].DefaultView;
        }
        private void showselect() // เรียกข้อมูลจาก DB stock มาโชว์ใน กริดวิว2(กริดวิวเลือกสินค้า) 
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID,Brands,Nameproduct,Price,Amount,Size FROM saledata WHERE Status = '" + "NP"+"'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewSelect.DataSource = ds.Tables[0].DefaultView;
        }
        private void showMoney() // แสดงราคาทั้งหมดที่เลือกมาจาก stock แล้วอยู่ใน GVselect แสดง ยอดรวม 
        {
            textBoxMoney.Text = "0";
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT SUM(Price) FROM saledata WHERE Status = '" + "NP" + "'";
            Object sum = cmd.ExecuteScalar();
            conn.Close();
            if (Convert.ToString(sum) != "")
            {
                textBoxMoney.Text = Convert.ToString(sum);
            }
        }
        public Homepage()
        {
            InitializeComponent();
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            showstock();
            showselect();
            showMoney();
            if (Program.Username == "admin")
            {
                sTOCKToolStripMenuItem.Visible = true;
                sALDDATAToolStripMenuItem.Visible = true;
            }
            else 
            {
                sTOCKToolStripMenuItem.Visible = false;
                sALDDATAToolStripMenuItem.Visible = false;
            }
            
        }
        
        private void dataGridViewstock_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                dataGridViewstock.CurrentRow.Selected = true;
                int selectedRows = dataGridViewstock.CurrentCell.RowIndex;
                int showpic = Convert.ToInt32(dataGridViewstock.Rows[selectedRows].Cells["ID"].Value);
                textBoxID.Text = dataGridViewstock.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                textBoxbrand.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Brands"].FormattedValue.ToString();
                textBoxname.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Nameproduct"].FormattedValue.ToString();
                textBoxprice.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                textBoxsize.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                textBoxdetail.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Detail"].FormattedValue.ToString();
                amu.Text = dataGridViewstock.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                numericUpDownAmount.Maximum = int.Parse(amu.Text);
                if (amu.Text == "0")
                {
                    Seletebtn.Visible = false;
                }
                else
                {
                    Seletebtn.Visible = true;
                }
                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT Image FROM stock WHERE ID =\"{ showpic }\"", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                    pictureBoxstock.Image = new Bitmap(ms);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากดให้ถูกที่");
            }
            

        }
        
        
        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showstock();
        }

        private void racketไมแบดมนตนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "Racket";
            cmd.CommandText = $"SELECT * FROM stock WHERE type=\"{name}\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock.DataSource = ds.Tables[0].DefaultView;
        }

        private void shoesรองเทาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "Shoes";
            cmd.CommandText = $"SELECT * FROM stock WHERE type=\"{name}\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock.DataSource = ds.Tables[0].DefaultView;
        }

        private void bAGSกระเปาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "Bags";
            cmd.CommandText = $"SELECT * FROM stock WHERE type=\"{name}\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock.DataSource = ds.Tables[0].DefaultView;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            string name = "Accessories";
            cmd.CommandText = $"SELECT * FROM stock WHERE type=\"{name}\"";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewstock.DataSource = ds.Tables[0].DefaultView;
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stocks To = new Stocks();
            To.Show();
        }

        private void sALDDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datasale To = new Datasale();
            To.Show();
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

        private void cONTACTToolStripMenuItem_Click(object sender, EventArgs e) // Contact
        {
            MessageBox.Show("Facebook : Atchariya Wiangkaew \n\nLine : Atchariya_228\n\nEmail : atchariya.wi@kkumail.com\n\nTel. : 0902469768", "Contact");
        }
        private void button1_Click(object sender, EventArgs e) //รีเฟรช
        {
            showstock();
        } 

        
        string amountstock;
        string amountstock1;
        string amountstock2;
        private void selectamountst1() // name and size
        {
            String name1 = textBoxname.Text; 
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string sql = $"SELECT Amount FROM stock WHERE Nameproduct =\"{ name1}\" AND Size ='" + textBoxsize.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                amountstock = dr.GetValue(0).ToString();
            }
        }
        private void selectamountst2() // name
        {
            String name1 = label5.Text;
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string sql = $"SELECT Amount FROM saledata WHERE Nameproduct =\"{ name1}\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                amountstock1 = dr.GetValue(0).ToString();
            }
        }
        private void selectamountst3()
        {
            String name1 = label5.Text;
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string sql = $"SELECT Amount FROM stock WHERE Nameproduct =\"{ name1}\"AND Size =\"{labelSize.Text}\"";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                amountstock2 = dr.GetValue(0).ToString();
            }
        }

        private void dataGridViewSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewSelect.CurrentRow.Selected = true;
                label4.Text = dataGridViewSelect.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                label5.Text = dataGridViewSelect.Rows[e.RowIndex].Cells["Nameproduct"].FormattedValue.ToString();
                labelamounts.Text = dataGridViewSelect.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                labelSize.Text = dataGridViewSelect.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
            }
            catch (Exception) { }
            
        }

        private void Seletebtn_Click(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.Open();
            string pri = (int.Parse(textBoxprice.Text) * int.Parse(numericUpDownAmount.Text)).ToString();
            string time = dateTimePicker1.Value.ToString();
            String sql = $"INSERT INTO saledata (Brands,Nameproduct,Price,Amount,Size,Status,DateTime,Username) VALUES(\"{textBoxbrand.Text}\",\"{ textBoxname.Text}\",\"{ pri }\",\"{ numericUpDownAmount.Text}\",\"{ textBoxsize.Text}\",\"{"NP"}\",\"{ time}\",\"{Program.Username}\")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    showselect();
                    selectamountst1();
                   
                    string am = (int.Parse(amountstock) - int.Parse(numericUpDownAmount.Text)).ToString(); // ตัดสต็อก 
                    string connections = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                    MySqlConnection conns = new MySqlConnection(connections);
                    String sqls = "UPDATE stock SET Amount ='" + am + "' WHERE Nameproduct ='" + textBoxname.Text + "' AND Size ='" + textBoxsize.Text + "'  ";
                    MySqlCommand cmds = new MySqlCommand(sqls, conns);
                    conns.Open();
                    int rowss = cmds.ExecuteNonQuery();
                    if (rowss > 0)
                    {
                        showstock();
                        showMoney();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deletebtn_Click(object sender, EventArgs e) //ปุ่มลบรายการ
        {
            selectamountst2();
            selectamountst3();
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connection);
            String sql = "DELETE FROM saledata WHERE ID = '" + label4.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                showselect();
                showMoney();
                string am1 = (int.Parse(amountstock2) + int.Parse(labelamounts.Text)).ToString();
                string connections = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conns = new MySqlConnection(connections);
                String sqls = "UPDATE stock SET Amount ='" + am1 + "' WHERE Nameproduct ='" + label5.Text + "' AND Size ='" + labelSize.Text + "' ";
                MySqlCommand cmds = new MySqlCommand(sqls, conns);
                conns.Open();
                int rowss = cmds.ExecuteNonQuery();
                if (rowss > 0)
                {
                    showstock();
                    showMoney();
                }
            }

        }

        private void Confirm_Click(object sender, EventArgs e) // คิดเงิน
        {
            this.Hide();
            SoppingCart n = new SoppingCart();
            n.allprice = textBoxMoney.Text;
            n.Show();
        }
    }
    
}
