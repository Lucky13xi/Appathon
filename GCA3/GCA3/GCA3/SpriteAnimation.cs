using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace GCA3
{
    public class SpriteAnimation : Sprite
    {
        public SpriteAnimation(GraphicsDevice graphics, Vector2 _position, Vector2 _velocity, double _rotation, Texture2D _image, float _scale, SoundEffect _hitSound, bool _alive, int _windowWidth, int _windowHeight)
            :base (graphics, _position, _velocity, _rotation, _image, _scale, _hitSound, _alive, _windowWidth, _windowHeight)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (alive)
            {
                spriteBatch.Draw(image, position, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            }
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
