using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [SerializeField] string itemName;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Managers.Inventory.AddItem(itemName);
        Destroy(this.gameObject);
    }
}
