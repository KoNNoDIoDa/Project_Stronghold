using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorsInteraction4 : MonoBehaviour
{
    bool opened;
    public PipesInt red;
    public PipesInt blue;
    public PipesInt green;
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
        if (red.opened && blue.opened && !green.opened)
        {
            opened = true;
        }
    }
}
