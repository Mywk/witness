﻿using Restup.Webserver.Attributes;
using Restup.Webserver.Models.Contracts;
using Restup.Webserver.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WITNESS.RestControllers;

namespace WITNESS.RestControllers
{
    [RestController(InstanceCreationType.Singleton)]
    public sealed class Relay
    {
        [UriFormat("/relay/power/{id}/{state}")]
        public IGetResponse SetPower(int id, bool state)
        {
            return Common.RestGetResponse(RelayControlCenter.Active.SetPower(id, state), new List<object> { id.ToString(), state.ToString() }); 
        }
    }
}