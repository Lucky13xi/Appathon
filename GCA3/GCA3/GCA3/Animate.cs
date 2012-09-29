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
    public struct FrameList
    {
        public Texture2D Frame { get; set; }
    }

    public class Animate
    {

        private float CurTime { get; set; }
        private float TimeDif { get; set; }
        private bool playing { get; set; }
        public int currentFrame { get; set; }
        private bool loop { get; set; }
        private bool stop { get; set; }
        private int start { get; set; }
        private int end { get; set; }
        public List<FrameList> frameList;


        public Animate()
        {
            frameList = new List<FrameList>();
 
        }

        public void AddFrame(Texture2D _image)
        {
            FrameList frame = new FrameList();
            frame.Frame = _image;

            frameList.Add(frame);
        }

        public void Play(int _start, int _end, float _seconds, bool _loop)
        {
            if (playing)
                return;

            stop = false;

            if (loop)
                return;

            if (_loop)
            {
                loop = true;
            }
            else
            {
                loop = _loop;
                playing = true;
            }

            this.start = start;
            this.end = end;

            currentFrame = start;

            float diff = (float)end - (float)start;

            TimeDif = _seconds / diff;
        }

        //public void PlayOnce()
        //{
        //    if (playing)
        //        return;

        //    GoToFrame(start);
        //    stop = false;
        //    loop = false;
        //    playing = true;

        //    this.start = start;
        //    this.stop = stop;

        //    float diff = (float)end - (float)start;

        //    TimeDif = _seconds / diff;
        //}

        public void Stop()
        {
            if (playing)
                return;

            stop = true;
            loop = false;
            CurTime = 0.0f;
            TimeDif = 0.0f;

        }

        public void GoToFrame(int _frame)
        {
            if (playing)
                return;

            if (_frame < 0 || _frame >= frameList.Count)
                return;

            currentFrame = _frame;
        }

        public override void Update(GameTime gameTime)
        {
            TimeDif += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (CurTime > TimeDif)
            {
                CurTime = 0.0f;
                currentFrame++;

                if (loop)
                {
                    if (currentFrame > end)
                        currentFrame = start;
                }
                if (currentFrame > end)
                {
                    currentFrame = end;
                    playing = false;
                    stop = true;
                }
            }
        }
    }
}
