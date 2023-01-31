namespace RecordDealer.UI
{
    partial class Form2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOnSaleAlbums = new System.Windows.Forms.Button();
            this.btnLastTenAlbums = new System.Windows.Forms.Button();
            this.btnContiniuedAlbums = new System.Windows.Forms.Button();
            this.btnDiscontinuedAlbums = new System.Windows.Forms.Button();
            this.btnShowAllAlbums = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateAlbum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.cmbDiscounted = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.dgvAlbums = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOnSaleAlbums);
            this.groupBox2.Controls.Add(this.btnLastTenAlbums);
            this.groupBox2.Controls.Add(this.btnContiniuedAlbums);
            this.groupBox2.Controls.Add(this.btnDiscontinuedAlbums);
            this.groupBox2.Controls.Add(this.btnShowAllAlbums);
            this.groupBox2.Location = new System.Drawing.Point(624, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 235);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Album Panel";
            // 
            // btnOnSaleAlbums
            // 
            this.btnOnSaleAlbums.Location = new System.Drawing.Point(6, 186);
            this.btnOnSaleAlbums.Name = "btnOnSaleAlbums";
            this.btnOnSaleAlbums.Size = new System.Drawing.Size(210, 30);
            this.btnOnSaleAlbums.TabIndex = 10;
            this.btnOnSaleAlbums.Text = "Albums On Sale";
            this.btnOnSaleAlbums.UseVisualStyleBackColor = true;
            this.btnOnSaleAlbums.Click += new System.EventHandler(this.btnOnSaleAlbums_Click);
            // 
            // btnLastTenAlbums
            // 
            this.btnLastTenAlbums.Location = new System.Drawing.Point(6, 145);
            this.btnLastTenAlbums.Name = "btnLastTenAlbums";
            this.btnLastTenAlbums.Size = new System.Drawing.Size(210, 30);
            this.btnLastTenAlbums.TabIndex = 10;
            this.btnLastTenAlbums.Text = "Last Added 10 Albums";
            this.btnLastTenAlbums.UseVisualStyleBackColor = true;
            this.btnLastTenAlbums.Click += new System.EventHandler(this.btnLastTenAlbums_Click);
            // 
            // btnContiniuedAlbums
            // 
            this.btnContiniuedAlbums.Location = new System.Drawing.Point(6, 104);
            this.btnContiniuedAlbums.Name = "btnContiniuedAlbums";
            this.btnContiniuedAlbums.Size = new System.Drawing.Size(210, 30);
            this.btnContiniuedAlbums.TabIndex = 10;
            this.btnContiniuedAlbums.Text = "Continued Albums";
            this.btnContiniuedAlbums.UseVisualStyleBackColor = true;
            this.btnContiniuedAlbums.Click += new System.EventHandler(this.btnContiniuedAlbums_Click);
            // 
            // btnDiscontinuedAlbums
            // 
            this.btnDiscontinuedAlbums.Location = new System.Drawing.Point(6, 63);
            this.btnDiscontinuedAlbums.Name = "btnDiscontinuedAlbums";
            this.btnDiscontinuedAlbums.Size = new System.Drawing.Size(210, 30);
            this.btnDiscontinuedAlbums.TabIndex = 10;
            this.btnDiscontinuedAlbums.Text = "Discontinued Albums";
            this.btnDiscontinuedAlbums.UseVisualStyleBackColor = true;
            this.btnDiscontinuedAlbums.Click += new System.EventHandler(this.btnDiscontinuedAlbums_Click);
            // 
            // btnShowAllAlbums
            // 
            this.btnShowAllAlbums.Location = new System.Drawing.Point(6, 22);
            this.btnShowAllAlbums.Name = "btnShowAllAlbums";
            this.btnShowAllAlbums.Size = new System.Drawing.Size(210, 30);
            this.btnShowAllAlbums.TabIndex = 10;
            this.btnShowAllAlbums.Text = "Show All Albums";
            this.btnShowAllAlbums.UseVisualStyleBackColor = true;
            this.btnShowAllAlbums.Click += new System.EventHandler(this.btnShowAllAlbums_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDeleteAlbum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnUpdateAlbum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtArtistName);
            this.groupBox1.Controls.Add(this.txtAlbumName);
            this.groupBox1.Controls.Add(this.cmbDiscounted);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudDiscount);
            this.groupBox1.Controls.Add(this.nudPrice);
            this.groupBox1.Controls.Add(this.dtpReleaseDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 235);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Album Control Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Album Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Date :";
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Location = new System.Drawing.Point(400, 168);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteAlbum.TabIndex = 7;
            this.btnDeleteAlbum.Text = "Delete";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price :";
            // 
            // btnUpdateAlbum
            // 
            this.btnUpdateAlbum.Location = new System.Drawing.Point(400, 92);
            this.btnUpdateAlbum.Name = "btnUpdateAlbum";
            this.btnUpdateAlbum.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateAlbum.TabIndex = 7;
            this.btnUpdateAlbum.Text = "Update";
            this.btnUpdateAlbum.UseVisualStyleBackColor = true;
            this.btnUpdateAlbum.Click += new System.EventHandler(this.btnUpdateAlbum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Discount Rate(0-100) :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(400, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(208, 48);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(174, 26);
            this.txtArtistName.TabIndex = 2;
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(209, 16);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(174, 26);
            this.txtAlbumName.TabIndex = 2;
            // 
            // cmbDiscounted
            // 
            this.cmbDiscounted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscounted.FormattingEnabled = true;
            this.cmbDiscounted.Location = new System.Drawing.Point(209, 193);
            this.cmbDiscounted.Name = "cmbDiscounted";
            this.cmbDiscounted.Size = new System.Drawing.Size(174, 28);
            this.cmbDiscounted.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Discontinued :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Artist :";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(209, 155);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(173, 26);
            this.nudDiscount.TabIndex = 4;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(210, 123);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(173, 26);
            this.nudPrice.TabIndex = 4;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.CustomFormat = "";
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(209, 88);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(174, 26);
            this.dtpReleaseDate.TabIndex = 3;
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(8, 250);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(93, 20);
            this.lblAlbums.TabIndex = 13;
            this.lblAlbums.Text = "All Albums";
            // 
            // dgvAlbums
            // 
            this.dgvAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbums.Location = new System.Drawing.Point(12, 273);
            this.dgvAlbums.Name = "dgvAlbums";
            this.dgvAlbums.Size = new System.Drawing.Size(837, 258);
            this.dgvAlbums.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAlbums);
            this.Controls.Add(this.dgvAlbums);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Album Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOnSaleAlbums;
        private System.Windows.Forms.Button btnLastTenAlbums;
        private System.Windows.Forms.Button btnContiniuedAlbums;
        private System.Windows.Forms.Button btnDiscontinuedAlbums;
        private System.Windows.Forms.Button btnShowAllAlbums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdateAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.ComboBox cmbDiscounted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.DataGridView dgvAlbums;
    }
}