using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignWall : MonoBehaviour
{
    public bool active = false;
    public GameObject otherMenus;
    public GameObject interf;
    public GameObject menu;

    void Update()
    {
        if (active)
        {
            otherMenus.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (active)
            {
                menu.SetActive(false);
                active = false;
                Time.timeScale = 1f;
                interf.SetActive(true);
            }

        }
    }
}
