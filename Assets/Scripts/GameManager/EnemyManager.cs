using UnityEngine;
using System.Collections;
public class EnemyManager : MonoBehaviour
{
    public static GameObject player;
    public float spawnRate = 2f;
    public Transform[] spawnPoints;
    public GameObject[] enemies;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SpawnEnemy", spawnRate, spawnRate);
    }


    void Update()
    {
  
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        int enemyIndex = Random.Range(0, enemies.Length);

        GameObject newEnemy = Instantiate(enemies[enemyIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
        EnemyMovment movment = newEnemy.GetComponent<EnemyMovment>();
        movment.EnemyTargetPlayer(player.transform);
    }
}
