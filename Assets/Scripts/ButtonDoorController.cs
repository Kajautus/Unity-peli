using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonDoorController : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject doorAnim;
    public bool Action = false;
    public bool isOpen = false;

    private void Start()
    {
        Instruction.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "FPS_Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            Instruction.SetActive(false);
            Action = false;
            
        }
    }

    private void Update()
    {   
        if(Action == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                doorAnim.GetComponent<Animator>().Play("Opening");
                

                Action = false;
                isOpen = true;
                
                if(isOpen == true)
                {
                    doorAnim.GetComponent<Animator>().Play("Closing");
                    isOpen = false;
                    Action = true;
                }
            }
        }
        
        
        
    }

  

}
