﻿using System;
using Newtonsoft.Json;
using Sihirdar.WebServiceV3.Provider.RiotApi.Misc.Converters;
using Sihirdar.WebServiceV3.Provider.RiotApi.TournamentEndpoint.Enums;

namespace Sihirdar.WebServiceV3.Provider.RiotApi.TournamentEndpoint
{
    /// <summary>
    /// Represents a tournament lobby event in the Riot tournament API.
    /// </summary>
    public class TournamentLobbyEvent
    {
        internal TournamentLobbyEvent()
        {
        }

        /// <summary>
        ///     The type of event that was triggered
        /// </summary>
        [JsonProperty("eventType")]
        public TournamentEventType EventType { get; set; }

        /// <summary>
        ///     The summoner that triggered the event
        /// </summary>
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }

        /// <summary>
        ///     Timestamp from the event
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(DateTimeConverterFromStringTimestamp))]
        public DateTime Timestamp { get; set; }
    }
}
