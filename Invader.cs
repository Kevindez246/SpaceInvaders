using System.Drawing;

namespace SpaceInvaders
{
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        public Point Location { get; set; }

        public ShipType InvaderType { get; set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(location, image.Size);
            }
        }

        public int Score { get; set; }

        /// <summary>
        /// Instantiates a new Invader Object
        /// </summary>
        /// <param name="invaderType"></param>
        /// <param name="location"></param>
        /// <param name="score"></param>
        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage(0);
        }


        public void Move(Direction direction)
        {

        }


        public void Draw(Graphics g, int animationCell)
        {


        }

        private Bitmap InvaderImage(int animationcell)
        {

        }

        public enum ShipType
        {
            Bug,
            Saucer,
            Satellite,
            SpaceShip,
            Star,
        }

    }
}
