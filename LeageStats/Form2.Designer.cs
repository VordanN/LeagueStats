
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LRank = new System.Windows.Forms.Label();
            this.LTier = new System.Windows.Forms.Label();
            this.LLVL = new System.Windows.Forms.Label();
            this.MatcHisroy = new System.Windows.Forms.Button();
            this.SLvL = new System.Windows.Forms.Label();
            this.Losses = new System.Windows.Forms.Label();
            this.Wins = new System.Windows.Forms.Label();
            this.LLusses = new System.Windows.Forms.Label();
            this.LWins = new System.Windows.Forms.Label();
            this.ISLogo = new System.Windows.Forms.PictureBox();
            this.IRankImage = new System.Windows.Forms.PictureBox();
            this.SName = new System.Windows.Forms.Label();
            this.PMatchHistory = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRankImage)).BeginInit();
            this.PMatchHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LRank);
            this.panel1.Controls.Add(this.LTier);
            this.panel1.Controls.Add(this.LLVL);
            this.panel1.Controls.Add(this.MatcHisroy);
            this.panel1.Controls.Add(this.SLvL);
            this.panel1.Controls.Add(this.Losses);
            this.panel1.Controls.Add(this.Wins);
            this.panel1.Controls.Add(this.LLusses);
            this.panel1.Controls.Add(this.LWins);
            this.panel1.Controls.Add(this.ISLogo);
            this.panel1.Controls.Add(this.IRankImage);
            this.panel1.Controls.Add(this.SName);
            this.panel1.Location = new System.Drawing.Point(18, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 9;
            // 
            // LRank
            // 
            this.LRank.AutoSize = true;
            this.LRank.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRank.ForeColor = System.Drawing.Color.Black;
            this.LRank.Location = new System.Drawing.Point(310, 179);
            this.LRank.Name = "LRank";
            this.LRank.Size = new System.Drawing.Size(0, 30);
            this.LRank.TabIndex = 8;
            this.LRank.Tag = "Rank";
            // 
            // LTier
            // 
            this.LTier.AutoSize = true;
            this.LTier.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTier.ForeColor = System.Drawing.Color.Black;
            this.LTier.Location = new System.Drawing.Point(249, 179);
            this.LTier.Name = "LTier";
            this.LTier.Size = new System.Drawing.Size(0, 30);
            this.LTier.TabIndex = 7;
            this.LTier.Tag = "Tier";
            // 
            // LLVL
            // 
            this.LLVL.AutoSize = true;
            this.LLVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLVL.Location = new System.Drawing.Point(233, 423);
            this.LLVL.Name = "LLVL";
            this.LLVL.Size = new System.Drawing.Size(50, 25);
            this.LLVL.TabIndex = 4;
            this.LLVL.Text = "LVL";
            // 
            // MatcHisroy
            // 
            this.MatcHisroy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(10)))), ((int)(((byte)(102)))));
            this.MatcHisroy.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatcHisroy.ForeColor = System.Drawing.Color.White;
            this.MatcHisroy.Location = new System.Drawing.Point(101, 480);
            this.MatcHisroy.Name = "MatcHisroy";
            this.MatcHisroy.Size = new System.Drawing.Size(191, 35);
            this.MatcHisroy.TabIndex = 6;
            this.MatcHisroy.Text = "Match History";
            this.MatcHisroy.UseVisualStyleBackColor = false;
            this.MatcHisroy.UseWaitCursor = true;
            // 
            // SLvL
            // 
            this.SLvL.AutoSize = true;
            this.SLvL.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLvL.Location = new System.Drawing.Point(86, 366);
            this.SLvL.MinimumSize = new System.Drawing.Size(200, 100);
            this.SLvL.Name = "SLvL";
            this.SLvL.Size = new System.Drawing.Size(200, 100);
            this.SLvL.TabIndex = 5;
            this.SLvL.Tag = "Level";
            this.SLvL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Losses
            // 
            this.Losses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Losses.AutoSize = true;
            this.Losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Losses.Location = new System.Drawing.Point(135, 289);
            this.Losses.Name = "Losses";
            this.Losses.Size = new System.Drawing.Size(0, 18);
            this.Losses.TabIndex = 3;
            this.Losses.Tag = "Losses";
            // 
            // Wins
            // 
            this.Wins.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Wins.AutoSize = true;
            this.Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Wins.Location = new System.Drawing.Point(52, 289);
            this.Wins.Name = "Wins";
            this.Wins.Size = new System.Drawing.Size(0, 18);
            this.Wins.TabIndex = 3;
            this.Wins.Tag = "Wins";
            // 
            // LLusses
            // 
            this.LLusses.AutoSize = true;
            this.LLusses.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLusses.ForeColor = System.Drawing.Color.Red;
            this.LLusses.Location = new System.Drawing.Point(108, 259);
            this.LLusses.Name = "LLusses";
            this.LLusses.Size = new System.Drawing.Size(83, 30);
            this.LLusses.TabIndex = 2;
            this.LLusses.Text = "LOSSES";
            // 
            // LWins
            // 
            this.LWins.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LWins.AutoSize = true;
            this.LWins.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LWins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LWins.Location = new System.Drawing.Point(34, 259);
            this.LWins.Name = "LWins";
            this.LWins.Size = new System.Drawing.Size(66, 30);
            this.LWins.TabIndex = 2;
            this.LWins.Text = "WINS";
            // 
            // ISLogo
            // 
            this.ISLogo.Location = new System.Drawing.Point(25, 43);
            this.ISLogo.Name = "ISLogo";
            this.ISLogo.Size = new System.Drawing.Size(120, 120);
            this.ISLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ISLogo.TabIndex = 0;
            this.ISLogo.TabStop = false;
            this.ISLogo.Tag = "ProfileIcon";
            // 
            // IRankImage
            // 
            this.IRankImage.BackColor = System.Drawing.Color.Transparent;
            this.IRankImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.IRankImage.Location = new System.Drawing.Point(197, -24);
            this.IRankImage.Name = "IRankImage";
            this.IRankImage.Size = new System.Drawing.Size(200, 224);
            this.IRankImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IRankImage.TabIndex = 1;
            this.IRankImage.TabStop = false;
            this.IRankImage.Tag = "Emblem";
            this.IRankImage.Click += new System.EventHandler(this.IRankImage_Click);
            // 
            // SName
            // 
            this.SName.AutoSize = true;
            this.SName.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.ForeColor = System.Drawing.Color.Black;
            this.SName.Location = new System.Drawing.Point(17, 219);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(0, 45);
            this.SName.TabIndex = 1;
            this.SName.Tag = "SummonerName";
            // 
            // PMatchHistory
            // 
            this.PMatchHistory.BackColor = System.Drawing.Color.White;
            this.PMatchHistory.Controls.Add(this.flowLayoutPanel1);
            this.PMatchHistory.Location = new System.Drawing.Point(424, 25);
            this.PMatchHistory.Name = "PMatchHistory";
            this.PMatchHistory.Size = new System.Drawing.Size(1008, 520);
            this.PMatchHistory.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1008, 520);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(10)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1444, 561);
            this.Controls.Add(this.PMatchHistory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "  Bredly.gg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IRankImage)).EndInit();
            this.PMatchHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SLvL;
        private System.Windows.Forms.Label LLVL;
        private System.Windows.Forms.Label Losses;
        private System.Windows.Forms.Label Wins;
        private System.Windows.Forms.Label LLusses;
        private System.Windows.Forms.Label LWins;
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.PictureBox ISLogo;
        private System.Windows.Forms.PictureBox IRankImage;
        private System.Windows.Forms.Label LTier;
        private System.Windows.Forms.Label LRank;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PMatchHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MatcHisroy;
    }
}