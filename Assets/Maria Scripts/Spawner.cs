using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float SpawningTime;
    [SerializeField] private GameObject ToSpawn1, ToSpawn2, ToSpawn3, ToSpawn4;
    private int pickObject;

    // Start is called before the first frame update
    void Start()
    {
        SpawningTime = Random.Range(0.5f, 2.5f);
    }

    void SpawnNow()
    {
        if (pickObject == 1)
        {
            Instantiate(ToSpawn1, new Vector3(Random.Range(-15, 15), Random.Range(0, 30), 33), Quaternion.identity);

        }
        if (pickObject == 2)
        {
            Instantiate(ToSpawn2, new Vector3(Random.Range(-15, 15), Random.Range(0, 30), 33), Quaternion.identity);

        }
        if (pickObject == 3)
        {
            Instantiate(ToSpawn3, new Vector3(Random.Range(-15, 15), Random.Range(0, 30), 33), Quaternion.identity);

        }
        if (pickObject == 4)
        {
            Instantiate(ToSpawn4, new Vector3(Random.Range(-15, 15), Random.Range(0, 30), 33), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        SpawningTime -= Time.deltaTime;
        if (SpawningTime <= 0)
        {
            int numberObjects = Random.Range(0, 5);
            for (int i = 0; i < numberObjects; i++)
            {
                pickObject = Random.Range(1, 5);
                SpawnNow();
                SpawningTime = Random.Range(0.5f, 2.5f);
            }

        }
    }
}
