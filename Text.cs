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
    public class Text : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            SongName(115,2731,"gaucho");
            SongName(2905,5347,"culprate & joe ford");
            SongName(11277,13894, "beatmap by: scubdomino");
            SongName(14068,16684,Beatmap.Name);
            SongName(16859,19475,"storyboarded by: enkrypton");
        }
        void SongName(int Start, int End, string Name)
        {
            var font = LoadFont("sb/letters/" + Start, new FontDescription()
            {
                FontPath = "OratorStd.otf",
                FontSize = 48,
                Color = Color4.White,
                Padding = Vector2.Zero,
                //FontStyle = FontStyle.Regular,
            });
            GenerateSongName(font, false, Start, End, Name);
        }
        public void GenerateSongName(FontGenerator font, bool additive, int Start, int End, string Sentence)
        {
            double Beat = Beatmap.GetTimingPointAt(Start).BeatDuration;       
            float letterX = 320;
            var letterY = 220;
            var lineWidth = 0f;
            var lineHeight = 0f;
            float FontScale = 0.5f;
            int Delay = 60;
            OsbOrigin Origin = OsbOrigin.Centre;

            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                lineWidth += texture.BaseWidth * FontScale;
                lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
            }
            var letterCenter = letterX;
            letterX = letterX - lineWidth * 0.5f;
            
            foreach (var letter in Sentence)
            {
                var texture = font.GetTexture(letter.ToString());
                if (!texture.IsEmpty)
                {
                    var position = new Vector2(letterX, letterY)
                        + texture.OffsetFor(Origin) * FontScale;

                    var sprite = GetLayer("Sentence").CreateSprite(texture.Path, Origin, position);
                    
                    sprite.Scale(OsbEasing.OutBack, Start  + Delay, Start  + Delay + 300, 0, FontScale);
                    sprite.Fade(Start  + Delay, Start  + Delay + 300, 0, 1);
                    sprite.Fade(End, End+300, 1, 0);

                    Delay += 60;
                }
                letterX += texture.BaseWidth * FontScale;
            }
        }
    }
}
