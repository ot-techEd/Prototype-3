using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hasPickup = false;
    private bool isAvailableForPickup = false;

    private Transform currentItemAvailableForPickup;

    [SerializeField] private Transform pickupTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAvailableForPickup)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PickUpItem();
            }
        }
    }
    public void MakeItemAvailableForPickup(Transform itemToPickup)
    {
        currentItemAvailableForPickup = itemToPickup;
        isAvailableForPickup = true;
        Debug.Log("ITEM IS AVAILABLE FOR PICKUP");
    }

    private void PickUpItem()
    {
        currentItemAvailableForPickup.position = pickupTransform.position;
        currentItemAvailableForPickup.SetParent(pickupTransform);
        hasPickup = true;
        Debug.Log("ITEM HAS BEEN PICKED UP!!!!!!");
    }

    public bool HasPickup()
    {
        return hasPickup;
    }

    public void MakeItemNotAvailableForPickup()
    {
        currentItemAvailableForPickup = null;
        isAvailableForPickup = false;
        Debug.Log("ITEM IS NO LONGER AVAILABLE FOR PICKUP");
    }
}
