﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sihirdar.WebServiceV3.Provider.RiotApi.Misc.Converters;

namespace Sihirdar.WebServiceV3.Provider.RiotApi.MatchEndpoint
{
    /// <summary>
    /// Class representing a match's timeline (Match API).
    /// </summary>
    public class Timeline
    {
        internal Timeline() { }

        /// <summary>
        /// Time between each returned frame.
        /// </summary>
        [JsonProperty("frameInterval")]
        [JsonConverter(typeof(TimeSpanConverterFromMilliseconds))]
        public TimeSpan FrameInterval { get; set; }

        /// <summary>
        /// List of timeline frames for the game.
        /// </summary>
        [JsonProperty("frames")]
        public List<Frame> Frames { get; set; }
    }
}
