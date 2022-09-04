using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRendere : MonoBehaviour
{
    
    public MeshRenderer[] opaqueRenderers;
    public MeshRenderer[] fadeRenderers;
    
    void Start()
    {
        foreach (var renderer in opaqueRenderers)
        {
            renderer.GetComponent<MeshRenderer>();
            
        }
        
        foreach (var renderer in fadeRenderers)
        {
            renderer.GetComponent<MeshRenderer>();
        }
        
        
    }

 
}
