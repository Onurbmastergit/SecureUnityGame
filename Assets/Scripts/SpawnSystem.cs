using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
     public GameObject enemyPrefab;
    public Transform spawnPoint;
    public bool enableSpawn ;
    public string direcaoSpawn;
    void Start()
    {
        InvokeRepeating("SpawnEnemy" , 3, 5);
    }
    void SpawnEnemy()
    {
        if(LevelManager.instance.nightStart && enableSpawn)
        {
             // Obtém a posição aleatória dentro da área de spawn
        Vector3 randomPosition = GetRandomSpawnPositionWithinBounds(spawnPoint.position, spawnPoint.localScale);

        // Instancia o inimigo na posição aleatória
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        }
       
    }

    Vector3 GetRandomSpawnPositionWithinBounds(Vector3 center, Vector3 size)
    {
        // Calcula uma posição aleatória dentro do limite do transform
        float randomX = Random.Range(center.x - size.x / 2f, center.x + size.x / 2f);
        float randomY = Random.Range(center.y - size.y / 2f, center.y + size.y / 2f);
        float randomZ = Random.Range(center.z - size.z / 2f, center.z + size.z / 2f);

        return new Vector3(randomX, randomY, randomZ);
    }
}

