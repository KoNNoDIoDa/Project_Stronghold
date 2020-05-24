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
            }
            if(inv == null && input == null)
            {
                opened = true;
            }
        }
        anim.SetBool("Opened", opened);
        
    }
}
