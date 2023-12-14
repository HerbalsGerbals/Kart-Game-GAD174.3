using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This will send player back to Main Menu scene.
/// </summary>
public class QuitFeature : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //If player presses escape returns Player to Main Menu scene.
            Debug.Log("Escape key was pressed, Returning to Main Menu");
            SceneManager.LoadScene(0);
        }

    }
}
