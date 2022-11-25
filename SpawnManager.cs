using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Se genera una lista ---> Lista de gameobjects
    [SerializeField] GameObject[] animalPrefabs;
    
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] float minTimeSpawn = 0.3f;
    [SerializeField] float maxTimeSpawn = 3.0f;

    float timer = 0.0f;
    float sumTimer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(minTimeSpawn, maxTimeSpawn);
    }

    // Update is called once per frame
    // The spawn is generated randomly
    void Update()
    {
        sumTimer += Time.deltaTime;

        if(sumTimer >= timer)
        {
            SpawnEnemies();
            sumTimer = 0.0f;
            timer = Random.Range(minTimeSpawn, maxTimeSpawn);
        }
    }

    void SpawnEnemies()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
            
            int spawnIndex = Random.Range(0, spawnPoints.Length);

            // Instaciar animales en la posición random dada con spawn points
            Instantiate(animalPrefabs[animalIndex], spawnPoints[spawnIndex].transform.position,animalPrefabs[animalIndex].transform.rotation);
    }
}
