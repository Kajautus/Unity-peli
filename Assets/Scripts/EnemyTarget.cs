using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    public float health = 30f;
    public ParticleSystem particles;
    public AudioClip destroySound;
    public AudioClip damageSound;

    public void TakeDamage(float amount)
    {

        AudioSource.PlayClipAtPoint(destroySound, transform.position, 2f);
        health -= amount;
        if (health <= 0f)
        {

            Die();

        }

        void Die()
        {

            
            AudioSource.PlayClipAtPoint(destroySound, transform.position, 2f);
            Instantiate(particles, transform.position, transform.rotation);

            Destroy(gameObject);
            EnemySpawn.robo -= 1;

        }
    }




}
