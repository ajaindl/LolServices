﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace LoLMetrics.Models
{
    public class Spell
    {
        [JsonProperty("cooldownBurn")]
        public string CooldownBurn { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
    }
}