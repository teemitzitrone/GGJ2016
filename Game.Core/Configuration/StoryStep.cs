﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Game.Core.Configuration
{
    public class StoryStep : IConfiguration
    {
        [XmlAttribute]
        public string Key { get; set; }
        public string Text { get; set; }
        [XmlElement("Action")]
        public List<Action> ActionList { get; set; } = new List<Action>();
    }
}