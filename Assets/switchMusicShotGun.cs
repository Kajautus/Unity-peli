using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMusicShotGun : MonoBehaviour
{
    public AudioClip newTrack;

    public bool doOnce;
    private LevelMusic theAM;
    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Weapon" && doOnce)
        {
            if (newTrack != null)
            {
                theAM.ChangeMusic(newTrack);
                doOnce = false;
            }

        }


    }
}
