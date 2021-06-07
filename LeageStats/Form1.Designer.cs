
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(72)))), ((int)(((byte)(95)))));
            this.InputPanel.Controls.Add(this.comboBox1);
            this.InputPanel.Controls.Add(this.SRegion);
            this.InputPanel.Controls.Add(this.search);
            this.InputPanel.Controls.Add(this.SServerLable);
            this.InputPanel.Controls.Add(this.SNameLable);
            this.InputPanel.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.InputPanel, "InputPanel");
            this.InputPanel.Name = "InputPanel";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Sorted = true;
            this.comboBox1.TabStop = false;
            // 
            // SRegion
            // 
            this.SRegion.BackColor = System.Drawing.Color.White;
            this.SRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.SRegion, "SRegion");
            this.SRegion.ForeColor = System.Drawing.Color.Black;
            this.SRegion.FormattingEnabled = true;
            this.SRegion.Items.AddRange(new object[] {
            resources.GetString("SRegion.Items"),
            resources.GetString("SRegion.Items1"),
            resources.GetString("SRegion.Items2"),
            resources.GetString("SRegion.Items3"),
            resources.GetString("SRegion.Items4"),
            resources.GetString("SRegion.Items5"),
            resources.GetString("SRegion.Items6"),
            resources.GetString("SRegion.Items7"),
            resources.GetString("SRegion.Items8"),
            resources.GetString("SRegion.Items9"),
            resources.GetString("SRegion.Items10")});
            this.SRegion.Name = "SRegion";
            this.SRegion.Sorted = true;
            this.SRegion.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(113)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.search, "search");
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(103)))));
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(103)))));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(215)))));
            this.search.Name = "search";
            this.search.TabStop = false;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SServerLable
            // 
            resources.ApplyResources(this.SServerLable, "SServerLable");
            this.SServerLable.BackColor = System.Drawing.Color.Transparent;
            this.SServerLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SServerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SServerLable.Name = "SServerLable";
            // 
            // SNameLable
            // 
            resources.ApplyResources(this.SNameLable, "SNameLable");
            this.SNameLable.BackColor = System.Drawing.Color.Transparent;
            this.SNameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SNameLable.Name = "SNameLable";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
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

