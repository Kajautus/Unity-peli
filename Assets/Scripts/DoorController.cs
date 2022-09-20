using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimation;

    public bool requiresKey;

    public bool reqRed, reqBlue, reqGreen;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPS_Player"))
        {
            if (requiresKey)
            {
                if(reqRed && other.GetComponent<PlayerInventory>().hasRed)
                {
                    doorAnimation.SetBool("isOpening", true);
                }
             
                if (reqBlue && other.GetComponent<PlayerInventory>().hasBlue)
                {
                    
                    doorAnimation.SetBool("isOpening", true);
                    
                }
                if (reqGreen && other.GetComponent<PlayerInventory>().hasGreen)
                {
                    doorAnimation.SetBool("isOpening", true);
                }
            }
            else
            {
                doorAnimation.SetBool("isOpening", true);
            }
        }
        
            
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("FPS_Player"))
        {
            doorAnimation.SetBool("isOpening", false);
        }

        
    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnimation = this.transform.parent.GetComponent<Animator>();
        
    }

    private void Update()
    {
        
    }
}
