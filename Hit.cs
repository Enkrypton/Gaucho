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
    public class Hit : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    //Small1(115,8138);
            //Small1(8487,21045);
            Rb(21045,21917);
            Rbs();
            Small2(22440,44766);
            lr();
            Small1(67091,89417);
            Big();
            Small1(89417,100492);
            Small2(100580,111655);  
            Tr();  
            Td(88719); Td(89068);
            Small2(122905,128399);
            Small1(128487,156394);
            Td(183952); Td(195115); Td(206277); Td(217440);
            Small2(178719,199998);
            Td(200347);
            Small2(201045,222324);
            Small1(224068,245173);
            Td(245347);
        }
        //COLORS SUBJECT TO CHANGE
        void Small1(int StartTime, int EndTime) //0.5 opacity
        {
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime)
                    continue;

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/hl.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.5, 0);

            }
        }

        void Small2(int StartTime, int EndTime) //1 opacity
        {
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime)
                    continue;

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/hl.png", OsbOrigin.Centre, hitobject.Position);
                //hitlight.ColorHsb(hitobject.StartTime, 54,1,0.9);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);

            }
        }
        void Rb(int StartTime, int EndTime) //Color 1: White blur ring
        {
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime)
                    continue;

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/rb.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.25, 0.25 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);

            }
        }

        void Rbs(){ //single use blur ring used for "ees" and non-intense "backs"
        int t = 8;
        int t2 = 7;
        int t3 = 9;
            List<int> times = new List<int>();
            for (int i = 0; i < t3; i++){
                times.Add(22440 + 2791*i);
            }
            for (int i = 0; i < t; i++){
                times.Add(23835 + 2791*i);
            }
            for (int i = 0; i < t; i++){
                times.Add(135463 + 2791*i);
            }
            //extra "eees"
            times.Add(27149); times.Add(32731);
            times.Add(144359); times.Add(156394);

            //spectrum "ees"
            for (int i = 0; i < t; i++){
                times.Add(68487 + 2791*i);
            }
            //extra spectrum "ees"
            times.Add(71801); times.Add(77382); times.Add(82963);

            //build up final "ees"
            times.Add(111219);

            //small distorts 
            for (int i = 0; i < t2; i++){
                times.Add(114533 + 2791*i);
            }

            //calm part 2
            for (int i = 0; i < t2; i++){
                times.Add(134068 + 2791*i);
            }

            times.Add(132673); times.Add(133196);
            
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach(var StartTime in times){    
                if (StartTime >= hitobject.StartTime - 5 && StartTime <= hitobject.StartTime + 5){

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/rb.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.3, 0.3 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                }
                }
            }
        }
        void lr() //single /skinny ring
        {
            List<int> times = new List<int>(); 
            int t = 9;
            for (int i = 0; i < t; i++){
                times.Add(22091 + 2791*i);
            }
            for (int i = 0; i < t; i++){
                times.Add(136510 + 2791*i);
            }
            //build up "back"
            int t2 = 4;
            for (int i = 0; i < t2; i++){
                times.Add(106161 + 2791/2*i);
            }
            //build up final 
            times.Add(111394);

            times.Add(217789); times.Add(219184); times.Add(220580); times.Add(221975);
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach(var StartTime in times){
                if (StartTime >= hitobject.StartTime - 5 && StartTime <= hitobject.StartTime + 5){

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/lr.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.3, 0.3 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                }
                }
            }
        }
        void Tr(){ //thick ring, used for non intense "backs" during build ups only
        
            //build up part
            int t = 4;
            List<int> times = new List<int>();
            for (int i = 0; i < t; i++){
                times.Add(100580 + 2791/2*i);
            }

            times.Add(213603); times.Add(214998); times.Add(216394);
            var hitobjectLayer = GetLayer("Hit");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach(var StartTime in times){
                if (StartTime >= hitobject.StartTime - 5 && StartTime <= hitobject.StartTime + 5){

                var hitlight = GetLayer("Hit").CreateSprite("sb/eff/r.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.3, 0.3 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                }
                }
            }
        }
        void Td(int now){ //Td stands for Triangle Distort btw. Used on distored-ish unique sounds
            foreach (var hitobject in Beatmap.HitObjects)
            {                
                if (now >= hitobject.StartTime - 5 && now <= hitobject.StartTime + 5){

                var t1 = GetLayer("Hit").CreateSprite("sb/eff/t.png", OsbOrigin.Centre, hitobject.Position);
                    if (hitobject is OsuSlider){
                t1.Scale(OsbEasing.OutBack, hitobject.StartTime, hitobject.EndTime+300,0,0.4);
                t1.Scale(hitobject.EndTime+300, hitobject.EndTime+350,0.4,0);
                t1.Fade(hitobject.EndTime+200, hitobject.EndTime+300,1,0);
                t1.Rotate(hitobject.StartTime, hitobject.EndTime+500,0,2*Math.PI);          
                    }
                    else if (hitobject is OsuCircle){
                t1.Scale(OsbEasing.OutBack, hitobject.StartTime, hitobject.EndTime+300+174,0,0.4);
                t1.Scale(hitobject.EndTime+300+174, hitobject.EndTime+350+174,0.4,0);
                t1.Fade(hitobject.EndTime+200, hitobject.EndTime+300+174,1,0);
                t1.Rotate(hitobject.StartTime, hitobject.EndTime+500+174,0,2*Math.PI);
                    }    
                }
            }
        }

        void Big(){ //main distorts
            var beat = Beatmap.GetTimingPointAt(66917).BeatDuration;
            int ti = 8;
            int s = 67091;
            List<int> times = new List<int>();
            for (int i = 0; i < ti; i++){
                times.Add(s + 2791*i);
            }
            times.Add(89417); times.Add(111742);

            int s2 = 178719;
            for (int i = 0; i < ti; i++){
                times.Add(s2 + 2791*i);
            }
            times.Add(201045); times.Add(206626);
            times.Add(212208); times.Add(217789);

            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach (var StartTime in times)
                {
                    if (StartTime >= hitobject.StartTime - 5 && StartTime <= hitobject.StartTime + 5)
                    {
                        var big = GetLayer("Hit").CreateSprite("sb/eff/r.png", OsbOrigin.Centre, hitobject.Position);
                        var center = GetLayer("Hit").CreateSprite("sb/eff/hl.png", OsbOrigin.Centre, hitobject.Position);
                        big.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.25, 0.25 * 3);
                        big.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                        center.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.2);
                        center.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 600, 1, 0);
                        for (int i = 0; i < 4; i++)
                        {
                            var streak = GetLayer("Hit").CreateSprite("sb/eff/hl.png", OsbOrigin.Centre);
                            var streak2 = GetLayer("Hit").CreateSprite("sb/eff/hl.png", OsbOrigin.Centre);


                            double t = Random(0, Math.PI);
                            var radius = Random(100, 150);
                            double x = radius * Math.Cos(t+Math.PI/2) + hitobject.Position.X;
                            double y = radius * Math.Sin(t+Math.PI/2) + hitobject.Position.Y;

                            double x1 = radius * Math.Cos(t+Math.PI/2+Math.PI) + hitobject.Position.X;
                            double y1 = radius * Math.Sin(t+Math.PI/2+Math.PI) + hitobject.Position.Y;
                            
                            streak.Rotate(hitobject.StartTime,t+Math.PI);
                            streak.ScaleVec(hitobject.StartTime,0.02,0.8);
                            streak.Move(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + 600, hitobject.Position, x, y);
                            streak.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 8, 1, 0);

                            streak2.Rotate(hitobject.StartTime,t+Math.PI*2);
                            streak2.ScaleVec(hitobject.StartTime,0.02,0.8);
                            streak2.Move(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + 600, hitobject.Position, x1, y1);
                            streak2.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 8, 1, 0);
                        }
                    }
                }
            }
        }

    }
}
