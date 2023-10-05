using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 40.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move forward with speed 
        transform.Translate(Vector3.up* Time.deltaTime * speed);
        //transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}

