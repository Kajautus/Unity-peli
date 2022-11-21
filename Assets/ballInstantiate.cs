using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballInstantiate : MonoBehaviour
{
    public static int oBall = 1;
    public static int bBall = 1;

    public GameObject orangeBall;
    public GameObject blueBall;
    void Start()
    {
        Instantiate(blueBall);
        Instantiate(orangeBall);
    }

    // Update is called once per frame
    void Update()
    {
        if (oBall < 1)
        {
            Instantiate(orangeBall);
            oBall += 1;

        }

        if(bBall < 1)
        {
            Instantiate (blueBall);
            bBall += 1;
        }
        
    }

   
}
