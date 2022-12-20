using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotGunKeyCard : MonoBehaviour
{
    public Animator redKeyGlass;
    
    public void Update()
    {
        if (EnemySpawn.robosDestroyed >= 12)

        {
            redKeyGlass.SetBool("isOpening", true);
        }


    }
}
