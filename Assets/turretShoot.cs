using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretShoot : MonoBehaviour
{
    public GameObject shotPrefab;

    public float distanceToDetect;

    public AudioSource shootSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * distanceToDetect, Color.green);
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        Physics.Raycast(ray, out hit, distanceToDetect);
        if(hit.collider != null && hit.collider.gameObject.tag == "FPS_Player")
        {
            shootSound.Play();
            Instantiate(shotPrefab, transform.position, transform.rotation);
        }
    }


}
