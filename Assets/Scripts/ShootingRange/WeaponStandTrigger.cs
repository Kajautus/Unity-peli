using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStandTrigger : MonoBehaviour

{
    public Animator doorAnimation;
    


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Weapon" && redKeyCardGlass.destroyedTargets == 15)

        {
            
            doorAnimation.SetBool("isOpening", true);
        }
        

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Weapon" )
        {
            
            doorAnimation.SetBool("isOpening", false);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnimation = this.transform.parent.GetComponent<Animator>();
    }


    
}
