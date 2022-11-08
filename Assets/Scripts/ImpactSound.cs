using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    public AudioSource impactSound;
    public int magnitude;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "FPS_Player" && collision.relativeVelocity.magnitude > magnitude)
        {
            impactSound.Play();
        }
    }
}
