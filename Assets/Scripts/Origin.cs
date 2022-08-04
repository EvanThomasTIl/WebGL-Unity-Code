using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Origin : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnManager;
    //private float direction = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * 3.0f * Time.deltaTime * direction);
        //if (transform.position.x >= 5 || transform.position.x <= -5)
        //{
        //    direction = direction * -1;
        //}
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
