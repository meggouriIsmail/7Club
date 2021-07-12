using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Club
{
    public partial class Consomation : Form
    {
        public Consomation()
        {
            InitializeComponent();
            listView1.Items.Add("                          7CLUB ");
            listView1.Items.Add("");
            listView1.Items.Add("");
            listView1.Items.Add("Nom Produit        10.00DH");
            listView1.Items.Add("Nom Produit        10.50DH");
            listView1.Items.Add("Nom Produit        11.00DH");
            listView1.Items.Add("Nom Produit        12.00DH");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count - 1 >= 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
            }
        }
    }
}
