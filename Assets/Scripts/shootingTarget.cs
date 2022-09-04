
using UnityEngine;

public class shootingTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 30f;
    public ParticleSystem particles;
    
    

    private void Start()
    {
        
        
    }
    public void TakeDamage (float amount)
    {
        
        health -= amount;
        if (health < 0f)
        {
            
            Die();

        }

        void Die()
        {
           
            CubePrison.destroyedTargets += 1;

            Instantiate(particles, transform.position, transform.rotation);
            
            Destroy(gameObject);
            
          
        }
    }




}
