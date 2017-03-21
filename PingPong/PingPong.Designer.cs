namespace PingPong
{
    partial class frPingPong
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
            this.components = new System.ComponentModel.Container();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.ms = new System.Windows.Forms.MenuStrip();
            this.msMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msMNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msLenguages = new System.Windows.Forms.ToolStripMenuItem();
            this.msLEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.msLSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ball3 = new BallPP.Ball();
            this.ball2 = new BallPP.Ball();
            this.ball1 = new BallPP.Ball();
            this.gamePP1 = new PingPong.GamePP();
            this.ms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 1;
            // 
            // ms
            // 
            this.ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenu,
            this.msLenguages});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1038, 28);
            this.ms.TabIndex = 1;
            this.ms.Text = "menuStrip1";
            // 
            // msMenu
            // 
            this.msMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMNewGame});
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(58, 24);
            this.msMenu.Text = "Menu";
            // 
            // msMNewGame
            // 
            this.msMNewGame.Name = "msMNewGame";
            this.msMNewGame.Size = new System.Drawing.Size(181, 26);
            this.msMNewGame.Text = "New Game";
            // 
            // msLenguages
            // 
            this.msLenguages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLEnglish,
            this.msLSpanish});
            this.msLenguages.Name = "msLenguages";
            this.msLenguages.Size = new System.Drawing.Size(92, 24);
            this.msLenguages.Text = "Lenguages";
            // 
            // msLEnglish
            // 
            this.msLEnglish.Name = "msLEnglish";
            this.msLEnglish.Size = new System.Drawing.Size(181, 26);
            this.msLEnglish.Text = "English";
            this.msLEnglish.Click += new System.EventHandler(this.msLEnglish_Click_1);
            // 
            // msLSpanish
            // 
            this.msLSpanish.Name = "msLSpanish";
            this.msLSpanish.Size = new System.Drawing.Size(181, 26);
            this.msLSpanish.Text = "Spanish";
            this.msLSpanish.Click += new System.EventHandler(this.msLSpanish_Click_1);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.ball3);
            this.panel1.Controls.Add(this.ball2);
            this.panel1.Controls.Add(this.ball1);
            this.panel1.Location = new System.Drawing.Point(0, 719);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 105);
            this.panel1.TabIndex = 2;
            // 
            // ball3
            // 
            this.ball3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball3.Location = new System.Drawing.Point(219, 17);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(61, 62);
            this.ball3.speedLeft = 4;
            this.ball3.speedTop = 4;
            this.ball3.TabIndex = 3;
            // 
            // ball2
            // 
            this.ball2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball2.Location = new System.Drawing.Point(111, 17);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(61, 62);
            this.ball2.speedLeft = 4;
            this.ball2.speedTop = 4;
            this.ball2.TabIndex = 2;
            // 
            // ball1
            // 
            this.ball1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball1.Location = new System.Drawing.Point(12, 17);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(61, 62);
            this.ball1.speedLeft = 4;
            this.ball1.speedTop = 4;
            this.ball1.TabIndex = 1;
            // 
            // gamePP1
            // 
            this.gamePP1.AllowDrop = true;
            this.gamePP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamePP1.BackColor = System.Drawing.Color.Black;
            this.gamePP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePP1.Location = new System.Drawing.Point(0, 31);
            this.gamePP1.Name = "gamePP1";
            this.gamePP1.points = 0;
            this.gamePP1.Size = new System.Drawing.Size(1038, 682);
            this.gamePP1.TabIndex = 0;
            // 
            // frPingPong
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 824);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamePP1);
            this.Controls.Add(this.ms);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.ms;
            this.Name = "frPingPong";
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frPingPong_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frPingPong_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frPingPong_MouseMove);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer time;
        private GamePP gamePP1;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem msMenu;
        private System.Windows.Forms.ToolStripMenuItem msMNewGame;
        private System.Windows.Forms.ToolStripMenuItem msLenguages;
        private System.Windows.Forms.ToolStripMenuItem msLEnglish;
        private System.Windows.Forms.ToolStripMenuItem msLSpanish;
        private System.Windows.Forms.Panel panel1;
        private BallPP.Ball ball3;
        private BallPP.Ball ball2;
        private BallPP.Ball ball1;
    }
}

