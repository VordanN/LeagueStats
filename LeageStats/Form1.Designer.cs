
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
            this.InputPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SRegion = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.SServerLable = new System.Windows.Forms.Label();
            this.SNameLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(72)))), ((int)(((byte)(95)))));
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.comboBox1);
            this.InputPanel.Controls.Add(this.SRegion);
            this.InputPanel.Controls.Add(this.search);
            this.InputPanel.Controls.Add(this.SServerLable);
            this.InputPanel.Controls.Add(this.SNameLable);
            this.InputPanel.ForeColor = System.Drawing.Color.White;
            this.InputPanel.Location = new System.Drawing.Point(19, 156);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(296, 263);
            this.InputPanel.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(-1, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(296, 29);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TabStop = false;
            // 
            // SRegion
            // 
            this.SRegion.BackColor = System.Drawing.Color.White;
            this.SRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.SRegion.Location = new System.Drawing.Point(0, 29);
            this.SRegion.Name = "SRegion";
            this.SRegion.Size = new System.Drawing.Size(295, 29);
            this.SRegion.Sorted = true;
            this.SRegion.TabIndex = 3;
            this.SRegion.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            this.search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(103)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(103)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(215)))));
            this.search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search.Location = new System.Drawing.Point(0, 219);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(294, 42);
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SServerLable
            // 
            this.SServerLable.AutoSize = true;
            this.SServerLable.BackColor = System.Drawing.Color.Transparent;
            this.SServerLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SServerLable.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SServerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SServerLable.Location = new System.Drawing.Point(-2, 0);
            this.SServerLable.Name = "SServerLable";
            this.SServerLable.Size = new System.Drawing.Size(73, 28);
            this.SServerLable.TabIndex = 0;
            this.SServerLable.Text = "Server:";
            // 
            // SNameLable
            // 
            this.SNameLable.AutoSize = true;
            this.SNameLable.BackColor = System.Drawing.Color.Transparent;
            this.SNameLable.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SNameLable.Location = new System.Drawing.Point(-2, 122);
            this.SNameLable.Name = "SNameLable";
            this.SNameLable.Size = new System.Drawing.Size(70, 28);
            this.SNameLable.TabIndex = 0;
            this.SNameLable.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 179);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.Location = new System.Drawing.Point(-53, -15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 35);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(304, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 21);
            this.button2.TabIndex = 10;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "  Bredly.gg";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.ComboBox SRegion;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label SServerLable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SNameLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

