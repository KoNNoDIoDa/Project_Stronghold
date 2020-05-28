using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WallOfDeath : MonoBehaviour
{
    float count = -14.5f;
    public Transform wa;

    private void Update()
    {
        count -= 0.3f * Time.deltaTime;
        wa.position = new Vector2(count, 47.5f);
        if(count <= -21)
        {
            SceneManager.LoadScene("5Room");
        }
    }

}
