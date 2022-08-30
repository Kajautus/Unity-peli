using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreavitySwitch : MonoBehaviour
{
    private CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "GravitySwitch")
        {
            
        }
    }
    void Update()
    {
        
    }
}
