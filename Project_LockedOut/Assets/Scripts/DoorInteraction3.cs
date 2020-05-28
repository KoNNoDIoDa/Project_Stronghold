using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteraction3 : MonoBehaviour
{
    public KeyHole but;
    bool opened;
    public Animator anim;
    public string destination;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (opened)
        {
            if (Input.GetButtonDown("Interaction"))
            {
                SceneManager.LoadScene(destination);
            }
        }
    }
    private void Update()
    {
        anim.SetBool("Opened", opened);
        if (but.opened)
        {
            opened = true;
        }
    }
}
