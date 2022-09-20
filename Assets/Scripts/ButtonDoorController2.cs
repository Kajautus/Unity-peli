using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoorController2 : MonoBehaviour
{
    public Animator doorAnim = null;

    private bool doorOpen = false;

    public string openAnimationName = "Opening";
    public string closeAnimationName = "Closing";

    public int waitTimer = 1;
    private bool pauseInteraction = false;

    public MeshRenderer buttonColorON;
    public MeshRenderer buttonColorOFF;
    private IEnumerator PauseDoorInteraction()
    {
        pauseInteraction = true;
        yield return new WaitForSeconds(waitTimer); 
        pauseInteraction = false;
    }

    public void PlayAnimation()
    {
        if(!doorOpen && !pauseInteraction)
        {

            buttonColorON.enabled = false;
            buttonColorOFF.enabled = true;
            doorAnim.Play(openAnimationName, 0, 0.0f);
            doorOpen = true;
            StartCoroutine(PauseDoorInteraction());
        }
        else if (doorOpen && !pauseInteraction)
        {
            buttonColorON.enabled = true;
            buttonColorOFF.enabled = false;
            doorAnim.Play(closeAnimationName, 0, 0.0f);
            doorOpen = false;
            StartCoroutine(PauseDoorInteraction());
        }
    }

}
