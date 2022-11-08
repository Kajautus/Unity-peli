using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI armor;
    public TextMeshProUGUI ammo;
    public TextMeshProUGUI score;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI destroyedTargers;
    public TextMeshProUGUI throws;

    public GameObject redKey;
    public GameObject greenKey;
    public GameObject blueKey;
    

    private static CanvasManager _instance;

    public static CanvasManager Instance
    {
        get { return _instance; }

    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;   
        }
    }

    
    public void UpdateHealth(int healthValue)
    {
        health.text = healthValue.ToString() + "%";
        
    }

    public void UpdateArmor(int armorValue)
    {
        armor.text = armorValue.ToString() + "%";
    }

    public void UpdateAmmo(int ammoValue)
    {
         ammo.text = ammoValue.ToString();
    }
    // score update for first scenes throwingball range
    public void UpdateScore(int scoreValue)
    {
       
         score.text = "Score " + scoreValue.ToString() + "/25";
        
       
    }

    // timer update for the first scene shootingrange
    public void UpdateTimer(int timerValue)
    {
        timer.text = "Time " + timerValue.ToString();
    }

    public void UpdateDestroyedTargets(int targetValue)
    {
        destroyedTargers.text = "Targets " + targetValue.ToString() + "/15";
    }


    public void UpdateThrows(int throwValue)
    {
        throws.text = "Throws " + throwValue.ToString() + "/5";
    }
    public void UpdateKeys(string keyColor)
    {
        if (keyColor == "green")
        {
            greenKey.SetActive(true);
        }
        if (keyColor == "red")
        {
            redKey.SetActive(true);
        }
        if (keyColor == "blue")
        {
            blueKey.SetActive(true);
        }
    }

    public void ClearKeys()
    {
        greenKey.SetActive(false);
        redKey.SetActive(false);
        blueKey.SetActive(false);
    }

   
}

