using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class ItemDrop : MonoBehaviour
{
    
    public Item drop;
    public Inventory inv;
    public Slider sl;
    bool start = false;
    public GameObject canv;
    public Animator anim;
    bool opened = false;
    public PlayerMovement mov;
    public GameObject message;
    bool count;
    float remain;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interaction") && !opened)
        {
            start = true;
            
            
        }
        
    }
    void Update()
    {

        if (start)
        {
            mov.move = false;
            canv.SetActive(true);
            //sl.enabled = true;
            sl.value += 1f * Time.deltaTime;
        }
        if (sl.value == sl.maxValue && drop != null && message == null)
        {
            mov.move = true;
            opened = true;
            anim.SetBool("Opened", opened);
            canv.SetActive(false);
            inv.AddItem(drop);
            start = false;
            sl.value = 0;
            //sl.enabled = false;
        }
        if (sl.value == sl.maxValue && drop == null && inv == null)
        {
            mov.move = true;
            opened = true;
            message.SetActive(true);
            count = true;
            anim.SetBool("Opened", opened);
            canv.SetActive(false);
            start = false;
            sl.value = 0;
            //sl.enabled = false;
        }
        if (count)
        {
            remain += 1f * Time.deltaTime;
        }
        if(remain >= 3)
        {
            count = false;
            message.SetActive(false);
            remain = 0;
        }
    }

}
