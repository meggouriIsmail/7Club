
namespace _7Club
{
    partial class Consomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consomation));
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.games = new System.Windows.Forms.PictureBox();
            this.jus = new System.Windows.Forms.PictureBox();
            this.cafe = new System.Windows.Forms.PictureBox();
            this.gaz = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaz)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(550, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(238, 234);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(738, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView3
            // 
            this.listView3.AutoArrange = false;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(12, 192);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(532, 280);
            this.listView3.TabIndex = 4;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.Click += new System.EventHandler(this.listView3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(582, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "VIP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(618, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "7CLUB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(674, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "AHMAD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.games);
            this.groupBox1.Controls.Add(this.jus);
            this.groupBox1.Controls.Add(this.cafe);
            this.groupBox1.Controls.Add(this.gaz);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 173);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // games
            // 
            this.games.Image = global::_7Club.Properties.Resources.games;
            this.games.Location = new System.Drawing.Point(341, 19);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(101, 71);
            this.games.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.games.TabIndex = 12;
            this.games.TabStop = false;
            this.games.Click += new System.EventHandler(this.games_Click);
            // 
            // jus
            // 
            this.jus.Image = global::_7Club.Properties.Resources.JUS;
            this.jus.Location = new System.Drawing.Point(234, 20);
            this.jus.Name = "jus";
            this.jus.Size = new System.Drawing.Size(101, 71);
            this.jus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jus.TabIndex = 10;
            this.jus.TabStop = false;
            this.jus.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cafe
            // 
            this.cafe.Image = global::_7Club.Properties.Resources.café;
            this.cafe.Location = new System.Drawing.Point(127, 20);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(101, 71);
            this.cafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cafe.TabIndex = 11;
            this.cafe.TabStop = false;
            this.cafe.Click += new System.EventHandler(this.cafe_Click);
            // 
            // gaz
            // 
            this.gaz.Image = global::_7Club.Properties.Resources.boissanGAZ;
            this.gaz.Location = new System.Drawing.Point(21, 20);
            this.gaz.Name = "gaz";
            this.gaz.Size = new System.Drawing.Size(101, 71);
            this.gaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gaz.TabIndex = 0;
            this.gaz.TabStop = false;
            this.gaz.Click += new System.EventHandler(this.gaz_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Imprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Consomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Consomation";
            this.Text = "Consomation";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox gaz;
        private System.Windows.Forms.PictureBox jus;
        private System.Windows.Forms.PictureBox cafe;
        private System.Windows.Forms.PictureBox games;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}