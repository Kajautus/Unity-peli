using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForEnemySpawn : MonoBehaviour
{
    public GameObject enemySpawnActivation;
   private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Weapon")
        {
            enemySpawnActivation.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
      
    }
}
