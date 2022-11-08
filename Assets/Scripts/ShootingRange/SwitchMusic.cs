using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public AudioClip newTrack;

    bool doOnce = false;
    private LevelMusic theAM;
    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Weapon" && redKeyCardGlass.destroyedTargets <= 15 && doOnce == false)
        {
            if(newTrack != null)
            {
                theAM.ChangeMusic(newTrack);
                doOnce = true;
            }
            
        }

        
    }

    



}
