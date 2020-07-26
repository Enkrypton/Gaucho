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
    public class Bg : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var bg = GetLayer("Bg").CreateSprite("yr.jpg");
            var d = GetLayer("Bg").CreateSprite("sb/lazy_dim.png");
            var f = GetLayer("Bg").CreateSprite("sb/lazy_flash.png");
            var v = GetLayer("Bg").CreateSprite("sb/vig.png");
            v.Scale(0,480.0/1080);
            bg.Scale(0, 480.0/900);
            d.Scale(0, 480.0/900);
            f.Scale(0, 480.0/900);
            f.Fade(0,0);

            v.Fade(0,5696,0,1);
            v.Fade(5696,67090,1,1);
            v.Fade(67091,67092,0,0);

            d.Fade(OsbEasing.OutExpo,8138,8487,0.7,1);
            d.Fade(8487,8661,1,0.5);

            d.Fade(0,8138,0.7,0.7); 
            d.Fade(8661,22440,0.5,0.5);
            d.Fade(22440,44766,0.3,0.3);
            d.Fade(44766,47556,0.5,0.7);
            d.Fade(47556,55928,0.7,0.7);
            d.Fade(55928,67091,0.7,1);
            d.Fade(67092,0);

            f.Fade(67091,67091+300,1,0);

            d.Fade(111742,114533,0,0.5);
            d.Fade(114533,167556,0.5,0.5);
            d.Fade(167556,178719,0.5,1);
            d.Fade(178720,0);

            f.Fade(178719,178719+300,1,0);
            
            bg.Fade(0,5696,0,1);
            bg.Fade(0,245696,1,1);

            d.Fade(223370,227556,0,0.5);
            d.Fade(227556,245696,0.5,0.5);
            bg.Fade(245696,245696+300,0.5,0);
        }
    }
}
