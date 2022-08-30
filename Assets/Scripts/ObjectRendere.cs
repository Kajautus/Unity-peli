using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRendere : MonoBehaviour
{
    
    public MeshRenderer[] opaqueRenderers;
    
    void Start()
    {
        foreach (var renderer in opaqueRenderers)
        {
            renderer.GetComponent<MeshRenderer>();
        }
        
      
        
        
    }

 
}
