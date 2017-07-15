﻿//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using AlexaSkillsKit.UI;
using System.Collections.Generic;
using AlexaSkillsKit.UI.Cards;
using AlexaSkillsKit.UI.Directives;

namespace AlexaSkillsKit.Speechlet
{
    public class SpeechletResponse
    {
        public virtual Card Card {
            get;
            set;
        }

        public virtual OutputSpeech OutputSpeech {
            get;
            set;
        }

        public virtual Reprompt Reprompt {
            get;
            set;
        }

        public virtual IEnumerable<Directive> Directives
        {
            get;
            set;
        }

        public virtual bool ShouldEndSession {
            get;
            set;
        }


    }
}