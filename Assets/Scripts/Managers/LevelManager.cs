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
        [SerializeField] private int level=1; 
        [SerializeField] private GameObject idleArea;
        #endregion

        #region Private Variables
        #endregion

        #endregion

        private void Awake()
        {
            idleArea = GameObject.Find("IDLE_Floor");
            //Data = GetLevelData();
            BuildData = GetBuildData(level);
            LevelInit();
        }

        //private int GetLevelData() {

        //    return Resources.Load<CD_Level>("Data/Level").Levels.Count; 
        //}

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
                    var gameObjectChild = idleArea.transform.GetChild(i);
                    var position = new Vector3(gameObjectChild.transform.position.x + HouseSettings[j].Offset.x,
                        gameObjectChild.position.y,
                        gameObjectChild.position.z + HouseSettings[j].Offset.y);

                    Instantiate(HouseSettings[j].HomeBuildGmeObject, position, Quaternion.identity);
                }
            }

        }
    }
}