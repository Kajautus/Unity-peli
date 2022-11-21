using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoandHealth : MonoBehaviour
{
    public GameObject ammo;
    public GameObject ammo2;
    public GameObject health;
    public GameObject health2;
    public static int ammopickup = 1;
    public static int ammopickup2 = 1;
    public static int healthpickup = 1;
    public static int healthpickup2 = 1;
    void Start()
    {
        Instantiate(health);
        Instantiate(health2);
        Instantiate(ammo);
        Instantiate(ammo2);
    }

    void Update()
    {
        if (GunController.ammo <= 5 && ammopickup == 0)
        {
            Instantiate(ammo);
            ammopickup += 1;
        }
        if (GunController.ammo <= 5 && ammopickup2 == 0)
        {
            Instantiate(ammo2);
            ammopickup2 += 1;
        }
        if (PlayerHealth.health <= 40 && healthpickup == 0)
        {
            Instantiate(health);
            healthpickup += 1;
        }
        if (PlayerHealth.health <= 40 && healthpickup2 == 0)
        {
            Instantiate(health2);
            healthpickup2 += 1;
        }
    }
}
