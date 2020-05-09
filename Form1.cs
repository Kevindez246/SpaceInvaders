using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {

        Game game;
        List<Keys> keysPressed = new List<Keys>();
        public Form1()
        {
            InitializeComponent();
        }



        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            AnimationTimer.Enabled = true;
            AnimationTimer.Interval = 33;
            for (int i = 0; i < 3; i++)
            {
                //need to implement.
            }

            game.Twinkle();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            GameTimer.Interval = 10;

            game.Go();

            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(game.)
                    return;
                }

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (GameOver)
                if (e.KeyCode == Keys.S)
                    //code to reset the game and start the game timers
                    return;

            if (e.KeyCode == Keys.Space)
                game.FireShot();

            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);

            keysPressed.Add(e.KeyCode);

        }

    }
}


