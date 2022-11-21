using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyBot;
    public static int robo = 1;

    void Start()
    {
        Instantiate(enemyBot);
    }

    
    void Update()
    {
        if (robo == 0)
        {
            Instantiate(enemyBot);
            robo += 1;
        } 
    }
}
