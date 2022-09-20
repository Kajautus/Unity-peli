using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastButtonPress : MonoBehaviour
{
    
    public float raylength = 3f;
    public LayerMask layerMaskInteract;
    public string excludeLayerName = null;
    public GameObject instruction;
    private ButtonDoorController2 raycastedObj;

    private KeyCode openDoorKey = KeyCode.E;
    public AudioClip buttonSound;
    
    private bool isCrosshairActive;
    private bool doOnce;

    

    private const string interactableTag = "Interact";

    private void Start()
    {
        instruction.SetActive(false);
    }
    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, raylength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<ButtonDoorController2>();
                    instruction.SetActive(true);
                    
                }

                
                doOnce = false;

                if (Input.GetKeyDown(openDoorKey))
                {
                    
                    AudioSource.PlayClipAtPoint(buttonSound, transform.position, 0.2f);
                    raycastedObj.PlayAnimation();
                }
            }
        }

        else
        {
            instruction.SetActive(false);
            if (isCrosshairActive)
            {
                
                doOnce = false;
            }
        }
    }

    
}
