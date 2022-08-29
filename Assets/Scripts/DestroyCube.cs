using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    public GameObject destroyObject;
    public GameObject destroyObject1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player")
        {
            Destroy(destroyObject);
            Destroy(destroyObject1);
        }
        
    }
}
