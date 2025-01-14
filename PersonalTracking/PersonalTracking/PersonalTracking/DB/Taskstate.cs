﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonalTracking.DB
{
    public partial class Taskstate
    {
        public Taskstate()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
