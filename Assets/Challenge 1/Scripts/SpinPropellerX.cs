using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // declare and set float variables
    private float turnSpeed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate object around z axis based on turn speed
        transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
    }
}