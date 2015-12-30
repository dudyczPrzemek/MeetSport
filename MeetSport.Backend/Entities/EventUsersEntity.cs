﻿using GoldenEye.Backend.Core.Entity;
using GoldenEye.Backend.Security.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Backend.Entities
{
    public class EventUsersEntity: EntityBase
    {
        public User PlayerId { get; set; }

        public EventEntity EventId { get; set; }
    }
}