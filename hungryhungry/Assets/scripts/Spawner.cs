using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

I wrote this the code works and it spawns the animals correctely i just feel like theres a better way to do this so i
scrapped it but chose to leave it in as a learning experiance









public class Spawner : MonoBehaviour
{
    //calling all animals
    public GameObject deer;
    public GameObject moose;
    public GameObject fox;

    //used to randomize what animal spawns
    float random;

    //to keep the rando spawn under controle
    public float spawnDelay = 3.5f;
    public float startDelay = 2f;
    

    
    void Start()
    {

        InvokeRepeating("RandomAnimalGenerator",startDelay, spawnDelay);

        

    }

    public void RandomAnimalGenerator()
    {
        random = Random.Range(0,6);

        if(random == 0)
        {
            Instantiate(deer, transform.position, deer.transform.rotation);
        }
        if(random == 3)
        {
            Instantiate(moose, transform.position, moose.transform.rotation);
        }
        if(random == 6)
        {
            Instantiate(fox, transform.position, fox.transform.rotation);
        }
        
    }
}
*/