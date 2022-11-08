 using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    private int health;

    public int maxArmor;
    private int armor;

    public AudioClip healthSound;
    public AudioClip armorSound;

    public AudioSource randomSound;
    public AudioClip[] hurtSounds;
    void Start()
    {
        health = maxHealth;
        
        CanvasManager.Instance.UpdateHealth(health);
        CanvasManager.Instance.UpdateArmor(armor);
    }

    // Update is called once per frame
    void Update()
    {
        //Damage testi
        if (Input.GetKeyUp(KeyCode.Z))
        {
            DamagePlayer(20);
            Debug.Log("Player damaged");
        }
    }

    public void DamagePlayer(int damage)
    {
        if (armor > 0)
        {
            if(armor >= damage)
            {
                randomSound.clip = hurtSounds[Random.Range(0, hurtSounds.Length)];
                randomSound.Play();
                armor -= damage;
            }
            else if(armor < damage)
            {
                int remainingDamage;

                remainingDamage = damage - armor;

                armor = 0;

                health -= remainingDamage;
            }
        }
        else
        {
            randomSound.clip = hurtSounds[Random.Range(0, hurtSounds.Length)];
            randomSound.Play();
            health -= damage;
        }

        if (health <= 0)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
        if(health >= 0)
        {
            CanvasManager.Instance.UpdateHealth(health);
        }
        
        CanvasManager.Instance.UpdateArmor(armor);
    }


    public void GiveHealth(int amount, GameObject pickup)
    {
        if (health < maxHealth)
        {
            AudioSource.PlayClipAtPoint(healthSound, transform.position, 0.5f);
            health += amount;
            Destroy(pickup);
        }
        health += amount; 

        if(health > maxHealth)
        {
            health = maxHealth;
        }
        CanvasManager.Instance.UpdateHealth(health);
    }

    public void GiveArmor(int amount, GameObject pickup)
    {
        if(armor < maxArmor)
        {
            AudioSource.PlayClipAtPoint(armorSound, transform.position, 0.05f);
            armor += amount;
            Destroy(pickup);
        }

        if (armor > maxArmor)
        {
            armor = maxArmor;
        }
        CanvasManager.Instance.UpdateArmor(armor);
    }
}
