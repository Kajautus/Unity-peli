using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    
    public Animator doorAnimation;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player")
        {
            // Tuhoaa peliobjetin 3 sekunnin viiveell‰ ja k‰ynnist‰‰ taakse j‰‰v‰n oven sulkemisen animaation.
            
            doorAnimation.SetBool("isOpening", false);
        }
        
    }

}
