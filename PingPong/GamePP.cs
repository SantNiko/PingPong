using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class GamePP : UserControl
    {

        public int points
        {
            get { return mPoints; }
            set { mPoints = value; }
        }

        public GamePP()
        {
            InitializeComponent();
            AllowDrop = true;
        }
        public void setTimer(Timer time)
        {
            this.time = time;
            time.Tick += new System.EventHandler(time_Tick);
        }

        public void startGame()
        {
            ball.Left = pScreen.Width / 2;
            ball.Top = pScreen.Height / 2;
            time.Enabled = true;
        }
        public void continueGame() {
            time.Enabled = true;
        }
        public void pauseGame() {
            time.Enabled = false;
        }
        public void endGame() {
            time.Enabled = false;
        }

        private int mPoints;

        private void time_Tick(object sender, EventArgs e)
        {
            rellenarDatos();
            moveBall();
            movePlayer();
        }

        private void movePlayer()
        {
            pbPlayer.Left = Cursor.Position.X - (pbPlayer.Width / 2);
        }

        private void moveBall()
        {
            colisionBordes();
            colisionesPlayer();

            ball.Left += ball.speedLeft;
            ball.Top += ball.speedTop;
        }

        private void colisionesPlayer()
        {
            if (ball.Bottom >= pbPlayer.Top && ball.Bottom <= pbPlayer.Bottom && ball.Left >= pbPlayer.Left && ball.Right <= pbPlayer.Right)
            {
                ball.hit(Ball.COL_TOP);
            }
        }

        private void colisionBordes()
        {
            if (ball.Top <= 0)
            {
                ball.hit(Ball.COL_TOP);
            }
            else
            {
                if (ball.Top >= pScreen.Height)
                {
                    ball.hit(Ball.COL_BOTTOM);
                    endGame();
                }
            }
            if (ball.Left <= 0)
            {
                ball.hit(Ball.COL_LEFT);
            }
            else
            {
                if (ball.Left >= pScreen.Width)
                {
                    ball.hit(Ball.COL_RIGHT);
                }
            }
        }

        private void rellenarDatos() {
            lblCursorY.Text = Cursor.Position.Y+"";
            llblCursorX.Text = Cursor.Position.X + "";
            lblBallLeft.Text = ball.Left + "";
            lblBallTop.Text = ball.Top + "";
            lblPlayerLeft.Text = pbPlayer.Left + "";
            lblPlayerTop.Text = pbPlayer.Top + "";
            lblScreenLeft.Text = pScreen.Left + "";
            lblScreenWidth.Text = pScreen.Width + "";
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            drgevent.Effect = DragDropEffects.Move;
        }
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            string colorName = drgevent.Data.GetData(DataFormats.StringFormat) as string;
            if (colorName == null) { return; }
            System.Drawing.Point mousept = PointToClient(new Point(drgevent.X, drgevent.Y));

            Ball b = new PingPong.Ball();
            b.BackColor = Color.FromName(colorName);
            b.Location = mousept;
            b.Size = new System.Drawing.Size(20, 20);
            b.speedLeft = 4;
            b.speedTop = 4;
            b.Controls.Add(this.ball);
        }
    }
}
