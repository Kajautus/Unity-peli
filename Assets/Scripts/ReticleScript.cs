using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleScript : MonoBehaviour
{
    [SerializeField] private Image reticle;
    public float pickUpRange = 3f;


    private void Start()
    {
        reticle.color = new Color(1, 1, 1, 0.75f);
    }
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
        {
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                reticle.color = new Color(1, 0, 0, 0.75f);
            }
            else
            {
                reticle.color = new Color(1, 1, 1, 0.75f);
            }


        }
        


        if (Physics.Raycast(transform.position, transform.forward, out hit, pickUpRange))
        {
            if (hit.transform.gameObject.CompareTag("Interact") || hit.transform.gameObject.CompareTag("Crate") || hit.transform.gameObject.CompareTag("Throwable") || hit.transform.gameObject.CompareTag("Weapon"))
            {
                reticle.color = new Color(0, 1, 1, 0.75f);
            }
            else
            {
                reticle.color = new Color(1, 1, 1, 0.75f);
            }
        }
        

    }
}
