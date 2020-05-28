using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSign : MonoBehaviour
{
    public GameObject inter;
    public Wall men;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interaction"))
        {
            inter.SetActive(true);
            men.active = true;
            Time.timeScale = 0f;
            men.interf.SetActive(false);
        }
    }
}
