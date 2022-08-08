using System.Collections;
using UnityEngine;
using Data.ValueObject;
using Data.UnityObject;
using System.Collections.Generic;
using System;
using Enum;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        #region Self Variables

        #region Public Variables

        [Header("Data")] public int Data;
        [Header("Data")] public List<Buildings> BuildData;

        #endregion

        #region Serialized Variables
        #endregion

        #region Private Variables
        #endregion

        #endregion

        private void Awake()
        {
            Data = GetLevelData();
            BuildData = GetBuildData(Data);
            LevelInit();
        }

        private int GetLevelData() {

            return Resources.Load<CD_Level>("Data/Level").Levels.Count; 
        }

        private List<Buildings> GetBuildData(int data)
        {

            return Resources.Load<CD_Home>("Data/Home"+data).BuildingsSettings;
        }


        public void LevelInit()
        {

            for (int i = 0; i < BuildData.Count; i++)
            {
                var HouseSettings = BuildData[i].HouseSettings;
                for (int j = 0; j < HouseSettings.Count; j++)
                {
                    var position = new Vector3(BuildData[i].HomeLocation.position.x + HouseSettings[j].Offset.x,
                        BuildData[i].HomeLocation.position.y,
                        BuildData[i].HomeLocation.position.z + HouseSettings[j].Offset.y);

                    Instantiate(HouseSettings[j].HomeBuildGmeObject, position, Quaternion.identity);
                }
            }

        }
    }
}