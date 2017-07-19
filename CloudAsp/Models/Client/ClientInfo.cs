using CloudAspData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudAsp.Models.Client
{
    public class ClientInfo
    {
        public CloudAspData.Entity.Client Client { get; set; }
        public List<Room> Rooms { get; set; }
    }
}