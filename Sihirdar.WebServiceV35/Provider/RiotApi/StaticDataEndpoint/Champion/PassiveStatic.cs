﻿using Newtonsoft.Json;

namespace Sihirdar.WebServiceV3.Provider.RiotApi.StaticDataEndpoint.Champion
{
    /// <summary>
    /// Class representing a champion's passive (Static API).
    /// </summary>
    public class PassiveStatic
    {
        internal PassiveStatic() { }

        /// <summary>
        /// String descripting the passive.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Image of the passive.
        /// </summary>
        [JsonProperty("image")]
        public ImageStatic Image { get; set; }

        /// <summary>
        /// Name of the passive.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Sanitized (HTML stripped) description of the passive.
        /// </summary>
        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }
    }
}
