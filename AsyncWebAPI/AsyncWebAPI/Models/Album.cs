﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebAPI.Models
{
    public class Album
    {
        public long UserId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
    }
}
