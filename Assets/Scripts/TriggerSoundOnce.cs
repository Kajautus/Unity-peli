using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundOnce : MonoBehaviour
{
    
    public AudioSource audioSource;
    private bool isPlayed;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player" && !isPlayed )
        {
            audioSource.Play();
            isPlayed = true;
            
        }
    }
}
