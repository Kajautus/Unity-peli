using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ladderScript1 : MonoBehaviour

{

    public Transform chController;
    bool inside = false;
    public float speedUpDown = -50f;
    public PlayerMovement FPSInput;
    public AudioSource ladderSound;
    void Start()
    {
        FPSInput = GetComponent<PlayerMovement>();
        inside = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            FPSInput.enabled = false;
            inside = !inside;
           
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            FPSInput.enabled = true;
            inside = !inside;
        }
    }

    void Update()
    {
        if (inside == true && Input.GetKey("s"))
        {   
            
            chController.transform.position += Vector3.up / speedUpDown;
            
        }

        if (inside == true && Input.GetKey("w"))
        {
            
            chController.transform.position += Vector3.down / speedUpDown;
        }
    }

    private void FixedUpdate()
    {   
        // If player is latched on to a ladder and is pressing up or down, then the ladder sound plays
        if (inside == true && Input.GetKey("s") || inside == true && Input.GetKey("w"))
        {
            ladderSound.enabled = true ;
        }
        else
        {
            ladderSound.enabled = false ;
        }
    }
}
