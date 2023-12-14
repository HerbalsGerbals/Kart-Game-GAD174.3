using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentLevelIndex = 0;
    //Sets level index
    public AudioSource audioSource;
    //Plays audio when pressing button
    public void LoadNextLevel()
    {
        //Next level needs to be loaded (new scene)
        currentLevelIndex++;
        LoadScene(currentLevelIndex);
        audioSource.Play();
    }
    public void LoadPreviousLevel()
    {
        //goes back a scene 
        if (currentLevelIndex > 1)
        {
            currentLevelIndex--;
            LoadScene(currentLevelIndex);
        }
    }
    public void LoadSpecificlevel(int levelIndex)
    {
        //loads specific level
        if (levelIndex > 1 && levelIndex <= SceneManager.sceneCountInBuildSettings - 1)
        {
            currentLevelIndex = levelIndex;
            LoadScene(currentLevelIndex);
        }
    }
    private void LoadScene(int index)
    {
        /// <summary>
        /// Loads new scene
        /// </summary>

        SceneManager.LoadScene(index);
        Debug.Log("Start Button pressed, Loaded Next Scene");
    }
    public void QuitGame()
    {
        //Quits game
        Debug.Log("Qutting Application");
        audioSource.Play();
        Application.Quit();
    }
   
    
}
