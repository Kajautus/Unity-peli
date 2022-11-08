using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redKeyCardGlass : MonoBehaviour
{
    public Animator redKeyGlass;

    public static int destroyedTargets = 0;
    

    public void Update()
    {
        if (destroyedTargets == 15)
    
        {
            redKeyGlass.SetBool("isOpening", true);
        }
        

    }


    
    
    // Start is called before the first frame update
    void Start()
    {
        redKeyGlass = this.transform.parent.GetComponent<Animator>();
    }
}
