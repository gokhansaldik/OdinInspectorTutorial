using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Data.ValueObject;

namespace Data.UnityObject
{
    [CreateAssetMenu(fileName = "HomeData", menuName = "My Game/Home Data")]
    public class CD_Home : ScriptableObject
    {
        [BoxGroup("Basic Info")]
        [LabelWidth(100)]
        public string BuildName;

        [BoxGroup("Basic Info")]
        [LabelWidth(100)]
        [TextArea]

        public string Description;



        public GameObject Platform;

        public List<Buildings> BuildingsSettings = new List<Buildings>();

        

    }
}