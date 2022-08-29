using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightON : MonoBehaviour
{
    
    public GameObject emissionSource;
    public GameObject lightSource;


    private void Start()
    {
        emissionSource.GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");
        lightSource.GetComponent<Light>().enabled = false;

    }

        // Update is called once per frame
        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player")
        {
            emissionSource.GetComponent<MeshRenderer>().material.EnableKeyword("_EMISSION");
            lightSource.GetComponent<Light>().enabled = true;
        }
    }
}
