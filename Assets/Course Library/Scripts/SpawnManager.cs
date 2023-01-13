using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Declares multiple prefabs
    public GameObject[] animalPrefabs;

    //Spawner details
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 3.0f;
    private float spawnInterval = 2.0f;
    
    //x and z axis max and min ranges
    float xLeft = 22;
    float xRight = 21;
    float zRangeMin = 3;
    float zRangeMax = 11;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay + 5, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay + 8, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, 10);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(xLeft, 0, Random.Range(zRangeMin, zRangeMax));
        int animalIndex = Random.Range(10, 12);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        Vector3 spawnPos = new Vector3(xRight, 0, Random.Range(zRangeMin, zRangeMax));
        int animalIndex = Random.Range(12, 14);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    }

}
