using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovrScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float timeTilDeath = 10;
    private float timer = 0;

    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if ( timer <  timeTilDeath)
        //{
        //    Destroy(gameObject);
        //}

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("pipe destroied");
            Destroy(gameObject);
        }
        
    }
}
