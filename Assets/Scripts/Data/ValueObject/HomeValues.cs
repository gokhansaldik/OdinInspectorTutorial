using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
using Enum;

namespace Data.ValueObject
{
    [Serializable]
    public class HomeValues
    {


        [HorizontalGroup("Game Data", 75)]
        [PreviewField(75)]
        [HideLabel]
        public GameObject HomeBuildGmeObject;

        //[VerticalGroup("Game Data/Stats")]
        //[GUIColor(0.5f, 1f, 0.5f)]
        //public HomeType HomeType = HomeType.Home1;

        [VerticalGroup("Game Data/Stats")]
        [Range(20, 100)]
        [GUIColor(0.5f, 1f, 0.5f)]
        public int SellPiece = 20;

        [VerticalGroup("Game Data/Stats")]
        public Vector2 Offset;


    }

}