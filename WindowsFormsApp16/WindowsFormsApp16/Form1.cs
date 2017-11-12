using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        string POS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public Form1()
        {
            InitializeComponent();
        }
        
        public void C(string menu, string Bath)

        {
            string[] C = { menu, Bath };
            var L = new ListViewItem(C);
            listView1.Items.Add(L);
        }
        double P;
        public string[] K()
        {
            P = 0;
            string[] G = new string[listView1.Items.Count];
            int items = listView1.Items.Count;
            for (int i = 0; i < items; i++)
            {
                P += double.Parse(listView1.Items[i].SubItems[1].Text);
                G[i] = listView1.Items[i].SubItems[0].Text.ToString();

            }
            Pice.Text = P.ToString();
            return G;


        }
        public string[] M()
        {
            string[] G = new string[listView1.Items.Count];
            int items = listView1.Items.Count;
            for (int i = 0; i < items; i++)
            {

                G[i] = listView1.Items[i].SubItems[0].Text.ToString();

            }
            return G;
        }
        public void HA()
        {
            string[] S = K();
            string[] A = M();
            string mu = "Coffee POS" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string LOL = "Coffee POS";
            LOL += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            LOL += "Menu" + "\r\n";
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                LOL += S[i] + new String(' ', 20) + A[i] + "Bath" + "\r\n";


            }
            LOL += "\r\n";
            LOL += "Totle Price :" + Pice.Text;
            System.IO.File.WriteAllText(POS + @"\" + mu + ".txt", LOL);
            label21.Text += LOL + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + POS + @"\" + mu + ".txt";



        }
        bool oh = false;
        private void button1_Click(object sender, EventArgs e)
        {
            C("Esspresso(hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            C("Esspresso(ICE)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            C("Esspresso(Frappe)", "50");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C("Americano(hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            C("Americano(ICE)", "35");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C("Latte(hot)", "35");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            C("Latte(ICE)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            C("Latte(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            C("Mocha(hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            C("Mocha(ICE)", "45");
        }

        private void button16_Click(object sender, EventArgs e)
        {
               C("Mocha(Frappe)", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            C("Cappuccino(HOT )", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            C("Cappuccino(ICE)", "45");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            C("Cappuccino(Frappe)", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            C(" GrenTea(HOT )", "20");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            C("GrenTea(ICE)", "25");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            C("GrenTea(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            C("thaitea(HOT )", "20");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            C("thaitea(ICE)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            C("thaitea(Frappe)", "30");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            C(" CoCoa(HOT )", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            C("CoCoa(ICE)", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            C("CoCoa(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            C("Milk(HOT )", "20");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            C("Milk(ICE)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            C("Milk(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            C(" Mocha(HOT )", "35");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            C("Milktea(ICE)", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            C("Milktea(Frappe)", "30");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            C("Lemontea(ICE)", "25");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            C("Lemontea(Frappe)", "30");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            C(" milo(HOT )", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            C("milo(ICE)", "25");

        }

        private void button36_Click(object sender, EventArgs e)
        {
            C("milo(Frappe)", "30");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            C(" Nescafe(HOT )", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            C("Nescafe(ICE)", "25");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            C("Nescafe(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            C(" Naeteatea(HOT )", "20");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            C("Naeteatea(ICE)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            C("Naeteatea(Frappe)", "30");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            C("Italian Soda(ICE)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            C("Rad lime Sond(ICE)", "25");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            C("Honeu lime Sond(ICE)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            Pice.Text = " ";
            if (oh == false)
            {
                mamu.TabPages.Insert(1, mamu1);
                oh = true;
                mamu.SelectedTab = mamu1;
            }
            else mamu.SelectedTab = mamu1;
            if (listView1.Items.Count > 0)
                HA();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            oh = false;
            mamu.Controls.Remove(mamu1);
            mamu.Text = " ";
            Pice.Text = "";
        }
    }
}
