
namespace Project_BDshop
{
    partial class ShoppingCart
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxchange = new System.Windows.Forms.TextBox();
            this.textBoxGetmoney = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "รายการ";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Yellow;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonSave.Location = new System.Drawing.Point(377, 538);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(222, 51);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "คิดเงิน";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxchange
            // 
            this.textBoxchange.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxchange.Location = new System.Drawing.Point(462, 446);
            this.textBoxchange.Multiline = true;
            this.textBoxchange.Name = "textBoxchange";
            this.textBoxchange.ReadOnly = true;
            this.textBoxchange.Size = new System.Drawing.Size(385, 33);
            this.textBoxchange.TabIndex = 48;
            this.textBoxchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxGetmoney
            // 
            this.textBoxGetmoney.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGetmoney.Location = new System.Drawing.Point(462, 395);
            this.textBoxGetmoney.Multiline = true;
            this.textBoxGetmoney.Name = "textBoxGetmoney";
            this.textBoxGetmoney.Size = new System.Drawing.Size(385, 33);
            this.textBoxGetmoney.TabIndex = 47;
            this.textBoxGetmoney.Text = "0";
            this.textBoxGetmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(462, 345);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(385, 33);
            this.textBoxTotal.TabIndex = 46;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(374, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "เงินทอน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(372, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "รับเงิน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(372, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "ยอดรวม";
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelect.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSelect.Location = new System.Drawing.Point(364, 98);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(517, 210);
            this.dataGridViewSelect.TabIndex = 42;
            this.dataGridViewSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelect_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(659, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 51);
            this.button1.TabIndex = 52;
            this.button1.Text = "คิดเงิน";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(377, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 51);
            this.button2.TabIndex = 53;
            this.button2.Text = "คิดเงิน";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 797);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxchange);
            this.Controls.Add(this.textBoxGetmoney);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewSelect);
            this.Name = "ShoppingCart";
            this.Text = "ShoppingCart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxchange;
        private System.Windows.Forms.TextBox textBoxGetmoney;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}