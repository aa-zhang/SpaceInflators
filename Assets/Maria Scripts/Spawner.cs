using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float SpawningTime;
    [SerializeField] private GameObject ToSpawn1, ToSpawn2, ToSpawn3, ToSpawn4;
    private int pickObject;

    private float _leftBoundary = -6;
    private float _rightBoundary = 6;
    private float _topBoundary = 18;
    private float _bottomBoundary = 12;

    // Start is called before the first frame update
    void Start()
    {
        SpawningTime = Random.Range(3f, 5f);
    }

    void SpawnNow()
    {
        if (pickObject == 1)
        {
            Instantiate(ToSpawn1, new Vector3(Random.Range(_leftBoundary, _rightBoundary), Random.Range(_bottomBoundary, _topBoundary), 33), Quaternion.identity);
;

        }
        if (pickObject == 2)
        {
            Instantiate(ToSpawn2, new Vector3(Random.Range(_leftBoundary, _rightBoundary), Random.Range(_bottomBoundary, _topBoundary), 33), Quaternion.identity);

        }
        if (pickObject == 3)
        {
            Instantiate(ToSpawn3, new Vector3(Random.Range(_leftBoundary, _rightBoundary), Random.Range(_bottomBoundary, _topBoundary), 33), Quaternion.identity);

        }
        if (pickObject == 4)
        {
            Instantiate(ToSpawn4, new Vector3(Random.Range(_leftBoundary, _rightBoundary), Random.Range(_bottomBoundary, _topBoundary), 33), Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        SpawningTime -= Time.deltaTime;
        if (SpawningTime <= 0)
        {
            int numberObjects = Random.Range(0, 3);
            for (int i = 0; i < numberObjects; i++)
            {
                pickObject = Random.Range(1, 5);
                SpawnNow();
                SpawningTime = Random.Range(2f, 3f);
            }

        }
    }
}
