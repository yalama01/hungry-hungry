using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    GameObject deer;
    GameObject moose;
    GameObject fox;

    float random;

    float timedelay;
    

    
    void FixedUpdate()
    {
        
        random = Random.Range(0, 2);

        

    }
}
