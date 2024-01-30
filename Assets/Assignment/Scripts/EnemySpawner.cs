using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemySpawnPos;
    public GameObject enemy;
    float counterCurrent = 0.0f;
    int counterTarget = 1;

    // Update is called once per frame
    void Update()
    {
        counterCurrent += Time.deltaTime;
        if (counterCurrent > counterTarget)
        {
            Instantiate(enemy, enemySpawnPos.position, enemySpawnPos.rotation);
            counterCurrent = 0.0f;
            counterTarget = Random.Range(1, 5);
        }
    }
}
