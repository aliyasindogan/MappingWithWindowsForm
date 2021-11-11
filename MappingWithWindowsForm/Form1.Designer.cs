
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMoveX = new System.Windows.Forms.Label();
            this.lblMoveY = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDownX = new System.Windows.Forms.Label();
            this.lblDownY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtTopY = new System.Windows.Forms.TextBox();
            this.txtLeftX = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewLocationList = new System.Windows.Forms.DataGridView();
            this.groupBoxLocationList = new System.Windows.Forms.GroupBox();
            this.groupBoxLocation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(600, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Ayarları Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxLocation.Controls.Add(this.groupBox2);
            this.groupBoxLocation.Controls.Add(this.groupBox1);
            this.groupBoxLocation.Controls.Add(this.label3);
            this.groupBoxLocation.Controls.Add(this.label2);
            this.groupBoxLocation.Controls.Add(this.label1);
            this.groupBoxLocation.Controls.Add(this.txtLocationName);
            this.groupBoxLocation.Controls.Add(this.txtTopY);
            this.groupBoxLocation.Controls.Add(this.txtLeftX);
            this.groupBoxLocation.Controls.Add(this.btnNewLocation);
            this.groupBoxLocation.Controls.Add(this.btnClear);
            this.groupBoxLocation.Controls.Add(this.btnSave);
            this.groupBoxLocation.Location = new System.Drawing.Point(221, 1);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(873, 125);
            this.groupBoxLocation.TabIndex = 1;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Konum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblMoveX);
            this.groupBox2.Controls.Add(this.lblMoveY);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(250, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 44);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fare Hareket Halinde MOVE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Left X:";
            // 
            // lblMoveX
            // 
            this.lblMoveX.AutoSize = true;
            this.lblMoveX.Location = new System.Drawing.Point(50, 19);
            this.lblMoveX.Name = "lblMoveX";
            this.lblMoveX.Size = new System.Drawing.Size(14, 13);
            this.lblMoveX.TabIndex = 2;
            this.lblMoveX.Text = "X";
            // 
            // lblMoveY
            // 
            this.lblMoveY.AutoSize = true;
            this.lblMoveY.Location = new System.Drawing.Point(137, 19);
            this.lblMoveY.Name = "lblMoveY";
            this.lblMoveY.Size = new System.Drawing.Size(14, 13);
            this.lblMoveY.TabIndex = 2;
            this.lblMoveY.Text = "Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Top Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDownX);
            this.groupBox1.Controls.Add(this.lblDownY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fare Tıklanınca DOWN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Left X:";
            // 
            // lblDownX
            // 
            this.lblDownX.AutoSize = true;
            this.lblDownX.Location = new System.Drawing.Point(50, 19);
            this.lblDownX.Name = "lblDownX";
            this.lblDownX.Size = new System.Drawing.Size(14, 13);
            this.lblDownX.TabIndex = 2;
            this.lblDownX.Text = "X";
            // 
            // lblDownY
            // 
            this.lblDownY.AutoSize = true;
            this.lblDownY.Location = new System.Drawing.Point(137, 19);
            this.lblDownY.Name = "lblDownY";
            this.lblDownY.Size = new System.Drawing.Size(14, 13);
            this.lblDownY.TabIndex = 2;
            this.lblDownY.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Top Y:";
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(694, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Formu Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.pictureBox1);
            this.groupBoxMap.Location = new System.Drawing.Point(221, 132);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(873, 468);
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
            this.pictureBox1.Size = new System.Drawing.Size(867, 449);
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
            this.dataGridViewLocationList.Size = new System.Drawing.Size(201, 140);
            this.dataGridViewLocationList.TabIndex = 3;
            this.dataGridViewLocationList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLocationList_CellDoubleClick);
            // 
            // groupBoxLocationList
            // 
            this.groupBoxLocationList.Controls.Add(this.dataGridViewLocationList);
            this.groupBoxLocationList.Location = new System.Drawing.Point(8, 1);
            this.groupBoxLocationList.Name = "groupBoxLocationList";
            this.groupBoxLocationList.Size = new System.Drawing.Size(207, 159);
            this.groupBoxLocationList.TabIndex = 4;
            this.groupBoxLocationList.TabStop = false;
            this.groupBoxLocationList.Text = "Lokasyon Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 606);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDownY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDownX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMoveX;
        private System.Windows.Forms.Label lblMoveY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

