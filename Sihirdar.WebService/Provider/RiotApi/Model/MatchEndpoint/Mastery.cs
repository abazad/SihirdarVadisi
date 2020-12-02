﻿using Newtonsoft.Json;

namespace Sihirdar.WebService.Provider.RiotApi.Model.MatchEndpoint
{
    /// <summary>
    /// Class representing a mastery of a participant (Match API).
    /// </summary>
    public class Mastery
    {
        internal Mastery() { }

        /// <summary>
        /// Mastery ID.
        /// </summary>
        [JsonProperty("masteryId")]
        public long MasteryId { get; set; }

        /// <summary>
        /// Mastery rank.
        /// </summary>
        [JsonProperty("rank")]
        public long Rank { get; set; }
    }
}
