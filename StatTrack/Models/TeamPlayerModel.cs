﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatTrack.Models
{
    public class TeamPlayerModel
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int YOB { get; set; }
        public string TeamID { get; set; }

    }
}