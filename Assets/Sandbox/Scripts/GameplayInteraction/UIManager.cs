using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text updateTxt;

    private PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        if (playerController != null) //Null Check
        {
            playerController.OnItemPickedUp.AddListener(UpdateText);
        }
    }


    public void UpdateText()
    {
        updateTxt.SetText("Item Picked Up");
    }

    public void SetUIText(string message)
    {
        updateTxt.SetText(message);
    }
}
