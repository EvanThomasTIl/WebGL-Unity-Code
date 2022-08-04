using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Data;
    [SerializeField]
    private GameObject Player;

    void Start()
    {
        //Instantiate(Data, Vector3.zero, Quaternion.identity);
        //destroyCubes();
    }

    void destroyCubes()
    {
        GameObject cubes = GameObject.FindGameObjectWithTag("Cubes");
        Destroy(cubes);
    }

    void updateCubeSpeed(float cubeSpeed)
    {
        StoredData data = Data.GetComponent<StoredData>();
        data.storedDataStruct.cubeSpeed = cubeSpeed;
    }

    void updatePlayerSpeed(float playerSpeed)
    {
        StoredData data = Data.GetComponent<StoredData>();
        data.storedDataStruct.playerSpeed = playerSpeed;
    }

    void updateCubeSpawnLimit(int cubeSpawnLimit)
    {
        StoredData data = Data.GetComponent<StoredData>();
        data.storedDataStruct.cubeSpawnLimit = cubeSpawnLimit;
    }
}

