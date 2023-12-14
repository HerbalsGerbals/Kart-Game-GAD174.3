using UnityEngine;
using UnityEngine.SceneManagement;

public class Sunlight : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private int sceneIndexToLoad;
    [SerializeField] private KeyCode keyToPress;
    [SerializeField] private bool isPlayerCharacterNearby = false;
    [SerializeField] private GameObject textLabel;

    // Want to dectect player character in area
    private void SunlightReached()
    {
        SceneManager.LoadScene(0);
    }
    //When Player Character enters area set isPlayerCharacterNearby to true
    //if isPlayerCharacterNearby = true allow for GetKeyDown(keyToPress) to run
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger Activated" + other);
            isPlayerCharacterNearby = true;
            textLabel.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        isPlayerCharacterNearby = false;
        textLabel.SetActive(false);
    }
    private void Update()
    {
        // if Player presses "E" and Player Character boolean is true
        if (Input.GetKeyDown(keyToPress) && isPlayerCharacterNearby == true)
        {
            //Goal reached restart level
            //E activates code in area
            Debug.Log("Goal Reached! You pressed E");
            SunlightReached();
        }
    }

}
