using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenet_Projekt
{
    class StoryManager
    {
        public Bitmap getStory(int x, Klasse.Klassen klasse )
        {
            if(klasse == Klasse.Klassen.Coronaleugner)
                switch (x)
                {
                    case 1:
                        return Resources.ResourceStory.Coronaleugner_Story_1;
                    case 2:
                        return Resources.ResourceStory.Coronaleugner_Story_2;
                    case 3:
                        return Resources.ResourceStory.Coronaleugner_Story_3;
                    case 4:
                        return Resources.ResourceStory.Coronaleugner_Story_4;
                    case 5:
                        return Resources.ResourceStory.Coronaleugner_Story_5;
                    case 6:
                        return Resources.ResourceStory.Coronaleugner_Story_6;
                }
            if (klasse == Klasse.Klassen.Normalbürger)
                switch (x)
                {
                    case 1:
                        return Resources.ResourceStory.Normalbürger_Story_1;
                    case 2:
                        return Resources.ResourceStory.Normalbürger_Story_2;
                    case 3:
                        return Resources.ResourceStory.Normalbürger_Story_3;
                    case 4:
                        return Resources.ResourceStory.Normalbürger_Story_4;
                    case 5:
                        return Resources.ResourceStory.Normalbürger_Story_5;
                    case 6:
                        return Resources.ResourceStory.Normalbürger_Story_6;
                }
            if (klasse == Klasse.Klassen.Virologe)
                switch (x)
                {
                    case 1:
                        return Resources.ResourceStory.Virologe_Story_1;
                    case 2:
                        return Resources.ResourceStory.Virologe_Story_2;
                    case 3:
                        return Resources.ResourceStory.Virologe_Story_3;
                    case 4:
                        return Resources.ResourceStory.Virologe_Story_4;
                    case 5:
                        return Resources.ResourceStory.Virologe_Story_5;
                    case 6:
                        return Resources.ResourceStory.Virologe_Story_6;
                }
            return null;

        }
    }
}
