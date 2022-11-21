using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretScan : MonoBehaviour
{
    bool leftToRight;
    Quaternion angle;
    float zAngle;
    public float speed;
    void Start()
    {
        leftToRight = true;
        zAngle = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = angle;

        if (leftToRight)
        {
            zAngle -= Time.deltaTime * speed;
            angle = Quaternion.Euler(0, zAngle, 0);

            if (zAngle <= -45)
            {
                leftToRight = !leftToRight;
            }
        }
        else
        {
            zAngle += Time.deltaTime * speed;
            angle = Quaternion.Euler(0, zAngle, 0);

            if (zAngle >= 45)
            {
                leftToRight= !leftToRight;
            }
        }
    }
}
