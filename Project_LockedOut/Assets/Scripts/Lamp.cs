using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    bool lamp = false;
    public Animator animator;
    public GameObject glow;
    public PlayerMovement mov;


    private void Start()
    {
        glow.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonUp("Lamp"))
        {
            if (!lamp)
            {
                glow.SetActive(true);
                lamp = true;
            }
            else
            {
                glow.SetActive(false);
                lamp = false;
            }
        }

        

        animator.SetBool("Lamp", lamp);

        if (mov.horizontalMove < 0)
        {
            glow.transform.position = new Vector2(transform.position.x - 0.62f, transform.position.y - 0.27f);
        }
        if (mov.horizontalMove > 0)
        {
            glow.transform.position = new Vector2(transform.position.x + 0.62f, transform.position.y + 0.27f);
        }
        if (mov.verticalMove < 0)
        {
            glow.transform.position = new Vector2(transform.position.x - 0.27f, transform.position.y - 0.62f);
        }
        if (mov.verticalMove > 0)
        {
            glow.transform.position = new Vector2(transform.position.x + 0.27f, transform.position.y + 0.62f);
        }

    }
}
