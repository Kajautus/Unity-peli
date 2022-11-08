using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countTimer : MonoBehaviour
{

    public float time = 45;

    

    // Update is called once per frame
    public void Timer()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;

            CanvasManager.Instance.UpdateTimer(Mathf.RoundToInt(time));
           
        }
        
        
    }

    public void resetScoreAndTime()
    {
        
        CanvasManager.Instance.UpdateTimer(Mathf.RoundToInt(time = 45));
        CanvasManager.Instance.UpdateDestroyedTargets(redKeyCardGlass.destroyedTargets -= redKeyCardGlass.destroyedTargets);
    }
    public void Update()
    {
        if(redKeyCardGlass.destroyedTargets > 0 && redKeyCardGlass.destroyedTargets != 15)
        {
            Timer();    
        }
        CanvasManager.Instance.UpdateDestroyedTargets(redKeyCardGlass.destroyedTargets);
        if (redKeyCardGlass.destroyedTargets < 15 && time <= 0)
        {
            resetScoreAndTime();
        }
    }
}
