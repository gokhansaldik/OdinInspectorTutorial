using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
using Data.ValueObject;

namespace Data.ValueObject
{
    [Serializable]
    public class Buildings
    {
        public Transform HomeLocation;

        public List<HomeValues> HouseSettings = new List<HomeValues>();
    }
}