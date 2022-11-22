using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMusicBack : MonoBehaviour
{
    public AudioClip oldTrack;
    private LevelMusic theAM;

    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();

    }

    private void Update()
    {
        if (EnemySpawn.robosDestroyed < 1)
        {
            if (oldTrack != null)
            {
                theAM.ChangeMusic(oldTrack);
            }
        }
    }
}
