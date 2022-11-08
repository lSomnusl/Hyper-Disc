using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public GameObject[] obstaculos;


    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    public float difficultyTime = 0;


    void Start()
    {

       



    }


    void Update()
    {
        difficultyTime += Time.deltaTime;

        if(difficultyTime >= 60)
        {
            SpawnEnemies();
        }




    }


   




    public void SpawnEnemies()
    {

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject obstaculo = Instantiate(obstaculos[Random.Range(0, obstaculos.Length)], spawnPosition, gameObject.transform.rotation);

        Destroy(gameObject);


    }

}
