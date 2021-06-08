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
    public partial class SoppingCart : Form
    {
        List<Printbill> allbill = new List<Printbill>();
        public string allprice;
        private MySqlConnection databaseConnection() 
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project;"; 
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showselect()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Brands,Nameproduct,Price,Amount,Size FROM saledata WHERE Status = '" + "NP" + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridViewShop.DataSource = ds.Tables[0].DefaultView;
        }
        
        public SoppingCart()
        {
            InitializeComponent();
        }
        private void SoppingCart_Load(object sender, EventArgs e)
        {
            showselect();
            textBoxTotal.Text = allprice;
            allbill.Clear();
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM saledata WHERE Username ='"+Program.Username+"' AND Status = '"+"NP"+"' ", conn);
            conn.Open();
            MySqlDataReader adapter = cmd1.ExecuteReader();
            while (adapter.Read())
            {
                Program.Brands = adapter.GetString("Brands").ToString();
                Program.Nameproduct = adapter.GetString("Nameproduct").ToString();
                Program.Price = adapter.GetString("Price").ToString();
                Program.Amount = adapter.GetString("Amount").ToString();
                Printbill item = new Printbill()
                {
                    Brands = Program.Brands,
                    Nameproduct = Program.Nameproduct,
                    Price = Program.Price,
                    Amount = Program.Amount,
                };
                allbill.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            int total = int.Parse(textBoxTotal.Text);
            int Get = int.Parse(textBoxGet.Text);
            if(Get < total)
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sums = (Get - total).ToString();
                textBoxtont.Text = sums;
                string connections = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conns = new MySqlConnection(connections);
                String sqls = "UPDATE saledata SET Status = '" + "YP" + "' WHERE Status = '" + "NP" + "' ";
                MySqlCommand cmds = new MySqlCommand(sqls, conns);
                conns.Open();
                int rowss = cmds.ExecuteNonQuery();
                conns.Close();
                if (rowss > 0)
                {
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ ขอบคุณที่ใช้บริการ","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    showselect();
                    
                }
            }
        }
     

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage To = new Homepage();
            To.Show();
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Datasale To = new Datasale();
            To.Show();
        }
        private void textBoxGet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบเสร็จ", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(370, 50));
            e.Graphics.DrawString("MERCEDES BADMINTON SPORT", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(130, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(550, 150));
            e.Graphics.DrawString("ข้อมูลร้าน : อัจฉริยะ เวียงแก้ว 0902469768", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
            e.Graphics.DrawString("              93 หมู่ 12 บ้านราษฎร์รังษี ตำบล ดูกอึ่ง ", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 195));
            e.Graphics.DrawString("               อำเภอ หนองฮี จังหวัด ร้อยเอ็ด 45140", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ     แบนด์        ชื่อสินค้า                                                                             จำนวน    ราคา (บาท)", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int y = 345;
            int number = 1;
            foreach (var i in allbill)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.Brands, new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new PointF(140, y));
                e.Graphics.DrawString("   " + i.Nameproduct, new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new PointF(220, y));
                e.Graphics.DrawString("   " + i.Amount, new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new PointF(630, y));
                e.Graphics.DrawString("   " + i.Price, new Font("supermarket", 10, FontStyle.Regular), Brushes.Black, new PointF(700, y));
                
                number = number + 1;
            }
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
            e.Graphics.DrawString("รวมทั้งสิ้น         " + textBoxTotal.Text + "  บาท", new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new Point(570, (y + 30) + 45));
            e.Graphics.DrawString("ชื่อผู้ให้บริการ        " + Program.Username.ToString(), new Font("supermarket", 14, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
            e.Graphics.DrawString("รับเงิน            " + textBoxGet.Text + "  บาท", new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new Point(570, ((y + 30) + 45) + 45));
            e.Graphics.DrawString("เงินทอน           " + textBoxtont.Text + "  บาท", new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new Point(570, (((y + 30) + 45) + 45) + 45));
        } // พิมพ์ใบเสร็จ
    }
}
