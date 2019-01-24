using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class moveDude : NetworkBehaviour
{



    Vector3 move = new Vector3(0,0,0);

    public Transform avatar;

    // Start is called before the first frame update
    void Start()
    {

        avatar = Instantiate(avatar, transform.position, Quaternion.identity);
        avatar.GetComponent<player>().playerGhost = transform;

    }

    // Update is called once per frame
    void Update()
    {



        if (isLocalPlayer)
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
            transform.Rotate(0, 0, 0);
        }

    }
}
