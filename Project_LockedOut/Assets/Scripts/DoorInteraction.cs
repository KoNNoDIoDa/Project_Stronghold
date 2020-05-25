using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public bool opened = false;
    public Animator anim;
    public string destination;
    public Item input;
    public Inventory inv;
    private void OnTriggerStay2D(Collider2D collision)
    {
        for (int i = 0; i < inv.items.Length; i++)
        {
            if (inv.items[i] == input)
            {
                opened = true;
            }
            if (Input.GetButtonDown("Interaction") && opened)
            {
                SceneManager.LoadScene(destination);
                inv.items[i] = null;
                inv.invSlots[i].sprite = inv.def;
            }
            if(inv == null && input == null)
            {
                opened = true;
            }
            //if(destination == null && input == null && inv == null)
            //{

            //}
        }
        anim.SetBool("Opened", opened);
        
    }
}
