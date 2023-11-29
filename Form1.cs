using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Point_of_Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_Items()
        {
            double sum = 0;
            int i = 0;

            for (i = 0; i < (dataGridView1.Rows.Count) ;
            i++)
                {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                }
            return sum;

        }

        private void AddCost()
        {
            Double tax, q;
            tax = 3.9;
            if(dataGridView1.Rows.Count>0)
            {
                lblTax.Text = string.Format("{0:c2}", (((Cost_of_Items() * tax / 100))));
                lblSubTotal.Text = string.Format("{0:c2}", (Cost_of_Items()));
                q = ((Cost_of_Items() * tax / 100));
                lblTotal.Text= string.Format("{0:c2}", (Cost_of_Items() +q));
                lblBarCode.Text = Convert.ToString(q + Cost_of_Items());
            }
        }

        private void Change()
        {
            Double tax, q,c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax / 100)) + Cost_of_Items();
                c = Convert.ToInt32(lblCash.Text);
                lblChange.Text = string.Format("{0:c2}", c - q);
            }
        }

        Bitmap bitmap;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double Custofile = 5;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "hamburger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("hamburger", "1", Custofile);
            AddCost();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Double Custofile = 47;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "sakaladli ve ciyelekli"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("sakaladli ve ciyelekli", "1", Custofile);
            AddCost();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double Custofile = 10;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "kofeini dondurma"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("kofeini dondurma", "1", Custofile);
            AddCost();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                lblBarCode.Text = "";
                lblCash.Text = "0";
                lblChange.Text = "";
                lblSubTotal.Text = "";
                lblTotal.Text = "";
                lblTax.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cboPayment.Text = "";
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cboPayment.Items.Add("Cash");
            //cboPayment.Items.Add("Visa card");
            //cboPayment.Items.Add("Master Card");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPayment_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double Custofile = 17;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "ciyelekli tort"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("ciyelekli tort", "1", Custofile);
            AddCost();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Double Custofile = 2.20;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "meyve suyu gilanar"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("meyve suyu gilanar", "1", Custofile);
            AddCost();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Double Custofile = 5;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "cehrayi dondurma"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("cehrayi dondurma", "1", Custofile);
            AddCost();
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lblCash.Text == "0")
            {
                lblCash.Text = "";
                lblCash.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!lblCash.Text.Contains("."))
                {
                    lblCash.Text = lblCash.Text + b.Text;
                }
            }
            else
                lblCash.Text = lblCash.Text + b.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblCash.Text = "0";
        }

        private void lblCash_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (cboPayment.Text=="Cash")
            {
                Change();

            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            if (cboPayment.Text == "Cash")
            {
                Change();

            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double Custofile = 3;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if((bool)(row.Cells[0].Value="pepsi"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("pepsi","1",Custofile);
            AddCost();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Double Custofile = 2.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "CocaCola"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("CocaCola", "1", Custofile);
            AddCost();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double Custofile = 3;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "CocaCola Zero"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("CocaCola Zero", "1", Custofile);
            AddCost();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Double Custofile = 2;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sprite"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("Sprite", "1", Custofile);
            AddCost();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Double Custofile = 1.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "fanta"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("fanta", "1", Custofile);
            AddCost();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Double Custofile = 4;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "portagal suyu"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("portagal suyu", "1", Custofile);
            AddCost();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Double Custofile = 12;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "pizza"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("pizza", "1", Custofile);
            AddCost();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Double Custofile = 6;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "toyuq eti"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("toyuq eti", "1", Custofile);
            AddCost();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Double Custofile = 3.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "lavas doner"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("lavas doner", "1", Custofile);
            AddCost();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double Custofile = 1.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "burger"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("burger", "1", Custofile);
            AddCost();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Double Custofile = 22;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "new york pizza"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("new york pizza", "1", Custofile);
            AddCost();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double Custofile = 25;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "etli yemek"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("etli yemek", "1", Custofile);
            AddCost();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double Custofile = 7;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "kabab"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("kabab", "1", Custofile);
            AddCost();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double Custofile = 10;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "qril"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("qril", "1", Custofile);
            AddCost();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Double Custofile = 15;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "seher yemeyi"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("seher yemeyi", "1", Custofile);
            AddCost();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Double Custofile = 12;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "salat"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("salat", "1", Custofile);
            AddCost();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double Custofile = 2.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "merci supu"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("merci supu", "1", Custofile);
            AddCost();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Double Custofile = 25;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "sakaladli tort"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("sakaladli tort", "1", Custofile);
            AddCost();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Double Custofile = 7;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "desert"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("desert", "1", Custofile);
            AddCost();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Double Custofile = 33;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "balli tort"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("balli tort", "1", Custofile);
            AddCost();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Double Custofile = 13;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "yeni dondurma"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("yeni dondurma", "1", Custofile);
            AddCost();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Double Custofile = 7;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "3+1 dondurma"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("3+1 dondurma", "1", Custofile);
            AddCost();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Double Custofile = 14;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "qabda dondurma"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("qabda dondurma", "1", Custofile);
            AddCost();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Double Custofile = 3.20;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "qarpiz suyu"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value) * Custofile;
                    AddCost();
                }
            }
            dataGridView1.Rows.Add("qarpiz suyu", "1", Custofile);
            AddCost();
        }
    }
}
