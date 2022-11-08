using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballSpawnController : MonoBehaviour
{
    public GameObject greenSphere;
    public GameObject blueSphere;
    public GameObject redSphere;
    public GameObject whiteSphere;

    public static int gBall = 1;
    public static int bBall = 1;
    public static int rBall = 1;
    public static int wBall = 1;

    bool doOnce = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FPS_Player" && doOnce == false)
        {
            Instantiate(blueSphere);

            Instantiate(redSphere);

            Instantiate(greenSphere);

            Instantiate(whiteSphere);
            doOnce = true;
        }
    }


    private void Update()
    {
       

        if (bBall == 0)
        {
            Instantiate(blueSphere);
            bBall += 1;
        }

        if(rBall == 0)
        {
            Instantiate (redSphere);
            rBall += 1;
        }

        if(gBall == 0)
        {
            Instantiate((greenSphere));
            gBall += 1;
        }

        if(wBall == 0)
        {
            Instantiate ((whiteSphere));
            wBall += 1;
        }
       
    }

}
