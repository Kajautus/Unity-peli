using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolAmmobox : MonoBehaviour
{
    public int amount;


   

    
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPS_Player"))
        {
           
        other.GetComponentInChildren<GunController>().GiveAmmo(amount, this.gameObject);
            robotSpawn.ammoBoxAmount -= 1;

        }
    }
}
