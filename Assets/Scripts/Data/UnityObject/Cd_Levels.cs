﻿using System.Collections.Generic;
using Data.ValueObject;
using UnityEngine;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "CD_Level", menuName = "ATM_Rush/CD_Level", order = 0)]
    public class CD_Level : ScriptableObject
    {
        public List<CD_Home> Levels = new List<CD_Home>();
    }
}