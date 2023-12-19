using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool hasPickup = false;

    [SerializeField] private Transform pickupTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUpItem(Transform itemToPickup)
    {
        itemToPickup.position = pickupTransform.position;
        itemToPickup.SetParent(pickupTransform);
        hasPickup = true;
    }

    public bool HasPickup()
    {
        return hasPickup;
    }
}
