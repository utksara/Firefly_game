using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 0.1f;
    public float rotationSpeed = 1000.0f;
    public float theta = 0.0f;

    // Update is called once per frame
    void Update()
    {
        //float translation = Input.GetAxis("Vertical") * speed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);


    }
}
