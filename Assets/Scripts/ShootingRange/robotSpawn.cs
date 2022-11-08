using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class robotSpawn : MonoBehaviour
{
    public GameObject greenRobo;
    public GameObject violetRobo;
    public GameObject whiteRobo;
    public GameObject greenRobo1;
    public GameObject violetRobo1;
    public GameObject whiteRobo1;

    public GameObject ammoBox;
    public static int ammoBoxAmount = 1;

    public static int gRobo = 1;
    public static int vRobo = 1;
    public static int wRobo = 1;
    public static int gRobo1 = 1;
    public static int vRobo1 = 1;
    public static int wRobo1 = 1;

    bool doOnce = false;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FPS_Player" && doOnce == false)
        {
            Instantiate(greenRobo);
            Instantiate(violetRobo);
            Instantiate(whiteRobo);
            Instantiate(greenRobo1);
            Instantiate(violetRobo1);
            Instantiate(whiteRobo1);
            Instantiate(ammoBox);
            doOnce = true;  
                
        }
    }

    void greRobo()
    {
        Instantiate(greenRobo);
        
    }
    
    void vioRobo()
    {
        Instantiate(violetRobo);
        
    }

    void whiRobo()
    {
        Instantiate(whiteRobo);
        
    }

    void greRobo1()
    {
        Instantiate(greenRobo1);
        
    }

    void vioRobo1()
    {
        Instantiate(violetRobo1);
        
    }

    void whiRobo1()
    {
        Instantiate(whiteRobo1);
        
    }

    void ammoSpawn()
    {
        Instantiate(ammoBox);
    }
    
    void Update()
    {
        if (gRobo == 0)
        {
            Invoke("greRobo", 8f);
            gRobo += 1;
        }
        if (vRobo == 0)
        {
            Invoke("vioRobo", 8f);
            vRobo += 1;
        }
        if (wRobo == 0)
        {
            Invoke("whiRobo", 8f);
            wRobo += 1;
        }
        if (gRobo1 == 0)
        {
            Invoke("greRobo1", 8f);
            gRobo1 += 1;
        }
        if (vRobo1 == 0)
        {
            Invoke("vioRobo1", 8f);
            vRobo1 += 1;
        }
        if (wRobo1 == 0)
        {
            Invoke("whiRobo1", 8f);
            wRobo1 += 1;
        }

        if (ammoBoxAmount == 0)
        {
            Invoke("ammoSpawn", 15f);
            ammoBoxAmount += 1;
        }
        
       
        
    }

   
}
