using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MappingWithWindowsForm.Data;

namespace MappingWithWindowsForm
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private Point newLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewFill();
        }

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

        private void btnNewLocation_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            counter++;
            btn.Text = String.Empty;
            btn.Name = "buttonName-" + Guid.NewGuid().ToString();
            btn.Size = new Size(45, 35);
            btn.Location = new Point(73, (26 + (counter * 30)));
            btn.BackColor = Color.White;
            btn.BackgroundImage = ((Image)Properties.Resources.location1);
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.TabIndex = 1;
            this.pictureBox1.Controls.Add(btn);
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
            btn.MouseDown += Btn_MouseDown;
            btn.MouseMove += Btn_MouseMove;
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            //MouseDown fareyle basıldığında MouseUp ise fareden çekildiğinde
            newLocation = e.Location;
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            //Farenin hareket etmesi
            Button clickedButton = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                clickedButton.Left += e.X - (newLocation.X); //X
                clickedButton.Top += e.Y - (newLocation.Y);  //Y
                txtLeftX.Text = clickedButton.Left.ToString();
                txtTopY.Text = clickedButton.Top.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtLocationName.Text))
                {
                    var newGuid = Guid.NewGuid();
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
                                Map map = new Map()
                                {
                                    ButtonName = name,
                                    MapName = String.IsNullOrEmpty(txtLocationName.Text) ? Guid.NewGuid().ToString() : txtLocationName.Text,
                                    X = left,
                                    Y = top,
                                    Guid = newGuid,
                                };
                                if (context.Maps.Any(j => j.ButtonName == map.ButtonName))
                                {
                                    var mapEntity = context.Maps.FirstOrDefault(j => j.ButtonName == map.ButtonName);
                                    mapEntity.X = map.X;
                                    mapEntity.Y = map.Y;
                                    mapEntity.ButtonName = map.ButtonName;
                                    mapEntity.MapName = map.MapName;
                                    mapEntity.Guid = map.Guid;
                                    context.SaveChanges();
                                }
                            }
                        }
                    }
                    DataGridViewFill();

                    MessageBox.Show("Ayarlar Kaydedildi!");
                }
                else
                {
                    MessageBox.Show("Konum adı alanı boş geçilmez!");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}