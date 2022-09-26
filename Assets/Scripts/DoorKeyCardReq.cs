using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyCardReq : MonoBehaviour
{
    public bool reqRed, reqBlue, reqGreen;
    public GameObject instruction;
    void Start()
    {
        instruction.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (reqRed && other.GetComponent<PlayerInventory>().hasRed == false)
        {
            instruction.SetActive(true);
        }

        if (reqBlue && other.GetComponent<PlayerInventory>().hasBlue == false)
        {

            instruction.SetActive(true);

        }
        if (reqGreen && other.GetComponent<PlayerInventory>().hasGreen == false)
        {
            instruction.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            instruction.SetActive(false);
        }
        
    }
}
