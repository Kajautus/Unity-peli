using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PickupScript : MonoBehaviour
{

    private ObjectRendere opaqueRend;
    [SerializeField] public LayerMask PickupMask;
    [SerializeField] public Camera PlayerCam;
    [SerializeField] private Transform PickupTarget;
    
    [Space]
    [SerializeField] private float ThrowingForce;
    [SerializeField] public float PickupRange;
    public Rigidbody CurrentObject;


    public bool isPicked;
    public GameObject instruction;
    void Awake()
    {
        opaqueRend = GameObject.Find("FadeManager").GetComponent<ObjectRendere>();
        instruction.SetActive(false);
        isPicked = false;
    }
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
       


        if (Physics.Raycast(transform.position, fwd, out hit, PickupRange))
        {
            if (hit.collider.tag == "Interact" && isPicked == false|| hit.collider.tag == "Crate" && isPicked == false || hit.collider.tag == "Throwable" && isPicked == false)
            {

                instruction.SetActive(true);
                

            }
            else
            {
                instruction.SetActive(false);
            }

           
            
        }
        else
        {
            instruction.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            
            if (CurrentObject)
            {
                CurrentObject.useGravity = true;
                
                CurrentObject = null;
                isPicked=false;
                foreach (var rendererO in opaqueRend.opaqueRenderers)
                {
                    foreach (var rendererF in opaqueRend.fadeRenderers)
                    {
                        rendererO.enabled = true;
                        rendererF.enabled = false;
                    }
                }
                return;
                
            }

            Ray CameraRay = PlayerCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(CameraRay, out RaycastHit HitInfo, PickupRange, PickupMask))
            {

                
                isPicked = true;
                CurrentObject = HitInfo.rigidbody;
                CurrentObject.useGravity = false;
               
                
                    foreach (var rendererO in opaqueRend.opaqueRenderers)
                    {
                        foreach (var rendererF in opaqueRend.fadeRenderers)
                        {
                            rendererO.enabled = false;
                            rendererF.enabled = true;
                        }
                    }
                
                
                
            }
            
           


        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (CurrentObject)
            {
                isPicked = false;
                CurrentObject.useGravity = true;

                CurrentObject.AddForce(PlayerCam.transform.forward * ThrowingForce, ForceMode.Impulse);

                CurrentObject = null;
                foreach (var rendererO in opaqueRend.opaqueRenderers)
                {
                    foreach (var rendererF in opaqueRend.fadeRenderers)
                    {
                        rendererO.enabled = true;
                        rendererF.enabled = false;
                    }
                }
                return;

            }

        }


    }

    void FixedUpdate()
    {
        if (CurrentObject)
        {
            
            Vector3 DirectionToPoint = PickupTarget.position - CurrentObject.position;
            float DistanceToPoint = DirectionToPoint.magnitude;
            
            CurrentObject.velocity = DirectionToPoint * 6f * DistanceToPoint;

        }
    }
}
