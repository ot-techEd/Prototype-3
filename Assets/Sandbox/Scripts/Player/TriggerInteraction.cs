using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickupItem"))
        {
            if (playerController.HasPickup()) { return;} //Guard Clause

            //Tell Player to Pickup item and give it a reference to the item to pickup
            playerController.MakeItemAvailableForPickup(other.transform); 

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickupItem"))
        {
            //Check if player has left pickup item 
            playerController.MakeItemNotAvailableForPickup();

        }
    }
}
