using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            // create an enemy object from our prefab, at the spawner's position, with no special rotation
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            timer = 0;
        }
    }
}
