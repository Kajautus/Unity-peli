using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBoxTrigger : MonoBehaviour
{
    public Animator doorAnimation;



    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Interact")
        {
            doorAnimation.SetBool("isOpening", true);
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Interact")
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
