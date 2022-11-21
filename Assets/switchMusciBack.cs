using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchMusciBack : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip oldTrack;
    private LevelMusic theAM;

    void Start()
    {
        theAM = FindObjectOfType<LevelMusic>();

    }

    private void Update()
    {
        if (EnemySpawn.robosDestroyed <= 0)
        {
            if (oldTrack != null)
            {
                theAM.ChangeMusic(oldTrack);
            }
        }
    }
}
