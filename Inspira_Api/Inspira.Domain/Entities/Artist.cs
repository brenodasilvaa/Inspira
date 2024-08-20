﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspira.Domain.Entities
{
    public class Artist : Entity
    {
        public string Name { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Album> Albums { get; set; }
    }
}
