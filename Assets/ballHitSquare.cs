using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballHitSquare : MonoBehaviour
{
    public Animator animGlass;

    public AudioSource correctHitSound;

    


    private int oGlass = 0;

    private int bGlass = 0;

    public MeshRenderer lightON;

    public MeshRenderer lightOFF;
    void Start()
    {
        animGlass = this.transform.parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Throwable" && other.GetComponent<sphereScript>().blueSphere)
        {
            correctHitSound.Play();
            bGlass += 1;
            lightON.enabled = false;
            lightOFF.enabled = true;
        }

        if (other.tag == "Throwable" && other.GetComponent<sphereScript>().redSphere)
        {
            correctHitSound.Play();
            oGlass += 1;
            lightON.enabled = false;
            lightOFF.enabled = true;
        }


    }
    void Update()
    {
        if (bGlass == 1)
        {
            animGlass.SetBool("isClosing", true);
        }

        if (oGlass == 1)
        {
            animGlass.SetBool("isClosing", true);
        }
    }
}
