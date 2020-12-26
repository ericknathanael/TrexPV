using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekTrex
{
    public partial class Form1 : Form
    {
        
        Label judul = new Label();
        List<Button> buttonbuy = new List<Button>();
        List<Button> buttonequip = new List<Button>();
        Button buy1 = new Button();
        Button buy2 = new Button();
        Button buy3 = new Button();
        Button equip1 = new Button();
        Button equip2 = new Button();
        Button equip3 = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equip1.Text = "Equip";
            equip1.Click += equipclick;
            equip1.Location = new Point(350, 100);
            equip1.Visible = false;
            this.Controls.Add(equip1);

            equip2.Text = "Equip";
            equip2.Click += equipclick2;
            equip2.Location = new Point(350, 175);
            equip2.Visible = false;
            this.Controls.Add(equip2);

            equip3.Text = "Equip";
            equip3.Click += equipclick3;
            equip3.Location = new Point(350, 255);
            equip3.Visible = false;
            this.Controls.Add(equip3);
            for (int i = 0; i <= 2; i++)
            {
                if(i == 0)
                {
                    buy1.Text = "BUY";
                    buy1.Click += buyclick;
                    buy1.Location = new Point(350, 100);
                    buttonbuy.Add(buy1);
                    this.Controls.Add(buy1);
                }
                else if(i == 1)
                {
                    buy2.Text = "BUY";
                    buy2.Click += buyclick2;
                    buy2.Location = new Point(350, 175);
                    buttonbuy.Add(buy2);
                    this.Controls.Add(buy2);
                }
                else if(i == 2)
                {
                    buy3.Text = "BUY";
                    buy3.Click += buyclick3;
                    buy3.Location = new Point(350, 255);
                    buttonbuy.Add(buy3);
                    this.Controls.Add(buy3);
                }
            }

            this.Controls.Add(judul);
            pictureBox1.SendToBack();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            judul.Text = "SHOP";
            judul.BackColor = System.Drawing.Color.Transparent;
            judul.TextAlign = ContentAlignment.MiddleCenter;
            judul.Location = new Point(250, 30);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void buyclick(object sender, EventArgs e)
        {
            DialogResult buyconfirm = MessageBox.Show("Are you sure want to buy this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (buyconfirm == DialogResult.Yes)
            {
                equip1.Visible = true;
            }
            else if (buyconfirm == DialogResult.No)
            {
                //do something else
            }
        }

        void buyclick2(object sender, EventArgs e)
        {
            DialogResult buyconfirm2 = MessageBox.Show("Are you sure want to buy this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (buyconfirm2 == DialogResult.Yes)
            {
                equip2.Visible = true;
            }
            else if (buyconfirm2 == DialogResult.No)
            {
                //do something else
            }
        }

        void buyclick3(object sender, EventArgs e)
        {
            DialogResult buyconfirm3 = MessageBox.Show("Are you sure want to buy this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (buyconfirm3 == DialogResult.Yes)
            {
                equip3.Visible = true;
            }
            else if (buyconfirm3 == DialogResult.No)
            {
                //do something else
            }
        }

        void equipclick(object sender, EventArgs e)
        {
            DialogResult equipconfirm = MessageBox.Show("Are you sure want to equip this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (equipconfirm == DialogResult.Yes)
            {
                MessageBox.Show("Item Equipped");
                equip1.Text = "Equipped";
                equip2.Text = "Equip";
                equip3.Text = "Equip";
                equip1.Enabled = false;
                equip2.Enabled = true;
                equip3.Enabled = true;
            }
            else if (equipconfirm == DialogResult.No)
            {
                
            }
        }

        void equipclick2(object sender, EventArgs e)
        {
            DialogResult equipconfirm2 = MessageBox.Show("Are you sure want to equip this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (equipconfirm2 == DialogResult.Yes)
            {
                MessageBox.Show("Item Equipped");
                equip2.Text = "Equipped";
                equip1.Text = "Equip";
                equip3.Text = "Equip";
                equip2.Enabled = false;
                equip1.Enabled = true;
                equip3.Enabled = true;
            }
            else if (equipconfirm2 == DialogResult.No)
            {

            }
        }

        void equipclick3(object sender, EventArgs e)
        {
            DialogResult equipconfirm3 = MessageBox.Show("Are you sure want to equip this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (equipconfirm3 == DialogResult.Yes)
            {
                MessageBox.Show("Item Equipped");
                equip3.Text = "Equipped";
                equip1.Text = "Equip";
                equip2.Text = "Equip";
                equip3.Enabled = false;
                equip1.Enabled = true;
                equip2.Enabled = true;
            }
            else if (equipconfirm3 == DialogResult.No)
            {

            }
        }
    }
}
