using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Transform playerGhost;
    public Vector3 interpPos = new Vector3(0, 0, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        interpPos = Vector3.Lerp(transform.position, playerGhost.position, Time.deltaTime );
        transform.position = interpPos;

        
    }
}
