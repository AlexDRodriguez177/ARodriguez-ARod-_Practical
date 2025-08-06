using UnityEngine;
using System.Collections;
public class EnemyManager : MonoBehaviour
{

    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] enemy;
    [SerializeField] private Transform player;

    [SerializeField] private int numberOfEnemiesmin = 1;
    [SerializeField] private int numberOfEnemiesmax = 5;

    [SerializeField] private float spawnIntervalMin = 10f;
    [SerializeField] private float spawnIntervalMax = 20f;


    void Start()
    {
        StartWave();
    }

    private void StartWave()
    {
        int numEnemiesToSpawn = Random.Range(numberOfEnemiesmin, numberOfEnemiesmax);
        for (int i = 0; i < numEnemiesToSpawn; i++)
        {
            SpawnEnemy();
        }
        Invoke("StartWave", Random.Range(spawnIntervalMin, spawnIntervalMax));
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[enemyIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
        EnemyMovment enemyMovement = enemy[enemyIndex].GetComponent<EnemyMovment>();
        enemyMovement.EnemyTargetPlayer(player);
    }
}
