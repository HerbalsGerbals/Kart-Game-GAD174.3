using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
            Debug.Log("Fell off track, Player loses");
        }
    }

}
