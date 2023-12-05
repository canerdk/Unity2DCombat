using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveInventory : MonoBehaviour
{
    private int activeSlotIndexNum = 0;

    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        playerControls.Inventory.Keyboard.performed += ctx => ToggleActiveSlot((int)ctx.ReadValue<float>());
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void ToggleActiveSlot(int numValue)
    {
        numValue--;
        activeSlotIndexNum = numValue;

        foreach (Transform invertorySlot in this.transform)
        {
            invertorySlot.GetChild(0).gameObject.SetActive(false);
        }

        this.transform.GetChild(numValue).GetChild(0).gameObject.SetActive(true);
    }
}
