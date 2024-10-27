namespace ASM1DATAE_BH01350
{
    partial class FormCustomer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvform4 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtotal4 = new System.Windows.Forms.Label();
            this.lbname4 = new System.Windows.Forms.Label();
            this.lbphone4 = new System.Windows.Forms.Label();
            this.tbtotal4 = new System.Windows.Forms.TextBox();
            this.tbname4 = new System.Windows.Forms.TextBox();
            this.tbphone4 = new System.Windows.Forms.TextBox();
            this.btadd4 = new System.Windows.Forms.Button();
            this.btedit4 = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btout4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvform4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvform4
            // 
            this.dgvform4.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvform4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvform4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Phone,
            this.Purchases,
            this.Total,
            this.Score});
            this.dgvform4.Location = new System.Drawing.Point(-1, 213);
            this.dgvform4.Name = "dgvform4";
            this.dgvform4.RowHeadersWidth = 51;
            this.dgvform4.RowTemplate.Height = 24;
            this.dgvform4.Size = new System.Drawing.Size(802, 237);
            this.dgvform4.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 160;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 160;
            // 
            // Purchases
            // 
            this.Purchases.HeaderText = "Purchases";
            this.Purchases.MinimumWidth = 6;
            this.Purchases.Name = "Purchases";
            this.Purchases.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.Width = 140;
            // 
            // lbtotal4
            // 
            this.lbtotal4.AutoSize = true;
            this.lbtotal4.BackColor = System.Drawing.Color.MistyRose;
            this.lbtotal4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal4.ForeColor = System.Drawing.Color.IndianRed;
            this.lbtotal4.Location = new System.Drawing.Point(73, 65);
            this.lbtotal4.Name = "lbtotal4";
            this.lbtotal4.Size = new System.Drawing.Size(57, 22);
            this.lbtotal4.TabIndex = 2;
            this.lbtotal4.Text = "Total";
            // 
            // lbname4
            // 
            this.lbname4.AutoSize = true;
            this.lbname4.BackColor = System.Drawing.Color.MistyRose;
            this.lbname4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname4.ForeColor = System.Drawing.Color.IndianRed;
            this.lbname4.Location = new System.Drawing.Point(73, 109);
            this.lbname4.Name = "lbname4";
            this.lbname4.Size = new System.Drawing.Size(60, 22);
            this.lbname4.TabIndex = 3;
            this.lbname4.Text = "Name";
            // 
            // lbphone4
            // 
            this.lbphone4.AutoSize = true;
            this.lbphone4.BackColor = System.Drawing.Color.MistyRose;
            this.lbphone4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphone4.ForeColor = System.Drawing.Color.IndianRed;
            this.lbphone4.Location = new System.Drawing.Point(73, 153);
            this.lbphone4.Name = "lbphone4";
            this.lbphone4.Size = new System.Drawing.Size(67, 22);
            this.lbphone4.TabIndex = 5;
            this.lbphone4.Text = "Phone";
            // 
            // tbtotal4
            // 
            this.tbtotal4.Location = new System.Drawing.Point(161, 65);
            this.tbtotal4.Name = "tbtotal4";
            this.tbtotal4.Size = new System.Drawing.Size(175, 22);
            this.tbtotal4.TabIndex = 6;
            this.tbtotal4.TextChanged += new System.EventHandler(this.tbtotal4_TextChanged);
            // 
            // tbname4
            // 
            this.tbname4.Location = new System.Drawing.Point(161, 109);
            this.tbname4.Name = "tbname4";
            this.tbname4.Size = new System.Drawing.Size(175, 22);
            this.tbname4.TabIndex = 7;
            this.tbname4.TextChanged += new System.EventHandler(this.tbname4_TextChanged);
            // 
            // tbphone4
            // 
            this.tbphone4.Location = new System.Drawing.Point(161, 153);
            this.tbphone4.Name = "tbphone4";
            this.tbphone4.Size = new System.Drawing.Size(175, 22);
            this.tbphone4.TabIndex = 8;
            // 
            // btadd4
            // 
            this.btadd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btadd4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd4.Location = new System.Drawing.Point(397, 109);
            this.btadd4.Name = "btadd4";
            this.btadd4.Size = new System.Drawing.Size(72, 31);
            this.btadd4.TabIndex = 9;
            this.btadd4.Text = "Add";
            this.btadd4.UseVisualStyleBackColor = false;
            this.btadd4.Click += new System.EventHandler(this.btadd4_Click);
            // 
            // btedit4
            // 
            this.btedit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btedit4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit4.Location = new System.Drawing.Point(495, 109);
            this.btedit4.Name = "btedit4";
            this.btedit4.Size = new System.Drawing.Size(72, 31);
            this.btedit4.TabIndex = 10;
            this.btedit4.Text = "Edit";
            this.btedit4.UseVisualStyleBackColor = false;
            this.btedit4.Click += new System.EventHandler(this.btedit4_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btclear.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(592, 109);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(72, 31);
            this.btclear.TabIndex = 11;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btout4
            // 
            this.btout4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btout4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btout4.Location = new System.Drawing.Point(688, 109);
            this.btout4.Name = "btout4";
            this.btout4.Size = new System.Drawing.Size(72, 31);
            this.btout4.TabIndex = 12;
            this.btout4.Text = "Out";
            this.btout4.UseVisualStyleBackColor = false;
            this.btout4.Click += new System.EventHandler(this.btout4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customer";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASM1DATAE_BH01350.Properties.Resources.c46c1e631f01c034f61a65ad58e25f0d;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btout4);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btedit4);
            this.Controls.Add(this.btadd4);
            this.Controls.Add(this.tbphone4);
            this.Controls.Add(this.tbname4);
            this.Controls.Add(this.tbtotal4);
            this.Controls.Add(this.lbphone4);
            this.Controls.Add(this.lbname4);
            this.Controls.Add(this.lbtotal4);
            this.Controls.Add(this.dgvform4);
            this.Controls.Add(this.pictureBox1);
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvform4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvform4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Label lbtotal4;
        private System.Windows.Forms.Label lbname4;
        private System.Windows.Forms.Label lbphone4;
        private System.Windows.Forms.TextBox tbtotal4;
        private System.Windows.Forms.TextBox tbname4;
        private System.Windows.Forms.TextBox tbphone4;
        private System.Windows.Forms.Button btadd4;
        private System.Windows.Forms.Button btedit4;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btout4;
        private System.Windows.Forms.Label label1;
    }
}