using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Animator gunAnim;

    [SerializeField] string triggerName;

    [SerializeField] ParticleSystem muzzleFlash;

    public float Damage = 10f;
    public float range = 100f;
    public GameObject impactEffect;
    public float impactForce = 30;
    public Camera playerCam;
    


    public void SetTrigger()
    {
        shoot();
        gunAnim.enabled = true;
        muzzleFlash.Play();
        gunAnim.SetTrigger(triggerName);
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
        }

        if (hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(-hit.normal * impactForce);
        }

        GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impactGO, 2f);
    }


}
