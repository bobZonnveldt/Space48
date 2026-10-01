using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    private PickupItem PickupItems;
    private ShipMovement ShipMovement;
    private Shoot Shoot;
    private TextManager TextManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
{
    PickupItems = GetComponent<PickupItem>();
    ShipMovement = GetComponent<ShipMovement>();
    Shoot = GetComponent<Shoot>();
    TextManager = GetComponent<TextManager>();
}
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UseItems();
    }
    void UseItems()
    {
  
        if (Input.GetKeyDown(KeyCode.E) && PickupItems.items.Count > 0 && PickupItems.activeItemIndex != -1) {

            if (PickupItems.items[PickupItems.activeItemIndex] == Color.blue) {
                StartCoroutine(TextManager.ShowMessage(" +  Move Speed"));
                ShipMovement.moveSpeed += 5;
            }
            else if (PickupItems.items[PickupItems.activeItemIndex] == Color.red){
                StartCoroutine(TextManager.ShowMessage(" + Fire Rate"));
                Shoot.cooldownTime -= 0.1f;
            }
            else if(PickupItems.items[PickupItems.activeItemIndex] == Color.green){
                StartCoroutine(TextManager.ShowMessage(" + Rotation Speed"));
                ShipMovement.rotationSpeed += 10;
            }      
            PickupItems.items.RemoveAt(PickupItems.activeItemIndex);            
            if (PickupItems.activeItemIndex > 0)
            {
                PickupItems.activeItemIndex--;
                PickupItems.itemImageHolder.color = PickupItems.items[PickupItems.activeItemIndex];
            }
            else if(PickupItems.items.Count == 0)
            {
                PickupItems.itemImageHolder.color = Color.white;
                PickupItems.activeItemIndex = -1;
                PickupItems.itemImageHolder.enabled = false;
            }
            
        }
    }
}
