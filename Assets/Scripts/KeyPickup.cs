using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool isRedKey, isBlueKey, isGreenKey;
    public AudioClip keyPickupSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FPS_Player"))
        {
            if (isRedKey)
            {
                AudioSource.PlayClipAtPoint(keyPickupSound, transform.position, 0.2f);
                other.GetComponent<PlayerInventory>().hasRed = true;
                CanvasManager.Instance.UpdateKeys(keyColor: "red");
            }

            if (isBlueKey)
            {
                AudioSource.PlayClipAtPoint(keyPickupSound, transform.position, 0.2f);
                other.GetComponent<PlayerInventory>().hasBlue = true;
                CanvasManager.Instance.UpdateKeys(keyColor: "blue");
            }

            if (isGreenKey)
            {
                AudioSource.PlayClipAtPoint(keyPickupSound, transform.position, 0.2f);
                other.GetComponent<PlayerInventory>().hasGreen = true;
                CanvasManager.Instance.UpdateKeys(keyColor: "green");
            }

            Destroy(gameObject);
        }
    }
}
