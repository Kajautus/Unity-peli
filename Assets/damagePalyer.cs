using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePalyer : MonoBehaviour
{
    public int damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FPS_Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().DamagePlayer(damage);
        }
        

        
    }

}
