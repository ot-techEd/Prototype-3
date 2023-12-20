using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator doorAnim;

    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        doorAnim = GetComponent<Animator>();
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            doorAnim.SetBool("isDoorOpen", false);

        }
    }

    public void DoorOpen()
    {
        uiManager.SetUIText("Door Open");
        Debug.Log("DOOR OPEN");
    }

    public void DoorClose()
    {
        uiManager.SetUIText("Door Closed");
        Debug.Log("DOOR CLOSED");
    }
}
