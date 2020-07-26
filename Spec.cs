using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Spec : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    e(67091,89417);
            eb(178719,201045);
            et(201045,212208);
            ef(212208,222149);
            
        }

        void e(int Start, int End)
        {
            int centreX = 0;
            int centreY = 240;
            Vector2 Position = new Vector2(centreX,centreY);
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            int BarCount = 44;
            for(int i = 0; i < BarCount; i++)
            {
                 //generate
                var sprite = GetLayer("spec").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(Position.X + i * 15, Position.Y));
                /*int spacing = 15;
                int spacingY = 7;
                double rawDist = centreX - (spacing * BarCount / 2.0);
                double rawDistY = (centreY - (spacingY * (BarCount / 2.0) / 2.0));
                sprite.MoveX(Start, End, rawDist + spacing*i, rawDist + spacing*i);
                sprite.MoveY(Start, End, rawDistY + (spacingY / 2)*i, rawDistY + (spacingY / 2)*i);
                sprite.Rotate(Start, End, Math.Atan2(((centreY - (spacingY * (BarCount / 2.0) / 2.0))
                - (centreY + (spacingY * (BarCount / 2.0) / 2.0))), ((centreX - (spacing * BarCount / 2.0))
                - (centreX + (spacing * BarCount / 2.0)))), Math.Atan2(((centreY - (spacingY * (BarCount / 2.0) / 2.0))
                - (centreY + (spacingY * (BarCount / 2.0) / 2.0))), ((centreX - (spacing * BarCount / 2.0))
                - (centreX + (spacing * BarCount / 2.0))))); */

                for(var time = (double)Start; time < End; time += beat*8)
                {
                var scaleY = Random(10, 100);
                var scaleX = 6; //bar width
                if (time <= End - beat *8)
                sprite.ScaleVec(OsbEasing.OutElastic, time, time + beat*2, scaleX, 0, scaleX, scaleY);
                sprite.ScaleVec(OsbEasing.InExpo, time + beat*2, time + beat*8, scaleX, scaleY, scaleX, 0);
                if (time > End - beat){
                    sprite.Fade(End, End + beat,1,0);
                    sprite.ScaleVec(OsbEasing.OutExpo, time, time + beat*2, scaleX, 0, 0, scaleY*4);
                }
                }
            }
        }

        void et(int Start, int End)
        {
            int centreX = 0;
            int centreY = 240;
            Vector2 Position = new Vector2(centreX,centreY);
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            int BarCount = 44;
            for(int i = 0; i < BarCount; i++)
            {
                 //generate
                var sprite = GetLayer("spec").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(Position.X + i * 15, Position.Y));
                for(var time = (double)Start; time < End; time += beat*8)
                {
                var scaleY = Random(10, 100);
                var scaleX = 6; //bar width
                if (time <= End - beat *8){
                sprite.ScaleVec(OsbEasing.OutElastic, time, time + beat*2, scaleX, 0, scaleX, scaleY);
                sprite.ScaleVec(OsbEasing.InExpo, time + beat*2, time + beat*8, scaleX, scaleY, scaleX, 0);
                    }
                }
            }
        }
        void eb(int Start, int End)
        {
            int centreX = 0;
            int centreY = 240;
            Vector2 Position = new Vector2(centreX,centreY);
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            int BarCount = 44;
            for(int i = 0; i < BarCount; i++)
            {
                 //generate
                var sprite = GetLayer("spec").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(Position.X + i * 15, Position.Y));
                for(var time = (double)Start; time < End; time += beat*8)
                {
                var scaleY = Random(10, 100);
                var scaleX = 6; //bar width
                if (time <= End - 698)
                sprite.ScaleVec(OsbEasing.OutElastic, time, time + beat*2, scaleX, 0, scaleX, scaleY);
                sprite.ScaleVec(OsbEasing.InExpo, time + beat*2, time + beat*8, scaleX, scaleY, scaleX, 0);
                if (time > End - 698){
                    sprite.Fade(End-698, End - 610,1,0);
                    sprite.Fade(End - 610, End - 522,0,1);

                    sprite.Fade(End - 522, End - 435,1,0);
                    sprite.Fade(End - 435, End - 349,0,1);

                    sprite.Fade(End - 349, End - 262,1,0);
                    sprite.Fade(End - 262, End - 175,0,1);

                    sprite.Fade(End - 175, End - 87,1,0);
                    //sprite.Fade(End - 87, End,0,1);
                }
                }
            }
        }

        void ef(int Start, int End)
        {
            int centreX = 0;
            int centreY = 240;
            Vector2 Position = new Vector2(centreX,centreY);
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            int BarCount = 44;
            for(int i = 0; i < BarCount; i++)
            {
                 //generate
                var sprite = GetLayer("spec").CreateSprite("sb/pixel.png", OsbOrigin.Centre, new Vector2(Position.X + i * 15, Position.Y));

                for(var time = (double)Start; time < End; time += beat*4)
                {
                var scaleY = Random(10, 100);
                var scaleX = 6; //bar width
                if (time <= End - beat*4)
                sprite.ScaleVec(OsbEasing.OutElastic, time, time + beat*2, scaleX, 0, scaleX, scaleY);
                sprite.ScaleVec(OsbEasing.InExpo, time + beat*2, time + beat*4, scaleX, scaleY, scaleX, 0);
                if (time > End - beat*4){
                    sprite.Fade(End, End + beat/2,1,0);
                    sprite.ScaleVec(OsbEasing.OutExpo, time, time + beat*2, scaleX, 0, 0, scaleY*4);
                }
                }
            }
        }
    }
}
