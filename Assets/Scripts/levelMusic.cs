using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    public AudioSource levelmusic;

    // Update is called once per frame
    

    public void ChangeMusic(AudioClip music)
    {
        if (levelmusic.clip.name == music.name)
            return;
        levelmusic.Stop();
        levelmusic.clip = music;
        levelmusic.Play();
    }
}
