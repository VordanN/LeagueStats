
namespace LeageStats
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SNameLable = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.SRegion = new System.Windows.Forms.ComboBox();
            this.SServerLable = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SNameLable
            // 
            this.SNameLable.AutoSize = true;
            this.SNameLable.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLable.ForeColor = System.Drawing.Color.Black;
            this.SNameLable.Location = new System.Drawing.Point(0, 98);
            this.SNameLable.Name = "SNameLable";
            this.SNameLable.Size = new System.Drawing.Size(70, 28);
            this.SNameLable.TabIndex = 0;
            this.SNameLable.Text = "Name:";
            // 
            // SName
            // 
            this.SName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SName.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.ForeColor = System.Drawing.Color.Black;
            this.SName.Location = new System.Drawing.Point(5, 123);
            this.SName.MaxLength = 39;
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(330, 28);
            this.SName.TabIndex = 1;
            this.SName.TextChanged += new System.EventHandler(this.SName_TextChanged);
            // 
            // SRegion
            // 
            this.SRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SRegion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SRegion.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRegion.ForeColor = System.Drawing.Color.Black;
            this.SRegion.FormattingEnabled = true;
            this.SRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SRegion.Items.AddRange(new object[] {
            "BR1",
            "EUN1",
            "EUW1",
            "JP1",
            "KR",
            "LA1",
            "LA2",
            "NA1",
            "OC1",
            "RU",
            "TR1"});
            this.SRegion.Location = new System.Drawing.Point(5, 29);
            this.SRegion.Name = "SRegion";
            this.SRegion.Size = new System.Drawing.Size(340, 29);
            this.SRegion.Sorted = true;
            this.SRegion.TabIndex = 3;
            this.SRegion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.SRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockText);
            // 
            // SServerLable
            // 
            this.SServerLable.AutoSize = true;
            this.SServerLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SServerLable.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SServerLable.ForeColor = System.Drawing.Color.Black;
            this.SServerLable.Location = new System.Drawing.Point(2, 2);
            this.SServerLable.Name = "SServerLable";
            this.SServerLable.Size = new System.Drawing.Size(73, 28);
            this.SServerLable.TabIndex = 0;
            this.SServerLable.Text = "Server:";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(10)))), ((int)(((byte)(102)))));
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.search.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.Info;
            this.search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search.Location = new System.Drawing.Point(79, 222);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(195, 68);
            this.search.TabIndex = 4;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(10)))), ((int)(((byte)(102)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Location = new System.Drawing.Point(40, 30);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(350, 500);
            this.MainPanel.TabIndex = 7;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InputPanel.Controls.Add(this.webBrowser1);
            this.InputPanel.Controls.Add(this.panel3);
            this.InputPanel.Controls.Add(this.SRegion);
            this.InputPanel.Controls.Add(this.search);
            this.InputPanel.Controls.Add(this.SServerLable);
            this.InputPanel.Controls.Add(this.SName);
            this.InputPanel.Controls.Add(this.SNameLable);
            this.InputPanel.Location = new System.Drawing.Point(0, 140);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(350, 312);
            this.InputPanel.TabIndex = 7;
            this.InputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InputPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(5, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 1);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(45, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1);
            this.panel1.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(151, 157);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(10)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "  Bredly.gg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SNameLable;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.ComboBox SRegion;
        private System.Windows.Forms.Label SServerLable;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

