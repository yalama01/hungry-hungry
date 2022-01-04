using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stampede : MonoBehaviour
{
    // starting position
    float startline = 20;

    // to call the prefabs of the animals
    public GameObject doe;
    public GameObject fox;
    public GameObject stag;


    // controles the invoke
    float startDelay = 3f;
    float spawnTimer = 1.5f;

    //random number gen
    float randomAnimal;
    float randomPositionX;
    Vector3 randomVector3;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("stampede", startDelay, spawnTimer);
    }

    public void stampede()
    {
        // random position and
        randomAnimal=Random.Range(0, 2);

        randomPositionX = Random.Range(-10f, 10f);

        randomVector3 = new Vector3(randomPositionX, 0,startline);

        // spawn the animals

        if (randomAnimal == 0)
        {
            Instantiate(doe, randomVector3, doe.transform.rotation);
        }
        if (randomAnimal == 1)
        {
            Instantiate(fox, randomVector3, fox.transform.rotation);
        }
        if (randomAnimal == 2)
        {
            Instantiate(stag, randomVector3, stag.transform.rotation);
        }


    } 
}
