
namespace MappingWithWindowsForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewLocation = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtTopY = new System.Windows.Forms.TextBox();
            this.txtLeftX = new System.Windows.Forms.TextBox();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewLocationList = new System.Windows.Forms.DataGridView();
            this.groupBoxLocationList = new System.Windows.Forms.GroupBox();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationList)).BeginInit();
            this.groupBoxLocationList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewLocation
            // 
            this.btnNewLocation.Location = new System.Drawing.Point(18, 21);
            this.btnNewLocation.Name = "btnNewLocation";
            this.btnNewLocation.Size = new System.Drawing.Size(124, 23);
            this.btnNewLocation.TabIndex = 0;
            this.btnNewLocation.Text = "Yeni Konum Oluştur";
            this.btnNewLocation.UseVisualStyleBackColor = true;
            this.btnNewLocation.Click += new System.EventHandler(this.btnNewLocation_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Ayarları Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLocation.Controls.Add(this.label3);
            this.groupBoxLocation.Controls.Add(this.label2);
            this.groupBoxLocation.Controls.Add(this.label1);
            this.groupBoxLocation.Controls.Add(this.txtLocationName);
            this.groupBoxLocation.Controls.Add(this.txtTopY);
            this.groupBoxLocation.Controls.Add(this.txtLeftX);
            this.groupBoxLocation.Controls.Add(this.btnNewLocation);
            this.groupBoxLocation.Controls.Add(this.btnSave);
            this.groupBoxLocation.Location = new System.Drawing.Point(5, 1);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(790, 62);
            this.groupBoxLocation.TabIndex = 1;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Konum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Konum Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Top Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left X:";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(456, 22);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(138, 20);
            this.txtLocationName.TabIndex = 1;
            // 
            // txtTopY
            // 
            this.txtTopY.Location = new System.Drawing.Point(316, 22);
            this.txtTopY.Name = "txtTopY";
            this.txtTopY.Size = new System.Drawing.Size(64, 20);
            this.txtTopY.TabIndex = 1;
            // 
            // txtLeftX
            // 
            this.txtLeftX.Location = new System.Drawing.Point(196, 22);
            this.txtLeftX.Name = "txtLeftX";
            this.txtLeftX.Size = new System.Drawing.Size(64, 20);
            this.txtLeftX.TabIndex = 1;
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.pictureBox1);
            this.groupBoxMap.Location = new System.Drawing.Point(5, 70);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(790, 378);
            this.groupBoxMap.TabIndex = 2;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Harita";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewLocationList
            // 
            this.dataGridViewLocationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLocationList.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLocationList.Name = "dataGridViewLocationList";
            this.dataGridViewLocationList.Size = new System.Drawing.Size(778, 130);
            this.dataGridViewLocationList.TabIndex = 3;
            this.dataGridViewLocationList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocationList_CellDoubleClick);
            // 
            // groupBoxLocationList
            // 
            this.groupBoxLocationList.Controls.Add(this.dataGridViewLocationList);
            this.groupBoxLocationList.Location = new System.Drawing.Point(8, 454);
            this.groupBoxLocationList.Name = "groupBoxLocationList";
            this.groupBoxLocationList.Size = new System.Drawing.Size(784, 149);
            this.groupBoxLocationList.TabIndex = 4;
            this.groupBoxLocationList.TabStop = false;
            this.groupBoxLocationList.Text = "Lokasyon Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.groupBoxLocationList);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Form İle Haritalama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.groupBoxMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocationList)).EndInit();
            this.groupBoxLocationList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtTopY;
        private System.Windows.Forms.TextBox txtLeftX;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewLocationList;
        private System.Windows.Forms.GroupBox groupBoxLocationList;
    }
}

