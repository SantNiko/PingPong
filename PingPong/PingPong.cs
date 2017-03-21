using PingPong.ResourcesLocalized;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class frPingPong : Form
    {

        public frPingPong()
        {
            InitializeComponent();
            gamePP1.setTimer(this.time);
            gamePP1.startGame();
            aplicarIdioma("");
        }

        private void aplicarIdioma(string idioma)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(idioma);
            this.msMenu.Text = StringResources.msMenu;
            this.msLenguages.Text = StringResources.msLenguages;
            this.msLEnglish.Text = StringResources.msLEnglish;
            this.msLSpanish.Text = StringResources.msLSpanish;
            this.msMNewGame.Text = StringResources.msMNewGame;
        }

        private void frPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            Label a = new Label();
            a.Text = "pausa";
            this.pInfo.Controls.Add(a);
            if (e.KeyCode == Keys.Escape) {

                gamePP1.pauseGame();
            }
        }

        private void frPingPong_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frPingPong_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void msLEnglish_Click_1(object sender, EventArgs e)
        {
            aplicarIdioma("ES-US");
        }

        private void msLSpanish_Click_1(object sender, EventArgs e)
        {
            aplicarIdioma("es-ES");
        }

        private void msMNewGame_Click(object sender, EventArgs e)
        {
            gamePP1.startGame();
        }
    }
}
