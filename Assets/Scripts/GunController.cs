using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour
{
    [SerializeField] private Animator gunAnim;

    [SerializeField] string triggerName;

    [SerializeField] ParticleSystem muzzleFlash;
    
    [SerializeField] private Image reticle;

    public AudioSource shootSound;
    public AudioSource emptySound;
    public AudioClip ammoPickup;

    public float Damage = 10f;
    public float range = 100f;
    public GameObject impactEffect;
    public GameObject enemyImpact;
    public float impactForce = 30;
    public Camera playerCam;

    public int maxAmmo;
    private int ammo;


    public float fireRate;
    private float nextTimeToFire;

    void Start()
    {
        CanvasManager.Instance.UpdateAmmo(ammo);
    }
    public void SetTrigger()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextTimeToFire && ammo > 0)
        {

            shoot();
            gunAnim.enabled = true;
            shootSound.Play();
            muzzleFlash.Play();
            gunAnim.SetTrigger(triggerName);

           

        }
        if (Input.GetMouseButtonDown(0) && Time.time > nextTimeToFire && ammo == 0)
        {
            emptySound.Play();
        }


    }

    public void GiveAmmo(int amount, GameObject pickup)
    {
        if(ammo < maxAmmo)
        {
            AudioSource.PlayClipAtPoint(ammoPickup, transform.position, 0.5f);
            ammo += amount;
            Destroy(pickup);
        }
        if(ammo > maxAmmo)
        {
            ammo = maxAmmo;
        }
        CanvasManager.Instance.UpdateAmmo(ammo);

    }

    
    void shoot()    
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);                       

            shootingTarget target = hit.transform.GetComponent<shootingTarget>();
            if (target != null)
            {   
                
                target.TakeDamage(Damage);
            }

            EnemyTarget targets = hit.transform.GetComponent<EnemyTarget>();
            if (targets != null)
            {

                targets.TakeDamage(Damage);
            }
        }

        if (hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(-hit.normal * impactForce);
        }
        nextTimeToFire = Time.time + fireRate;

        ammo--;
        CanvasManager.Instance.UpdateAmmo(ammo);

        if(hit.transform.tag == "Enemy")
        {
            GameObject impact = Instantiate(enemyImpact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);
        }
        else
        {
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
        
    }


}
