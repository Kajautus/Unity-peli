using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Throwable" && other.GetComponent<sphereScript>().blueSphere)
        {
            Destroy(other.gameObject);
            ballInstantiate.bBall -= 1;
        }
        if (other.tag == "Throwable" && other.GetComponent<sphereScript>().redSphere)
        {
            Destroy(other.gameObject);
            ballInstantiate.oBall -= 1;
        }
    }
}
