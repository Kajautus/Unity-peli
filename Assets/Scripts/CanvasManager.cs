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

