using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valueToString : MonoBehaviour
{
    public Text mouseText;
    public Text volumeText;
    // Start is called before the first frame update

    
    private void Start()
    {
      
    }
    public void volumeSliderChange(float value)
    {
        volumeText.text = value.ToString();
    }
    public void mouseSliderChange(float value)
    {
        mouseText.text = value.ToString();
    }
}
