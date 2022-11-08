using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRangeGlass : MonoBehaviour
{
    public Animator doorAnimation;

    
    void Start()
    {
        doorAnimation = this.transform.parent.GetComponent<Animator>();
    }

    

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Weapon")
        {

            doorAnimation.SetBool("isOpening", true);
        }

    }
    // Start is called before the first frame update
    

    private void Update()
    {
        
        if(redKeyCardGlass.destroyedTargets == 15)
        {
           
            doorAnimation.SetBool("isOpening", false);
        }
    }
}
