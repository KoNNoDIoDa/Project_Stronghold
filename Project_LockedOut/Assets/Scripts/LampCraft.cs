using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampCraft : MonoBehaviour
{
    public GameObject canv;
    public Slider sl;
    public PlayerMovement mov;
    public Item item;
    public Item item2;
    bool handle = false;
    bool screwdrive = false;
    public Inventory inv;
    bool opened;
    bool start= false;
    public Animator anim;
    bool enough = false;
    public Lamp la;
    public GameObject message;
    float count = 0;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interaction") && !opened)
        {
            for (int i = 0; i < inv.items.Length; i++)
            {
                if (inv.items[i] == item)
                {
                    handle = true;
                    //enough = true;
                }
                if(inv.items[i] == item2)
                {
                    screwdrive = true;
                    //enough = true;
                }
            }
            if(screwdrive && handle)
            {
                start = true;
            }
            if (!handle && !screwdrive)
            {
                enough = true;
            }



        }
    }


    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            mov.move = false;
            canv.SetActive(true);
            sl.value += 1f * Time.deltaTime;
        }
        if (sl.value == sl.maxValue)
        {
            mov.move = true;
            canv.SetActive(false);
            sl.value = 0;
            opened = true;
            anim.SetBool("Opened", opened);
            la.active = true;
            start = false;
        }
        if (enough) 
        {
       
            message.SetActive(true);
            count += 1f * Time.deltaTime;
        }
        if (count >= 3f)
        {
            message.SetActive(false);
            count = 0;
            enough = false;
        }
    }
}
