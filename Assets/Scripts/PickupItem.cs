using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class PickupItem : MonoBehaviour
{
    public List<Color> items = new List<Color>();
    [SerializeField] public Image itemImageHolder;
    public int activeItemIndex = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item")) {
            PickUpItem(other.gameObject);
        }
    }
    void PickUpItem(GameObject item) {
        Color color = item.gameObject.GetComponent<Renderer>().material.color;

        Destroy(item);

        items.Add(color);

        activeItemIndex = items.Count - 1;
        itemImageHolder.color = items[activeItemIndex];
        itemImageHolder.enabled = true;
    }
}
