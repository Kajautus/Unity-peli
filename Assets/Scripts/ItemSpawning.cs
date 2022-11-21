using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawning : MonoBehaviour
{
    public bool isHealth;
    public bool isHealth2;
    public bool isArmor;
    public bool isAmmo;
    public bool isAmmo2;


    public int amount;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPS_Player"))
        {
            if (isHealth)
            {

                other.GetComponent<PlayerHealth>().GiveHealth(amount, this.gameObject);
                AmmoandHealth.healthpickup -= 1;
            }
            if (isHealth2)
            {

                other.GetComponent<PlayerHealth>().GiveHealth(amount, this.gameObject);
                AmmoandHealth.healthpickup2 -= 1;
            }
            if (isArmor)
            {
                other.GetComponent<PlayerHealth>().GiveArmor(amount, this.gameObject);
            }
            if (isAmmo)
            {
                other.GetComponentInChildren<GunController>().GiveAmmo(amount, this.gameObject);

                AmmoandHealth.ammopickup -= 1;
            }
            if (isAmmo2)
            {
                other.GetComponentInChildren<GunController>().GiveAmmo(amount, this.gameObject);

                AmmoandHealth.ammopickup2 -= 1;
            }

        }
    }
}
