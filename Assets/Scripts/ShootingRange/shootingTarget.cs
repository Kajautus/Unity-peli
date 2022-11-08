
using UnityEngine;

public class shootingTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 30f;
    public ParticleSystem particles;

    public AudioSource takeDamage;
    public AudioClip destroySound;

    public bool whiteRobo, greenRobo, violetRobo, whiteRobo1, greenRobo1, violetRobo1;
    
    
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

            redKeyCardGlass.destroyedTargets += 1;
            AudioSource.PlayClipAtPoint(destroySound, transform.position, 2f);
            Instantiate(particles, transform.position, transform.rotation);
            if (whiteRobo)
            {
                robotSpawn.wRobo -= 1;
                
            }
            if (greenRobo)
            {
                robotSpawn.gRobo -= 1;
                
            }
            if (violetRobo)
            {
                robotSpawn.vRobo -= 1;
                
            }
            
            if (whiteRobo1)
            {
                robotSpawn.wRobo1 -= 1;

            }
            if (greenRobo1)
            {
                robotSpawn.gRobo1 -= 1;

            }
            if (violetRobo1)
            {
                robotSpawn.vRobo1 -= 1;

            }
            Destroy(gameObject);

            
            
          
        }
    }




}
