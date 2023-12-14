using UnityEngine;
using UnityEngine.SceneManagement;

public class RushingWater : MonoBehaviour
{
    [SerializeField] private GameObject textLabel;
    [SerializeField] private int sceneIndexToLoad;

    //Want to display tutorial when entering area (trigger)
    //Should be at first hazard

    //When Entering Trigger
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Activated" + gameObject);
        textLabel.SetActive(true);
    }
    
    //When Exiting Trigger
    private void OnTriggerExit(Collider other)
    {
        textLabel.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " hit " + collision.gameObject.name + "Hit hazard restarting level");
            //Debug.log
            SceneManager.LoadScene(sceneIndexToLoad);
            //If hit restart level
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}
