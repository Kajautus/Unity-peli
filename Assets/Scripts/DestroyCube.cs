using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    public GameObject room1;
    public GameObject room2;
    public Animator doorAnimation;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player")
        {
            // Poistaa peliobjetin 3 sekunnin viiveell‰ ja k‰ynnist‰‰ taakse j‰‰v‰n oven sulkemisen animaation.
            
            doorAnimation.SetBool("isOpening", false);
            Invoke("setActive", 3f);
            
        }
        
    }

    private void setActive()
    {
        room1.SetActive(false);
        room2.SetActive(false);
    }

}
