using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassClose : MonoBehaviour
{
    public Animator glassClose1;
    public Animator glassClose2;
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Crate")
        {
            glassClose1.SetBool("isClosing", true);
            glassClose2.SetBool("isClosing", true);
        }
        
    }
}
