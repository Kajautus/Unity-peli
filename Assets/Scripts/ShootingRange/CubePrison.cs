using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePrison : MonoBehaviour
{
    public Animator cubePrisonAnim;

    public static int destroyedTargets = 0;

    public void Update()
    {
        if (destroyedTargets == 15)
    
        {
            cubePrisonAnim.SetBool("isOpening", true);
        }
        

    }


    
    
    // Start is called before the first frame update
    void Start()
    {
        cubePrisonAnim = this.transform.parent.GetComponent<Animator>();
    }
}
