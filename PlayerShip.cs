using System.Drawing;

namespace SpaceInvaders
{
    class PlayerShip
    {
        public Point Location;
        public bool Alive;
        public Bitmap image;

        public Rectangle Area
        {

            get
            {
                return new Rectangle(location, image.Size);
            }
        }

    }
}
