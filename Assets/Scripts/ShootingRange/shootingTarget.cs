
using UnityEngine;

public class shootingTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 30f;
    public ParticleSystem particles;

    public AudioSource takeDamage;
    public AudioClip destroySound;
    

    public void TakeDamage (float amount)
    {
        takeDamage.Play ();

        health -= amount;
        if (health <= 0f)
        {
            
            Die();

        }

        void Die()
        {
           
            CubePrison.destroyedTargets += 1;
            AudioSource.PlayClipAtPoint(destroySound, transform.position, 2f);
            Instantiate(particles, transform.position, transform.rotation);
            
            Destroy(gameObject);
            
          
        }
    }




}
