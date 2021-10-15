using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    class Game
    {
        public Keys Direction { get; set; }
        public Keys Arrow { get; set; }

        private Timer Frame{ get; set; }
        private Panel PnTela { get; set; }
        private Label LbPontuacao { get; set; }
        private int Pontos { get; set; }
        private Food Food { get; set; }
        private Snake Snake { get; set; }

        private Bitmap offScreenBitmap { get; set; }
        private Graphics bitmapGraph { get; set; }
        private Graphics screenGraph { get; set; }

        public Game(ref Label label, ref Timer timer, ref Panel panel)
        {
            PnTela = panel;
            LbPontuacao = label;
            Frame = timer;
            offScreenBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Food = new Food();
            Direction = Keys.Left;
            Arrow = Direction;
            Pontos = 0;


        }

        public void StartGame()
        {
            Snake.Reset();
            Food.CreateFood();
            Direction = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = PnTela.CreateGraphics();
            Frame.Enabled = true;
        }

        public void Tick()
        {
            if (((Arrow == Keys.Left) && (Direction != Keys.Right)) ||
                ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
                ((Arrow == Keys.Down) && (Direction != Keys.Up)) ||
                ((Arrow == Keys.Up) && (Direction != Keys.Down)))
            {
                Direction = Arrow;
            }

            switch (Direction)
            {
                case Keys.Up:
                    Snake.Up();
                    break;
                case Keys.Down:
                    Snake.Down();
                    break;
                case Keys.Left:
                    Snake.Left();
                    break;
                case Keys.Right:
                    Snake.Rigth();
                    break;
            }

            bitmapGraph.Clear(Color.White);

            bitmapGraph.DrawImage(Properties.Resources.branca_de_neve_cute_maca_06, (Food.Location.X * 15), (Food.Location.Y * 15), 15, 15);

            bool gameOver = false;

            for (int i = 0; i < Snake.Length; i++)
            {
                if (i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(Color.Black), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(Color.Red), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15);
                }

                if ((Snake.Location[i] == Snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }

                screenGraph.DrawImage(offScreenBitmap, 0, 0);
                CheckCollision();

                if (gameOver)
                {
                    GameOver();
                }
            }
        }

        public void CheckCollision()
        {
            if (Snake.Location[0] == Food.Location)
            {
                Snake.Eat();
                Food.CreateFood();
                Pontos += 1;
                LbPontuacao.Text = "PONTOS: " + Pontos;
            }
        }
        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            LbPontuacao.Text = "PONTOS: 0";
            Pontos = 0;
            MessageBox.Show("Game Over");
        }


    }

}
