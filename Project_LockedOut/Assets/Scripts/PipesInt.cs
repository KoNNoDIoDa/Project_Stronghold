using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipesInt : MonoBehaviour
{
    bool start = false;
    public Animator anim;
    public PlayerMovement mov;
    public GameObject canv;
    public Slider sl;
    public bool opened;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interaction"))
        {
            start = true;
        }
    }
    private void Update()
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
            opened = true;
            canv.SetActive(false);
            start = false;
            sl.value = 0;
            anim.SetBool("Opened", opened);
        }
    }
}
