using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalAtacker : MonoBehaviour
{

    //launch speed
    public float runSpeed = -0.25f;

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

            // Ends game on miss
            FindObjectOfType<gameManager>().Endgame();
            
        }
    }
    //handles deleting animal on collision
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }
        


    }

}
