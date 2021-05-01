using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SelfieAWookies.Core.Selfies.Domain
{
    public class Wookie
    {
        public int Id { get; set; }
        public List<Selfie> Selfies { get; set; }
    }
}