using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    private bool hasPickup = false;
    private bool isAvailableForPickup = false;

    private Transform currentItemAvailableForPickup;

    [SerializeField] private Transform pickupTransform;

    public UnityEvent OnItemPickedUp;

    public static PlayerController instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

        //Subscribe PickUpItem function to the OnItemPickedUp Unity Event
        OnItemPickedUp.AddListener(PickUpItem);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAvailableForPickup)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnItemPickedUp.Invoke();
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            DropItem();
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

    private void DropItem()
    {
        if (currentItemAvailableForPickup != null)
        {
            currentItemAvailableForPickup.SetParent(null);
            hasPickup = false;
        }
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
