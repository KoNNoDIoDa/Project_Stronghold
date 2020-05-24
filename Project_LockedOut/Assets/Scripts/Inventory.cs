using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public Image[] invSlots = new Image[numItemSlots];
    public Item[] items = new Item[numItemSlots];
    public const int numItemSlots = 8;
    public Sprite def;

    public void AddItem(Item itemToAdd)
    {
        //itemToAdd.active = true;
        for (int i = 0; i < invSlots.Length; i++)
        {
            if (invSlots[i].sprite == def && itemToAdd.active)
            {
                items[i] = itemToAdd;
                invSlots[i].sprite = itemToAdd.sprite;
                //invSlots[i].enabled = true;
                itemToAdd.active = false;
    //            //invSlots[i] = itemImages[i];
                return;
            }
        }
    }
    public void RemoveItem(Item itemToRemove)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == itemToRemove)
            {
                items[i] = null;
                invSlots[i].sprite = def;
    //            itemImages[i].enabled = false;
                return;
            }
        }
    }
}
