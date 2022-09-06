using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController : MonoBehaviour
{
    public Animator doorAnim;

    

    private void Start()
    {
        doorAnim = this.transform.parent.GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            doorAnim.SetBool("isOpening", true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "FPS_Player")
        {
            doorAnim.SetBool("isOpening", false);
        }
    }


}
