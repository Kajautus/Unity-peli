using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyBot;
    public GameObject enemyBot2;
    public GameObject enemyBot3;
    public static int robo = 1;
    public static int robo2 = 1;
    public static int robo3 = 1;
    public static int robosDestroyed = 8;
    public GameObject roboSpawner;

    void Start()
    {
        Instantiate(enemyBot);
        Invoke("Spawnrobo2", 10f);
        Invoke("Spawnrobo3", 20f);
    }

    void Spawnrobo2 ()
    {
        Instantiate(enemyBot2);
    }
    void Spawnrobo3()
    {
        Instantiate(enemyBot3);
    }
    void Update()
    {
        if (robo2 == 0)
        {
            Instantiate(enemyBot2);
            robo2 += 1;
            robosDestroyed -= 1;
        }
        if (robo == 0)
        {
            Instantiate(enemyBot);
            robo += 1;
            robosDestroyed -= 1;
        }
        if (robo3 == 0)
        {
            Instantiate(enemyBot3);
            robo3 += 1;
            robosDestroyed -= 1;
        }

        if (robosDestroyed < 1)
        {
            Destroy(gameObject);
        }
    }
}
