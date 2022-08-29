using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeSound : MonoBehaviour
{
    
    public AudioSource audioSource; 
    
    public void close_Sound()
    {
        audioSource.Play();
    }
}
