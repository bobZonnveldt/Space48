using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class CycleItem : MonoBehaviour
{
    private PickupItem PickupItems;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
{
    PickupItems = GetComponent<PickupItem>();
}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CycleItems();
    }
    void CycleItems() {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (PickupItems.items.Count > 0)
            {
                if (PickupItems.activeItemIndex < PickupItems.items.Count - 1)
                {
                    PickupItems.activeItemIndex++;
                }
                else
                {
                    PickupItems.activeItemIndex = 0;
                }
                PickupItems.itemImageHolder.color = PickupItems.items[PickupItems.activeItemIndex];
            }
            else
            {
                PickupItems.itemImageHolder.color = Color.white;
                PickupItems.activeItemIndex = -1;
                PickupItems.itemImageHolder.enabled = false;
            }
        }        
    }
}
