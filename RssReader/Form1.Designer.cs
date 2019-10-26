namespace RSS_Okuma_Uygulaması
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
            this.btn_goster = new System.Windows.Forms.Button();
            this.txt_rssurl = new System.Windows.Forms.TextBox();
            this.gb_rssurl = new System.Windows.Forms.GroupBox();
            this.list_haberler = new System.Windows.Forms.ListBox();
            this.web_haberdetay = new System.Windows.Forms.WebBrowser();
            this.gb_haberbaslıkları = new System.Windows.Forms.GroupBox();
            this.gb_haberdetay = new System.Windows.Forms.GroupBox();
            this.gb_rssurl.SuspendLayout();
            this.gb_haberbaslıkları.SuspendLayout();
            this.gb_haberdetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(1017, 19);
            this.btn_goster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(87, 26);
            this.btn_goster.TabIndex = 0;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // txt_rssurl
            // 
            this.txt_rssurl.Location = new System.Drawing.Point(7, 22);
            this.txt_rssurl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_rssurl.Name = "txt_rssurl";
            this.txt_rssurl.Size = new System.Drawing.Size(1003, 22);
            this.txt_rssurl.TabIndex = 1;
            this.txt_rssurl.Text = "https://www.sabah.com.tr/rss/anasayfa.xml";
            // 
            // gb_rssurl
            // 
            this.gb_rssurl.Controls.Add(this.txt_rssurl);
            this.gb_rssurl.Controls.Add(this.btn_goster);
            this.gb_rssurl.Location = new System.Drawing.Point(14, 14);
            this.gb_rssurl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_rssurl.Name = "gb_rssurl";
            this.gb_rssurl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_rssurl.Size = new System.Drawing.Size(1122, 62);
            this.gb_rssurl.TabIndex = 2;
            this.gb_rssurl.TabStop = false;
            this.gb_rssurl.Text = "RSS URL";
            // 
            // list_haberler
            // 
            this.list_haberler.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_haberler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.list_haberler.FormattingEnabled = true;
            this.list_haberler.ItemHeight = 17;
            this.list_haberler.Location = new System.Drawing.Point(7, 22);
            this.list_haberler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_haberler.Name = "list_haberler";
            this.list_haberler.Size = new System.Drawing.Size(422, 463);
            this.list_haberler.TabIndex = 3;
            this.list_haberler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // web_haberdetay
            // 
            this.web_haberdetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_haberdetay.Location = new System.Drawing.Point(3, 19);
            this.web_haberdetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.web_haberdetay.MinimumSize = new System.Drawing.Size(23, 23);
            this.web_haberdetay.Name = "web_haberdetay";
            this.web_haberdetay.ScriptErrorsSuppressed = true;
            this.web_haberdetay.Size = new System.Drawing.Size(673, 474);
            this.web_haberdetay.TabIndex = 4;
            // 
            // gb_haberbaslıkları
            // 
            this.gb_haberbaslıkları.Controls.Add(this.list_haberler);
            this.gb_haberbaslıkları.Location = new System.Drawing.Point(14, 83);
            this.gb_haberbaslıkları.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_haberbaslıkları.Name = "gb_haberbaslıkları";
            this.gb_haberbaslıkları.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_haberbaslıkları.Size = new System.Drawing.Size(436, 497);
            this.gb_haberbaslıkları.TabIndex = 5;
            this.gb_haberbaslıkları.TabStop = false;
            this.gb_haberbaslıkları.Text = "Haber Başlıkları";
            // 
            // gb_haberdetay
            // 
            this.gb_haberdetay.Controls.Add(this.web_haberdetay);
            this.gb_haberdetay.Location = new System.Drawing.Point(457, 83);
            this.gb_haberdetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_haberdetay.Name = "gb_haberdetay";
            this.gb_haberdetay.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gb_haberdetay.Size = new System.Drawing.Size(679, 497);
            this.gb_haberdetay.TabIndex = 6;
            this.gb_haberdetay.TabStop = false;
            this.gb_haberdetay.Text = "Haber Detayları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1150, 593);
            this.Controls.Add(this.gb_haberdetay);
            this.Controls.Add(this.gb_haberbaslıkları);
            this.Controls.Add(this.gb_rssurl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RssReader";
            this.gb_rssurl.ResumeLayout(false);
            this.gb_rssurl.PerformLayout();
            this.gb_haberbaslıkları.ResumeLayout(false);
            this.gb_haberdetay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.TextBox txt_rssurl;
        private System.Windows.Forms.GroupBox gb_rssurl;
        private System.Windows.Forms.ListBox list_haberler;
        private System.Windows.Forms.WebBrowser web_haberdetay;
        private System.Windows.Forms.GroupBox gb_haberbaslıkları;
        private System.Windows.Forms.GroupBox gb_haberdetay;
    }
}

