using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroler : MonoBehaviour
{
    //used to set speed of the player
    public float playerSpeed = .5f;

    // used to grab the
    float playerMove;

    //game bounds
    float leftBound = -16f;
    float rightBound = 15f;

    
    
    public GameObject cookies;

    

    // Update is called once per frame
    void FixedUpdate()
    {
        //keeping player inbounds
        if( transform.position.x <= leftBound)
        {

            transform.position = new Vector3(-15.9f ,transform.position.y , transform.position.z);

        }

        if( transform.position.x >= rightBound)
        {

                transform.position = new Vector3(14.9f ,transform.position.y , transform.position.z);

        }

        //player controles
        else
        {
            playerMove = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * playerSpeed * playerMove);
        }
        
        
    }

    private void Update()
    {
        //spawing projectiles (cookies!!!!!!!!)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cookies, transform.position, cookies.transform.rotation);



        }
    }
}
