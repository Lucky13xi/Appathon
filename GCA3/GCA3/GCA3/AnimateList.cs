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
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class AnimateList
    {

        public static Dictionary<string, Animate> animationList = new Dictionary<string, Animate>();
        public SpriteEffects spriteEffect { get; set; }
        public string CurrentAnimation { get; set; }

        public AnimateList()
        {

        }

        public void AddAnimation(String animationName, Animate animation)
        {
            animationList.Add(animationName, animation);
        }

        public void FaceLeft()
        {
            spriteEffect = SpriteEffects.FlipHorizontally;
        }

        public void FaceRight()
        {
            spriteEffect = SpriteEffects.None;
        }

        public void FlipVert()
        {
            spriteEffect = SpriteEffects.FlipVertically;
        }

        public void FlipVertBack()
        {
            spriteEffect = SpriteEffects.None;
        }


        public void Draw(SpriteBatch batch, Vector2 position, float scale, SpriteEffects spriteEffect)
        {
            if (animationList[CurrentAnimation].frameList.Count == 0 || animationList[CurrentAnimation].currentFrame < 0 ||
                animationList[CurrentAnimation].frameList.Count <= animationList[CurrentAnimation].currentFrame) return;

            batch.Draw(animationList[CurrentAnimation].frameList[animationList[CurrentAnimation].currentFrame].Frame, position, null, Color.White, 0.0f, Vector2.Zero,
                new Vector2(scale, scale), spriteEffect, 0.0f);
        }


        public void Draw(SpriteBatch batch, Vector2 position, float scale, SpriteEffects spriteEffect, float rotation)
        {
            if (animationList[CurrentAnimation].frameList.Count == 0 || animationList[CurrentAnimation].currentFrame < 0 ||
                animationList[CurrentAnimation].frameList.Count <= animationList[CurrentAnimation].currentFrame) return;

            batch.Draw(animationList[CurrentAnimation].frameList[animationList[CurrentAnimation].currentFrame].Frame, position, null, Color.White, rotation, Vector2.Zero,
                new Vector2(scale, scale), spriteEffect, 0.0f);
        }


        public void Draw(SpriteBatch batch, Vector2 position, float scale, SpriteEffects spriteEffect, float rotation, int length)
        {
            if (animationList[CurrentAnimation].frameList.Count == 0 || animationList[CurrentAnimation].currentFrame < 0 ||
                animationList[CurrentAnimation].frameList.Count <= animationList[CurrentAnimation].currentFrame) return;

            batch.Draw(animationList[CurrentAnimation].frameList[animationList[CurrentAnimation].currentFrame].Frame, position, new Rectangle((int)position.X, (int)position.Y, length, animationList[CurrentAnimation].frameList[animationList[CurrentAnimation].currentFrame].Frame.Height), Color.White, rotation, Vector2.Zero,
                new Vector2(scale, scale), spriteEffect, 0.0f);
        }
    }
}
