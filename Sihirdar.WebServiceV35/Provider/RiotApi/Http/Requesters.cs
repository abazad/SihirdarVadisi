﻿namespace Sihirdar.WebServiceV3.Provider.RiotApi.Http
{
    internal static class Requesters
    {
        public static Requester StaticApiRequester;
        public static Requester StatusApiRequester;
        public static RateLimitedRequester RiotApiRequester;
        public static RateLimitedRequester TournamentApiRequester;
    }
}
