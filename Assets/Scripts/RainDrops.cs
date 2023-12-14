using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RainDrops : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Raindrop hit Level Restarted");
        }
    }
}
