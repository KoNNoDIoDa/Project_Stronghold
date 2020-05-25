using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ButtonsMenu : MonoBehaviour
{
    public GameObject otherMenus;
    public GameObject interf;
    public GameObject menu;
    public string key;
    private string rightKey = "123456";
    public bool active;
    public bool right;
    string example = "";
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
                key = example;
            }

        }
        if(key.Length == 6)
        {
            if (key.Length == 6 && key == rightKey)
            {
                right = true;
                menu.SetActive(false);
                active = false;
                Time.timeScale = 1f;
                interf.SetActive(true);
                key = example;
            }
            else
            {
                key = example;
            }
            //key.Remove(0, key.Length);
        }
        
    }

    public void Enter1()
    {
        key += "1";
    }
    public void Enter2()
    {
        key += "2";
    }
    public void Enter3()
    {
        key += "3";
    }
    public void Enter4()
    {
        key += "4";
    }
    public void Enter5()
    {
        key += "5";
    }
    public void Enter6()
    {
        key += "6";
    }
}
