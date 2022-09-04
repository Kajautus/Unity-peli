using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReticleScript : MonoBehaviour
{
    [SerializeField] private Image reticle;

    private void Start()
    {
        reticle.color = new Color(1, 1, 1, 0.75f);
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 50f))
        {
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                reticle.color = new Color(1, 0, 0, 1f);
            }
        }
        else
        {
            reticle.color = new Color(1, 1, 1, 1f);
        }
    }
}
