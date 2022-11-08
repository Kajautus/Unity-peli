using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scifiCrateTrigger : MonoBehaviour
{
    public Animator doorAnimation;

    public MeshRenderer whiteColor;
    public MeshRenderer redColor;

    public AudioSource pressurePadAudio;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Crate")
        {
            whiteColor.enabled = false;
            redColor.enabled = true;
            pressurePadAudio.Play();
            doorAnimation.SetBool("isOpening", true);
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Crate")
        {
            whiteColor.enabled = true;
            redColor.enabled = false;
            pressurePadAudio.Play();
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
