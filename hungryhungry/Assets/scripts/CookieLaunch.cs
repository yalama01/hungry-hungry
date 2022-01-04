using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieLaunch : MonoBehaviour
{
    //launch speed
    public float launchSpeed = 10;

    //destroy area
    private float destroy = 18f;
 
    // Update is called once per frame
    void FixedUpdate()
    {
        //
        transform.Translate(0,0, launchSpeed);

        
    }

    private void Update()
    {
        //destoys clone to keep from overloading
        if( transform.position.z == destroy)
        {
            Destroy(gameObject);
        }
    }

    //handles deleting cookie on collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "animal")
        {
            Destroy(gameObject);

        }



    }

}
