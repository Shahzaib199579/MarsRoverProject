﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class MissionControl
    {
        public MissionControl()
        {
            MissionPlateu = new();
        }
        public Plateau MissionPlateu { get; set; }
    }
}