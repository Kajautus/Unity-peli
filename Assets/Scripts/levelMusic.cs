using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMusic : MonoBehaviour
{
    public AudioSource music;

    // Update is called once per frame
    void Update()
    {
        music.Play();
    }
}
