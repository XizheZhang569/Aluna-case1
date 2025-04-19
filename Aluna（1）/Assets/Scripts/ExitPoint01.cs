using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPoint01 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Load the next scene or perform any other action
            Debug.Log("Player has exited the level!");
            // You can use SceneManager.LoadScene("NextSceneName") here if you want to load a new scene
        }
    }
}
