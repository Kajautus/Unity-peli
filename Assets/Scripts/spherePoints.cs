using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class spherePoints : MonoBehaviour
{
    
    public Animator greenKeyGlass;

    
    
    void Start()
    {
        greenKeyGlass = this.transform.parent.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballDestroy.score == 25)
        {
            greenKeyGlass.SetBool("isOpening", true);
        }
    }
}
