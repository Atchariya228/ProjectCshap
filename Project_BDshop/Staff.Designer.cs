
namespace Project_BDshop
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.textBoxusn = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.textBoxtell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.textBoxcpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxusn
            // 
            this.textBoxusn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusn.Location = new System.Drawing.Point(495, 158);
            this.textBoxusn.Multiline = true;
            this.textBoxusn.Name = "textBoxusn";
            this.textBoxusn.Size = new System.Drawing.Size(314, 33);
            this.textBoxusn.TabIndex = 2;
            this.textBoxusn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxusn_KeyPress);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpass.Location = new System.Drawing.Point(495, 214);
            this.textBoxpass.Multiline = true;
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(314, 32);
            this.textBoxpass.TabIndex = 3;
            this.textBoxpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpass_KeyPress);
            // 
            // textBoxtell
            // 
            this.textBoxtell.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtell.Location = new System.Drawing.Point(495, 331);
            this.textBoxtell.MaxLength = 10;
            this.textBoxtell.Multiline = true;
            this.textBoxtell.Name = "textBoxtell";
            this.textBoxtell.Size = new System.Drawing.Size(314, 33);
            this.textBoxtell.TabIndex = 4;
            this.textBoxtell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtell_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phonenumber";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(318, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(521, 68);
            this.label11.TabIndex = 28;
            this.label11.Text = "++     Register    ++";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.mENUToolStripMenuItem.Text = "<< Back To Login";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // buttoncreate
            // 
            this.buttoncreate.BackColor = System.Drawing.Color.Tomato;
            this.buttoncreate.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncreate.Location = new System.Drawing.Point(528, 408);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(167, 42);
            this.buttoncreate.TabIndex = 30;
            this.buttoncreate.Text = "CREATE STAFF";
            this.buttoncreate.UseVisualStyleBackColor = false;
            this.buttoncreate.Click += new System.EventHandler(this.buttoncreate_Click);
            // 
            // textBoxcpass
            // 
            this.textBoxcpass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcpass.Location = new System.Drawing.Point(495, 272);
            this.textBoxcpass.Multiline = true;
            this.textBoxcpass.Name = "textBoxcpass";
            this.textBoxcpass.Size = new System.Drawing.Size(314, 32);
            this.textBoxcpass.TabIndex = 31;
            this.textBoxcpass.TextChanged += new System.EventHandler(this.textBoxcpass_TextChanged);
            this.textBoxcpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxcpass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "ConfirmPassword";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxcpass);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxtell);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxusn);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxusn;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.TextBox textBoxtell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.TextBox textBoxcpass;
        private System.Windows.Forms.Label label1;
    }
}