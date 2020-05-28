using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{
    public Lamp la;
    public GameObject message;
    public GameObject tutorial;
    public GameObject col;
    bool mes;
    bool tut;
    float count;
    float count2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!la.active)
        {
            mes = true;
        }
        if (la.active)
        {
            col.SetActive(false);
            tut = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mes)
        {
            message.SetActive(true);
            count += 1f * Time.deltaTime;
        }
        if(count >= 3)
        {
            count = 0;
            message.SetActive(false);
            mes = false;
        }
        if (tut)
        {
            tutorial.SetActive(true);
            count2 += 1f * Time.deltaTime;
        }
        if (count2 >= 5)
        {
            count2 = 0;
            tutorial.SetActive(false);
            tut = false;
        }
    }
}
