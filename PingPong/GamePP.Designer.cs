namespace PingPong
{
    partial class GamePP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.llblCursorX = new System.Windows.Forms.Label();
            this.lblCursorY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBallTop = new System.Windows.Forms.Label();
            this.lblBallLeft = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlayerLeft = new System.Windows.Forms.Label();
            this.lblPlayerTop = new System.Windows.Forms.Label();
            this.lblScreenWidth = new System.Windows.Forms.Label();
            this.lblScreenLeft = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ball = new BallPP.Ball();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.pScreen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlayer.BackColor = System.Drawing.Color.White;
            this.pbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlayer.Location = new System.Drawing.Point(98, 484);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(349, 10);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pScreen
            // 
            this.pScreen.Controls.Add(this.ball);
            this.pScreen.Controls.Add(this.panel1);
            this.pScreen.Controls.Add(this.pbPlayer);
            this.pScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pScreen.Location = new System.Drawing.Point(0, 0);
            this.pScreen.Name = "pScreen";
            this.pScreen.Size = new System.Drawing.Size(602, 535);
            this.pScreen.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(60, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 118);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblScreenLeft, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblScreenWidth, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCursorY, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.llblCursorX, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBallLeft, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBallTop, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerLeft, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerTop, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cursor";
            // 
            // llblCursorX
            // 
            this.llblCursorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCursorX.ForeColor = System.Drawing.Color.White;
            this.llblCursorX.Location = new System.Drawing.Point(99, 0);
            this.llblCursorX.Name = "llblCursorX";
            this.llblCursorX.Size = new System.Drawing.Size(90, 28);
            this.llblCursorX.TabIndex = 1;
            // 
            // lblCursorY
            // 
            this.lblCursorY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursorY.ForeColor = System.Drawing.Color.White;
            this.lblCursorY.Location = new System.Drawing.Point(195, 0);
            this.lblCursorY.Name = "lblCursorY";
            this.lblCursorY.Size = new System.Drawing.Size(90, 28);
            this.lblCursorY.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ball";
            // 
            // lblBallTop
            // 
            this.lblBallTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBallTop.ForeColor = System.Drawing.Color.White;
            this.lblBallTop.Location = new System.Drawing.Point(195, 28);
            this.lblBallTop.Name = "lblBallTop";
            this.lblBallTop.Size = new System.Drawing.Size(90, 28);
            this.lblBallTop.TabIndex = 4;
            // 
            // lblBallLeft
            // 
            this.lblBallLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBallLeft.ForeColor = System.Drawing.Color.White;
            this.lblBallLeft.Location = new System.Drawing.Point(99, 28);
            this.lblBallLeft.Name = "lblBallLeft";
            this.lblBallLeft.Size = new System.Drawing.Size(90, 28);
            this.lblBallLeft.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payer";
            // 
            // lblPlayerLeft
            // 
            this.lblPlayerLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerLeft.ForeColor = System.Drawing.Color.White;
            this.lblPlayerLeft.Location = new System.Drawing.Point(99, 56);
            this.lblPlayerLeft.Name = "lblPlayerLeft";
            this.lblPlayerLeft.Size = new System.Drawing.Size(90, 28);
            this.lblPlayerLeft.TabIndex = 7;
            // 
            // lblPlayerTop
            // 
            this.lblPlayerTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTop.ForeColor = System.Drawing.Color.White;
            this.lblPlayerTop.Location = new System.Drawing.Point(195, 56);
            this.lblPlayerTop.Name = "lblPlayerTop";
            this.lblPlayerTop.Size = new System.Drawing.Size(90, 28);
            this.lblPlayerTop.TabIndex = 8;
            // 
            // lblScreenWidth
            // 
            this.lblScreenWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenWidth.ForeColor = System.Drawing.Color.White;
            this.lblScreenWidth.Location = new System.Drawing.Point(195, 84);
            this.lblScreenWidth.Name = "lblScreenWidth";
            this.lblScreenWidth.Size = new System.Drawing.Size(90, 28);
            this.lblScreenWidth.TabIndex = 9;
            // 
            // lblScreenLeft
            // 
            this.lblScreenLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenLeft.ForeColor = System.Drawing.Color.White;
            this.lblScreenLeft.Location = new System.Drawing.Point(99, 84);
            this.lblScreenLeft.Name = "lblScreenLeft";
            this.lblScreenLeft.Size = new System.Drawing.Size(90, 28);
            this.lblScreenLeft.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "Screen";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Location = new System.Drawing.Point(259, 206);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.speedLeft = 4;
            this.ball.speedTop = 4;
            this.ball.TabIndex = 3;
            // 
            // GamePP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pScreen);
            this.Name = "GamePP";
            this.Size = new System.Drawing.Size(602, 535);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.pScreen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Panel pScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblScreenLeft;
        private System.Windows.Forms.Label lblScreenWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCursorY;
        private System.Windows.Forms.Label llblCursorX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBallLeft;
        private System.Windows.Forms.Label lblBallTop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPlayerLeft;
        private System.Windows.Forms.Label lblPlayerTop;
        private Ball ball;
    }
}
