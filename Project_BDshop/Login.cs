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
    public partial class Login : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project;"; //เชื่อม database
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbuttom_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM login WHERE Username ='" + userbox.Text + "'AND Password ='" + passbox.Text + "'"; //เลือกข้อมูลจาก DB login

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.Read())
            {
                Program.Username = userbox.Text;
                MessageBox.Show("เข้าสู่ระบบสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Homepage to = new Homepage();
                to.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งาน หรือ รหัสผ่านไม่ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // ปุ่ม Show/Hide password
        {
            if (checkBox1.Checked)
            {
                string P = passbox.Text;
                passbox.PasswordChar = '\0';
            }
            else
            {
                passbox.PasswordChar = '•';
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            result = MessageBox.Show("คุณต้องการปิดโปรแกรมหรือไม่? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Facebook : Atchariya Wiangkaew \n\nLine : Atchariya_228\n\nEmail : atchariya.wi@kkumail.com\n\nTel. : 0902469768", "Contact");
        } //contact

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Staff to = new Staff();
            to.Show();
        } 
    }
}

 
