
namespace LeageStats
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LP = new System.Windows.Forms.Label();
            this.LTier = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LLVL = new System.Windows.Forms.Label();
            this.SLvL = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IRankImage = new System.Windows.Forms.PictureBox();
            this.ISLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IRankImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(72)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LLVL);
            this.panel1.Controls.Add(this.SLvL);
            this.panel1.Controls.Add(this.Losses);
            this.panel1.Controls.Add(this.Wins);
            this.panel1.Controls.Add(this.ISLogo);
            this.panel1.Controls.Add(this.SName);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.LP);
            this.panel3.Controls.Add(this.LTier);
            this.panel3.Controls.Add(this.IRankImage);
            this.panel3.Name = "panel3";
            // 
            // LP
            // 
            resources.ApplyResources(this.LP, "LP");
            this.LP.BackColor = System.Drawing.Color.Transparent;
            this.LP.ForeColor = System.Drawing.Color.White;
            this.LP.Name = "LP";
            this.LP.Tag = "Tier";
            // 
            // LTier
            // 
            resources.ApplyResources(this.LTier, "LTier");
            this.LTier.BackColor = System.Drawing.Color.Transparent;
            this.LTier.ForeColor = System.Drawing.Color.White;
            this.LTier.Name = "LTier";
            this.LTier.Tag = "Tier";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Name = "panel2";
            // 
            // LLVL
            // 
            resources.ApplyResources(this.LLVL, "LLVL");
            this.LLVL.BackColor = System.Drawing.Color.Transparent;
            this.LLVL.ForeColor = System.Drawing.Color.White;
            this.LLVL.Name = "LLVL";
            // 
            // SLvL
            // 
            resources.ApplyResources(this.SLvL, "SLvL");
            this.SLvL.BackColor = System.Drawing.Color.Transparent;
            this.SLvL.ForeColor = System.Drawing.Color.White;
            this.SLvL.Name = "SLvL";
            this.SLvL.Tag = "Level";
            // 
            // Losses
            // 
            resources.ApplyResources(this.Losses, "Losses");
            this.Losses.Name = "Losses";
            this.Losses.Tag = "Losses";
            // 
            // Wins
            // 
            resources.ApplyResources(this.Wins, "Wins");
            this.Wins.Name = "Wins";
            this.Wins.Tag = "Wins";
            // 
            // SName
            // 
            resources.ApplyResources(this.SName, "SName");
            this.SName.BackColor = System.Drawing.Color.Transparent;
            this.SName.ForeColor = System.Drawing.Color.White;
            this.SName.Name = "SName";
            this.SName.Tag = "SummonerName";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // IRankImage
            // 
            resources.ApplyResources(this.IRankImage, "IRankImage");
            this.IRankImage.BackColor = System.Drawing.Color.Transparent;
            this.IRankImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.IRankImage.Name = "IRankImage";
            this.IRankImage.TabStop = false;
            this.IRankImage.Tag = "Emblem";
            // 
            // ISLogo
            // 
            resources.ApplyResources(this.ISLogo, "ISLogo");
            this.ISLogo.BackColor = System.Drawing.Color.Transparent;
            this.ISLogo.Name = "ISLogo";
            this.ISLogo.TabStop = false;
            this.ISLogo.Tag = "ProfileIcon";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IRankImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SLvL;
        private System.Windows.Forms.Label LLVL;
        private System.Windows.Forms.Label Losses;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.PictureBox ISLogo;
        private System.Windows.Forms.PictureBox IRankImage;
        private System.Windows.Forms.Label LTier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}