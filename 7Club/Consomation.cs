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
    }
}
