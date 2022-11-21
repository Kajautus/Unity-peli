using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreavitySwitch : MonoBehaviour
{
    private CharacterController cc;
    public Transform playerCam;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "GravitySwitch")
        {
            playerCam.rotation = Quaternion.Euler(0, 0, 180f);
        }
    }
    void Update()
    {
        
    }
}
