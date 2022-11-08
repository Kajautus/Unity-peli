using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource jumpaPadSound;
   

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FPS_Player")
        {
            jumpaPadSound.Play();
        }
        
            


        
    }

}
