using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Searcher;
using UnityEngine;
using UnityEngine.UI;


public class ItemDrop : MonoBehaviour
{
    
    public Item drop;
    public Inventory inv;
    public Slider sl;
    bool start;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (drop == null)
        {

        }
        if (Input.GetButtonDown("Interaction"))
        {
            start = true;
            
            
        }
        
    }
    void Update()
    {
        if (start)
        {
            sl.enabled = true;
            sl.value += 1f * Time.deltaTime;
        }
        if (sl.value == sl.maxValue)
        {
            inv.AddItem(drop);
            start = false;
            sl.value = 0;
            sl.enabled = false;
        }
    }

}
