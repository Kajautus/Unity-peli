using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour
{
    public GameObject projectile;
    private PlayerHealth health;
    public ParticleSystem particles;
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("FPS_Player"))
        {
         collision.GetComponent<PlayerHealth>().DamagePlayer(20);
            Instantiate(particles, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
