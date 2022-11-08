using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwingZone : MonoBehaviour
{
    public bool isPlayerOnZone;

    public static int onZone = 0;
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            onZone += 1;

           
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            onZone -= 1;
            
        }
    }
}
