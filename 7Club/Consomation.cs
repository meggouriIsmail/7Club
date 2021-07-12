using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count - 1 >= 0)
            {
                listView1.Items.RemoveAt(listView1.Items.Count - 1);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ImageList imageList1 = new ImageList();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Meggouri\Desktop\7Club\7Club\jus");
            this.listView3.View = View.LargeIcon;
            imageList1.ImageSize = new Size(100, 100);
            this.listView3.LargeImageList = imageList1;
            int j = 0;
            listView3.Items.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
                    ListViewItem item = new ListViewItem(file.Name.Split('.')[0]);
                    item.Tag = file.Name;
                    item.ImageIndex = j;
                    this.listView3.Items.Add(item);
                    j++;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
        }

        private void gaz_Click(object sender, EventArgs e)
        {
            ImageList imageList1 = new ImageList();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Meggouri\Desktop\7Club\7Club\gaz");
            this.listView3.View = View.LargeIcon;
            imageList1.ImageSize = new Size(100, 100);
            this.listView3.LargeImageList = imageList1;
            int j = 0;
            listView3.Items.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
                    ListViewItem item = new ListViewItem(file.Name.Split('.')[0]);
                    item.Tag = file.Name;
                    item.ImageIndex = j;
                    this.listView3.Items.Add(item);
                    j++;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
        }

        private void cafe_Click(object sender, EventArgs e)
        {
            ImageList imageList1 = new ImageList();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Meggouri\Desktop\7Club\7Club\café");
            this.listView3.View = View.LargeIcon;
            imageList1.ImageSize = new Size(100, 100);
            this.listView3.LargeImageList = imageList1;
            int j = 0;
            listView3.Items.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
                    ListViewItem item = new ListViewItem(file.Name.Split('.')[0]);
                    item.Tag = file.Name;
                    item.ImageIndex = j;
                    this.listView3.Items.Add(item);
                    j++;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
        }

        private void games_Click(object sender, EventArgs e)
        {
            ImageList imageList1 = new ImageList();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Meggouri\Desktop\7Club\7Club\games");
            this.listView3.View = View.LargeIcon;
            imageList1.ImageSize = new Size(67, 100);
            this.listView3.LargeImageList = imageList1;
            int j = 0;
            listView3.Items.Clear();
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    imageList1.Images.Add(file.Name, Image.FromFile(file.FullName));
                    ListViewItem item = new ListViewItem(file.Name.Split('.')[0]);
                    item.Tag = file.Name;
                    item.ImageIndex = j;
                    this.listView3.Items.Add(item);
                    j++;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
        }

        private void listView3_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(listView3.Items[listView3.SelectedIndices[0]].Text + "                       12.00DH");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("7CLUB", new Font("Arial", 15, FontStyle.Italic), Brushes.Gray, new Point(115, 10));

            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 4, FontStyle.Bold), Brushes.Gray, new Point(5, 90));
            e.Graphics.DrawString("Item Name", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString("Quantité", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(90, 100));
            e.Graphics.DrawString("Prix Unitaire", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, 100));
            e.Graphics.DrawString("Prix Total", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(240, 100));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 4, FontStyle.Bold), Brushes.Gray, new Point(5, 110));
            e.Graphics.DrawString("Cappuccino", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(20, 120));
            e.Graphics.DrawString("1", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(90, 120));
            e.Graphics.DrawString("10.00", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, 120));
            e.Graphics.DrawString("10.00", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(240, 120));

            e.Graphics.DrawString("Jus Orange", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(20, 135));
            e.Graphics.DrawString("1", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(90, 135));
            e.Graphics.DrawString("10.00", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, 135));
            e.Graphics.DrawString("10.00", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(240, 135));
            e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 4, FontStyle.Bold), Brushes.Gray, new Point(5, 240));
            e.Graphics.DrawString("TOTAL NET :          50.00", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(20, 245));
            e.Graphics.DrawString("* N° Ticket : 415", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, new Point(20, 265));
            e.Graphics.DrawString("* Caissier : Amine", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, new Point(20, 280));
            e.Graphics.DrawString("* Date : " + DateTime.Now, new Font("Arial", 5, FontStyle.Regular), Brushes.Black, new Point(20, 295));
            e.Graphics.DrawString("* Code WiFi : khbazBrahim", new Font("Arial", 5, FontStyle.Regular), Brushes.Black, new Point(20, 310));

            e.Graphics.DrawString("MERCI DE VOIR VISITE", new Font("Arial", 4, FontStyle.Regular), Brushes.Black, new Point(115, 320));
            e.Graphics.DrawString("A BIENTOT", new Font("Arial", 4, FontStyle.Regular), Brushes.Black, new Point(130, 330));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("papersize", 300, 400);
            printPreviewDialog1.Show();
        }
    }
}
