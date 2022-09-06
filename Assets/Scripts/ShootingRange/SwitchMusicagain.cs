using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchMusicagain : MonoBehaviour
{
    public AudioClip oldTrack;
    private LevelMusic theAM;
    
    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();

    }

    private void Update()
    {
        if(CubePrison.destroyedTargets == 15)
        {
            if (oldTrack != null)
            {
                theAM.ChangeMusic(oldTrack);
            }
        }
    }

    
    
    // Start is called before the first frame update

}
