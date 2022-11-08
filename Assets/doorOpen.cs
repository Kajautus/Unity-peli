using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public Animator doorAnimation;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            doorAnimation.SetBool("isOpening", true);
        }
    }
}
