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
        
        public void Sprite(GraphicsDevice graphics, Vector2 _position, Vector2 _velocity, double _rotation, Texture2D _image, float _scale, SoundEffect _hitSound, bool _alive)
        {

            position = _position;
            veloctiy = _velocity;
            rotation = _rotation;



        }


        public override void Update(GameTime gameTime)
        {

        }
    }
}
