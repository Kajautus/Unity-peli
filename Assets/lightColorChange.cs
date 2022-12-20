using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightColorChange : MonoBehaviour
{
    public GameObject[] blueLights;
    public GameObject[] redLights;
   
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Weapon" && EnemySpawn.robosDestroyed <= 12)
        {
            foreach (GameObject blueLight in blueLights) { blueLight.SetActive(false); }
            foreach (GameObject redLight in redLights) { redLight.SetActive(true); }
        }
    }


    void Update()
    {
        if(EnemySpawn.robosDestroyed >= 12)
        {
            foreach (GameObject blueLight in blueLights) { blueLight.SetActive(true); }
            foreach (GameObject redLight in redLights) { redLight.SetActive(false); }
        }
        
    }
}
