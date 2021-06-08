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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login to = new Login();
            to.Show();
        }

        private void buttoncreate_Click(object sender, EventArgs e) // สร้างแอค
        {
            if (textBoxusn.Text == "" || textBoxpass.Text == "" || textBoxtell.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxtell.TextLength < 10)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkUser())
            {
                MessageBox.Show("บัญชีผู้ใช้มีอยู่แล้ว", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxpass.Text != textBoxcpass.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                String sql = $" INSERT INTO login (Username,Password,Phonenumber) VALUES(\"{ textBoxusn.Text}\",\"{ textBoxpass.Text}\",\"{ textBoxtell.Text}\")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("สมัครสมาชิกสำเร็จ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login a = new Login();
                    this.Hide();
                    a.Show();
                }
            }
        }
        public Boolean checkUser()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            string username = textBoxusn.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM login WHERE Username = @user", conn);

            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBoxusn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        private void textBoxpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        private void textBoxcpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }
        private void textBoxtell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBoxcpass_TextChanged(object sender, EventArgs e)
        {
            textBoxcpass.PasswordChar = '•';
        }
    }
}
