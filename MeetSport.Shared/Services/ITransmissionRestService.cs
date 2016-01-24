﻿using GoldenEye.Shared.Core.Services;
using MeetSport.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetSport.Shared.Services
{
    public interface ITransmissionRestService : IRestService<TransmissionDTO>
    {
        IQueryable<TransmissionDTO> Get();
    }
}
