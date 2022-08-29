using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour

{
    public Animator buttonAnimation;
    


    private void OnTriggerEnter(Collider other)
    {

        buttonAnimation.SetBool("isOpening", true);
        
    }

    private void OnTriggerExit(Collider other)
    {
        
        buttonAnimation.SetBool("isOpening", false);
    }
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimation = this.transform.parent.GetComponent<Animator>();
    }

    private void Update()
    {

    }
}