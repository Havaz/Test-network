using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDude : MonoBehaviour
{


    Vector3 move = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

        move *= 0;
        float rotate = 0;

        if (Input.GetKey(KeyCode.A))
            move.Set(-Time.deltaTime * 10, 0, 0);
        if (Input.GetKey(KeyCode.D))
            move.Set(Time.deltaTime * 10, 0, 0);
        if (Input.GetKey(KeyCode.W))
           move.Set(0, Time.deltaTime * 10, 0);
        if (Input.GetKey(KeyCode.S))
            move.Set(0, -Time.deltaTime * 10, 0);


         transform.position += move;
         transform.Rotate (0,0,0);

    }
}
