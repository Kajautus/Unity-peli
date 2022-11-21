using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{

    public float health = 30f;
    public ParticleSystem particles;
    public AudioClip destroySound;
<<<<<<< Updated upstream
    public AudioClip damageSound;
=======
    public AudioSource damageSound;
    public bool robo1, robo2, robo3;
>>>>>>> Stashed changes

    public void TakeDamage(float amount)
    {

        damageSound.Play();
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


        }
    }




}
