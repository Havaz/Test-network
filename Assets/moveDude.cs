﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDude : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-Time.deltaTime * 10, 0, 0);

        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(Time.deltaTime * 10, 0, 0);

        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, Time.deltaTime * 10, 0);

        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, -Time.deltaTime * 10, 0);

        if (Input.GetKey(KeyCode.G))
            transform.Rotate ( new Vector3(0, -Time.deltaTime * 50, 0) );

    }
}
