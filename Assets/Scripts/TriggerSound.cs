using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audioSource;
    public bool allreadyPlayed = false;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player" && !allreadyPlayed)
        {
            audioSource.PlayOneShot(sound);
            allreadyPlayed = true;
        }
    }
}
