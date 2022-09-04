using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicagain : MonoBehaviour
{
    public AudioClip oldTrack;

    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();
    }
    private LevelMusic theAM;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FPS_Player")
        {
            if (oldTrack != null)
            {
                theAM.ChangeMusic(oldTrack);
            }

        }
    }
}
