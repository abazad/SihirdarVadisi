﻿
using Sihirdar.WebService.Provider.RiotApi.Model.Misc;

namespace Sihirdar.WebService.Provider.RiotApi.Model.StaticDataEndpoint.Mastery.Cache
{
    class MasteryStaticWrapper
    {
        public MasteryStatic MasteryStatic { get; private set; }
        public Language Language { get; private set; }
        public MasteryData MasteryData { get; private set; }

        public MasteryStaticWrapper(MasteryStatic mastery, Language language, MasteryData masteryData)
        {
            MasteryStatic = mastery;
            Language = language;
            MasteryData = masteryData;
        }
    }
}
