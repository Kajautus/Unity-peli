using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;



public class sliderSettings : MonoBehaviour
{
    public Slider slider;

    public AudioMixer audioMixer;

    public void Start()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        

    }

    public void SetVolume(float volume)
    {
       
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("Volume", volume);
        PlayerPrefs.Save();
    }

    
}
