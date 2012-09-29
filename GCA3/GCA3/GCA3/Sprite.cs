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

    public class Sprite
    {

        protected Vector2 position { get; set; }
        protected Vector2 veloctiy { get; set; }
        protected double rotation { get; set; }
        protected Texture2D image { get; set; }
        protected float scale { get; set; }
        protected Rectangle boundingBox { get; set; }
        protected SoundEffect hitSound { get; set; }
        protected bool alive { get; set; }
        protected int windowWidth { get; set; }
        protected int windowHeight { get; set; }


        public Sprite(GraphicsDevice graphics, Vector2 _position, Vector2 _velocity, double _rotation, Texture2D _image, float _scale, SoundEffect _hitSound, bool _alive, int _windowWidth, int _windowHeight)
        {
            position = _position;
            veloctiy = _velocity;
            rotation = _rotation;
            image = _image;
            scale = _scale;
            hitSound = _hitSound;
            alive = _alive;
            windowHeight = _windowHeight;
            windowWidth = _windowWidth;
        }


        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (alive)
            {
                spriteBatch.Draw(image, position, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            }
        }

    }
}
