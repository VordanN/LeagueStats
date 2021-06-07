
namespace LeageStats
{
    partial class Scrool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scrool));
            this.InputPanel = new System.Windows.Forms.Panel();
            this.End = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.SServerLable = new System.Windows.Forms.Label();
            this.SNameLable = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(72)))), ((int)(((byte)(95)))));
            this.InputPanel.Controls.Add(this.End);
            this.InputPanel.Controls.Add(this.Start);
            this.InputPanel.Controls.Add(this.search);
            this.InputPanel.Controls.Add(this.SServerLable);
            this.InputPanel.Controls.Add(this.SNameLable);
            this.InputPanel.ForeColor = System.Drawing.Color.White;
            this.InputPanel.Location = new System.Drawing.Point(19, 150);
            this.InputPanel.Margin = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(296, 189);
            this.InputPanel.TabIndex = 11;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(0, 102);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(296, 20);
            this.End.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(0, 36);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(296, 20);
            this.Start.TabIndex = 5;
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
            this.search.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(215)))));
            this.search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.Location = new System.Drawing.Point(0, 147);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(296, 42);
            this.search.TabIndex = 4;
            this.search.TabStop = false;
            this.search.Text = "SHOW";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SServerLable
            // 
            this.SServerLable.AutoSize = true;
            this.SServerLable.BackColor = System.Drawing.Color.Transparent;
            this.SServerLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SServerLable.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.SServerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SServerLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SServerLable.Location = new System.Drawing.Point(-2, 0);
            this.SServerLable.Name = "SServerLable";
            this.SServerLable.Size = new System.Drawing.Size(58, 28);
            this.SServerLable.TabIndex = 0;
            this.SServerLable.Text = "Start:";
            // 
            // SNameLable
            // 
            this.SNameLable.AutoSize = true;
            this.SNameLable.BackColor = System.Drawing.Color.Transparent;
            this.SNameLable.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.SNameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.SNameLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SNameLable.Location = new System.Drawing.Point(-2, 71);
            this.SNameLable.Name = "SNameLable";
            this.SNameLable.Size = new System.Drawing.Size(46, 28);
            this.SNameLable.TabIndex = 0;
            this.SNameLable.Text = "End";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(302, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(-49, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 28);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(61, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 179);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Scrool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(334, 350);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scrool";
            this.Text = "Scrool";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label SServerLable;
        private System.Windows.Forms.Label SNameLable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox End;
    }
}