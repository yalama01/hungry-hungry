using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAtacker : MonoBehaviour
{

    //launch speed
    public float runSpeed = -5;

    //destroy area
    private float destroy = -10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //
        transform.Translate(0, 0, runSpeed);


    }

    private void Update()
    {
        //destoys clone to keep from overloading
        if (transform.position.z <= destroy)
        {
            Destroy(gameObject);
        }
    }

}
