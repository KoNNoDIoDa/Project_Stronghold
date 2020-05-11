using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{

    bool lamp;
    public Animator animator;
    int lampCount = 0;
    public GameObject glow;
    public PlayerMovement mov;

    Vector2 a;
    public float b;

    private void Start()
    {
        glow.SetActive(false);
    }

    void Update()
    {
        if (!lamp)
        {
            glow.SetActive(false);
        }
        else
        {
            glow.SetActive(true);
        }

        if (Input.GetButtonUp("Lamp"))
        {
            lampCount++;
        }

        if (lampCount == 1)
        {
            lamp = true;
        }

        if (lampCount > 1)
        {
            lamp = false;
            lampCount = 0;
        }

        if (lampCount == 0)
        {
            lamp = false;
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
