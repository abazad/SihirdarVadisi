﻿
using Sihirdar.WebService.Provider.RiotApi.Model.Misc;

namespace Sihirdar.WebService.Provider.RiotApi.Model.StaticDataEndpoint.Map.Cache
{
    class MapsStaticWrapper
    {
        public MapsStatic MapsStatic { get; private set; }
        public Language Language { get; private set; }
        public string Version { get; private set; }

        public MapsStaticWrapper(MapsStatic mapsStatic, Language language, string version)
        {
            MapsStatic = mapsStatic;
            Language = language;
            Version = version;
        }
    }
}
