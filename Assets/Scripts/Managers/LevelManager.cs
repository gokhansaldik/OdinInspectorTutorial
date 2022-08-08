using System.Collections;
using UnityEngine;
using Data.ValueObject;
using Data.UnityObject;
using System.Collections.Generic;
using System;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        #region Self Variables

        #region Public Variables

        [Header("Data")] public List<HomeValues> Data;

        #endregion

        #region Serialized Variables

        [SerializeField] private GameObject levelHolder;


        #endregion

        #region Private Variables
        private int _data;
        #endregion

        #endregion

        private void Awake()
        {
            _data = 1;
            Data = GetBuild();
            Debug.Log(Data[0].HomeLocation.x);
            Instantiate (Data[0].HomeBuildGmeObject, Data[0].HomeLocation,Quaternion.identity);
        }

        private List<HomeValues> GetBuild() =>
            Resources.Load<CD_Home>($"Data/Home{_data}").HomeSetting;

    }
}