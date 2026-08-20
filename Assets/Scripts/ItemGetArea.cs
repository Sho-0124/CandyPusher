using UnityEngine;

public class ItemGetArea : MonoBehaviour
{
    public ItemManager itemManager;

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();

        if (item != null)
        {
            itemManager.GetItem(item.itemName);

            Destroy(other.gameObject);
        }
    }
}