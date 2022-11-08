using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPadSound : MonoBehaviour
{
    public AudioClip jumpPad;


 
    private void OnTriggerEnter(Collider other)
    {
        
       if(other.tag == "FPS_Player")
        {
             AudioSource.PlayClipAtPoint(jumpPad, transform.position, 1f);
        }
           
       
    }
}
