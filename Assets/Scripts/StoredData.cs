using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StoredData : MonoBehaviour
{
    [Serializable]
    public class DataStruct
    {
        public float cubeSpeed;
        public float playerSpeed;
        public int cubeSpawnLimit;
        public string playerName;
    }

    [SerializeField]
    public DataStruct storedDataStruct;
}


