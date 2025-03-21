
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Slut_projekt_1
{
    public class Bilar
    {
        private Texture2D texture;
        private Vector2 position;
        private Rectangle hitbox;
        public Rectangle Hitbox{
            get{return hitbox;}
        }

        public Bilar(Texture2D texture, Vector2 position, int pixelSize){
            this.texture = texture;
            this.position = position;
            hitbox = new Rectangle((int)position.X, (int)position.Y, pixelSize, pixelSize);
        }
    }
}