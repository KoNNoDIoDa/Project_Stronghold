using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public GameObject candle;
    bool act = true;
    int count = 0;
    int r = 0;
  
    void Update()
    {
        if (!act)
        {
            candle.SetActive(true);
            act = true;
        }
        if (count == 0)
        {
            r = Random.Range(50, 100);
        }
        if (count < r)
        {
            count++;
        }
        else
        {
            candle.SetActive(false);
            act = false;
            count = 0;
        }
    }
}
