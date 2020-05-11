using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class DoorInteraction : MonoBehaviour
{
    public bool opened;
    public string destination;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("Interaction") && opened )
        {
            SceneManager.LoadScene(destination);
        }
    }
}
