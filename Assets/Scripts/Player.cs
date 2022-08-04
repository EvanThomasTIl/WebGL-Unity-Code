using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public GameObject cubes;
    
    
    [SerializeField]
    private GameObject Data;
    public float speed;
    private float respawnTime;
    


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -1);
        cubes = Instantiate(cubes, new Vector3(1, 1, 1), Quaternion.identity);
        

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float zInput = Input.GetAxis("Mouse ScrollWheel");

        StoredData data = Data.GetComponent<StoredData>();
        speed = data.storedDataStruct.playerSpeed;

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * 300 * zInput);


        if (Time.time >= respawnTime)
        {
            cubes.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        respawnTime = Time.time + 2.0f;

    }
}
