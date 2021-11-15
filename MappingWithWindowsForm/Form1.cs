using MappingWithWindowsForm.Data;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MappingWithWindowsForm
{
    public partial class Form1 : Form
    {
        #region Defines

        private int _counter = 0;
        private Point _mouseDownLocation;
        private string _selectedMapName = "";
        private string _imageUrl;

        #endregion Defines

        #region Form1

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DeleteEmptyRecords();
            DataGridViewFill();
            btnDelete.Enabled = false;
        }

        #endregion Form1

        #region CRUD

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPath.Text))
            {
                #region Create Button

                Button btn = new Button();
                _counter++;
                btn.Text = String.Empty;
                btn.Name = "buttonName-" + Guid.NewGuid().ToString();
                btn.Size = new Size(45, 35);
                btn.Location = new Point(73, (26 + (_counter * 30)));
                btn.BackColor = Color.White;
                btn.BackgroundImage = ((Image)Properties.Resources.location1);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.TabIndex = 1;
                this.pictureBox1.Controls.Add(btn);

                #endregion Create Button

                #region Save Button

                using (DatabaseContext context = new DatabaseContext())
                {
                    Map map = new Map()
                    {
                        ButtonName = btn.Name,
                        MapName = String.Empty,
                        X = null,
                        Y = null,
                    };
                    if (!context.Maps.Any(x => x.ButtonName == map.ButtonName))
                    {
                        context.Maps.Add(map);
                        context.SaveChanges();
                    }
                }

                #endregion Save Button

                btn.MouseDown += Btn_MouseDown;
                btn.MouseMove += Btn_MouseMove;
            }
            else
            {
                MessageBox.Show("Resim alanı boş geçilmez!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtLocationName.Text))
                {
                    if (!String.IsNullOrEmpty(txtPath.Text))
                    {
                        var newGuid = Guid.NewGuid();
                        if (this.pictureBox1.Controls.OfType<Button>().Count() > 0)
                        {
                            int newMaxDisplayOrder = 0;
                            foreach (Control x in this.pictureBox1.Controls.OfType<Button>())
                            {
                                if (x is Button)
                                {
                                    ((Button)x).Text = String.Empty;
                                    var name = ((Button)x).Name;
                                    var left = ((Button)x).Left;
                                    var top = ((Button)x).Top;
                                    using (DatabaseContext context = new DatabaseContext())
                                    {
                                        if (!context.Maps.Any(f => f.MapName == txtLocationName.Text))
                                        {
                                            var maxDisplayOrder = context.Maps.Max(m => m.DisplayOrder);
                                            if (maxDisplayOrder == 0)
                                            {
                                                newMaxDisplayOrder = 1;
                                            }
                                            else
                                            {
                                                newMaxDisplayOrder += maxDisplayOrder + 1;
                                            }
                                        }

                                        Map map = new Map()
                                        {
                                            ButtonName = name,
                                            MapName = String.IsNullOrEmpty(txtLocationName.Text) ? Guid.NewGuid().ToString() : txtLocationName.Text,
                                            X = left,
                                            Y = top,
                                            Guid = newGuid,
                                            DisplayOrder = newMaxDisplayOrder,
                                        };
                                        if (context.Maps.Any(j => j.ButtonName == map.ButtonName))
                                        {
                                            var mapEntity = context.Maps.FirstOrDefault(j => j.ButtonName == map.ButtonName);
                                            mapEntity.X = map.X;
                                            mapEntity.Y = map.Y;
                                            mapEntity.ButtonName = map.ButtonName;
                                            mapEntity.MapName = map.MapName;
                                            mapEntity.Guid = map.Guid;
                                            mapEntity.DisplayOrder = map.DisplayOrder;
                                            mapEntity.ImageUrl = _imageUrl;
                                            context.SaveChanges();
                                        }
                                    }
                                }
                            }
                            DataGridViewFill();
                            ClearControls();
                            this.pictureBox1.Controls.Clear();

                            MessageBox.Show("Ayarlar Kaydedildi!", "İŞLEM BAŞARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Yeni konum oluşturunuz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Resim alanı boş geçilmez!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Konum adı alanı boş geçilmez!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu!", "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLocationName.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Bu konumu silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    {
                        using (DatabaseContext context = new DatabaseContext())
                        {
                            var deleted = context.Maps.Where(x => x.MapName == _selectedMapName).ToList();
                            context.Maps.RemoveRange(deleted);
                            context.SaveChanges();
                            ClearControls();
                            DataGridViewFill();
                            this.pictureBox1.Controls.Clear();
                            MessageBox.Show(_selectedMapName + " silindi!", "İŞLEM BAŞARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnImagePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!String.IsNullOrEmpty(openFileDialog1.FileName))
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                txtPath.Text = openFileDialog1.FileName;
                string imageUploadPath = Application.StartupPath.Replace(@"bin\Debug", @"Images\");
                File.Copy(txtPath.Text, Path.Combine(imageUploadPath, Path.GetFileName(txtPath.Text)), true);
                _imageUrl = imageUploadPath + Path.GetFileName(txtPath.Text);
            }
        }

        #endregion CRUD

        #region Mouse Handler

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //MouseDown fareyle basıldığında MouseUp ise fareden çekildiğinde
                _mouseDownLocation = e.Location;
                lblDownX.Text = _mouseDownLocation.X.ToString();
                lblDownY.Text = _mouseDownLocation.Y.ToString();
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            //Farenin hareket etmesi
            Button clickedButton = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (clickedButton.Left > 5)
                {
                    if (clickedButton.Left < 820)
                    {
                        clickedButton.Left += e.X - _mouseDownLocation.X; //X
                        clickedButton.Top += e.Y - _mouseDownLocation.Y;  //Y
                        lblMoveX.Text = clickedButton.Left.ToString();
                        lblMoveY.Text = clickedButton.Top.ToString();
                    }
                    else
                    {
                        clickedButton.Left = 815;
                        clickedButton.Top = clickedButton.Top;
                    }
                }
                else
                {
                    clickedButton.Left = 10;
                    clickedButton.Top = clickedButton.Top;
                }
            }
        }

        #endregion Mouse Handler

        #region DataGridView

        private void dataGridViewLocationList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;

            _selectedMapName = dataGridViewLocationList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLocationName.Text = _selectedMapName;
            using (DatabaseContext context = new DatabaseContext())
            {
                this.pictureBox1.Controls.Clear();
                var maps = context.Maps.Where(x => x.MapName == _selectedMapName);
                var imgUrl = maps.Select(x => x.ImageUrl).Distinct().FirstOrDefault();
                pictureBox1.ImageLocation = imgUrl;
                txtPath.Text = imgUrl;
                foreach (var item in maps.ToList())
                {
                    Button btn = new Button();
                    _counter++;
                    btn.Text = String.Empty;
                    btn.Name = item.ButtonName;
                    btn.Size = new Size(45, 35);
                    btn.Location = new Point((int)item.X, ((int)item.Y));
                    btn.BackColor = Color.White;
                    btn.BackgroundImage = ((Image)Properties.Resources.location1);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.TabIndex = 1;
                    this.pictureBox1.Controls.Add(btn);
                    btn.MouseDown += Btn_MouseDown;
                    btn.MouseMove += Btn_MouseMove;
                }
            }
        }

        #endregion DataGridView

        #region Methods

        private void DataGridViewFill()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var data = (from map in context.Maps
                            select new
                            {
                                MapName = map.MapName
                            }).Distinct().ToList();
                dataGridViewLocationList.DataSource = data;
                dataGridViewLocationList.Columns["MapName"].HeaderText = "Konum Adı";
            }
        }

        private void ClearControls()
        {
            DeleteEmptyRecords();
            txtLocationName.Text = String.Empty;
            txtPath.Text = String.Empty;
            pictureBox1.ImageLocation = null;
        }

        private void DeleteEmptyRecords()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var maps = context.Maps.Where(x => x.MapName == String.Empty);
                context.Maps.RemoveRange(maps);
                context.SaveChanges();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
            DataGridViewFill();
            this.pictureBox1.Controls.Clear();
        }

        #endregion Methods
    }
}