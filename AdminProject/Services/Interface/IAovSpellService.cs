﻿using System.Collections.Generic;
using Sihirdar.DataAccessLayer;
using Sihirdar.DataAccessLayer.Infrastructure.Models;

namespace AdminProject.Services.Interface
{
    public interface IAovSpellService
    {
        void Add(AovSpell spell);
        AovSpell Get(int id);
        void Delete(int id);
        List<AovSpell> List();
        void Edit(int id, AovSpell espell);
        List<AovSpell> List(StatusTypes status);
        List<AovSpell> GetChampSpells(int[] ids);
    }
}