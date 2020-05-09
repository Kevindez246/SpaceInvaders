using System;
using System.Collections.Generic;
using System.Drawing;

namespace SpaceInvaders
{
    class Game
    {

        public event EventHandler GameOver;

        private int score = 0;
        private int livesleft = 2;
        private int wave = 0;
        private int framesskipped = 0;

        private Rectangle boundaries;
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;
        private List<Shot> playershots;
        private List<Shot> invadershots;

        private PlayerShip playership;
        private Stars stars;


        public void Twinkle()
        {

        }

        public void Go()
        {

        }

        public void FireShot()
        {

        }

        public void MovePlayer(Direction direction)
        {
            //implement
        }

        public void Draw(Graphics g, int animationCell)
        {


        }




        public enum Direction
        {
            Left,
            Right,
            Up,
            Down,

        }
    }


}
