using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDropSpawner : MonoBehaviour
{
     
    [SerializeField] private GameObject rainDropPrefab;
    //Reference to Gameobject
    [SerializeField] private List<GameObject> rainDropSpawnPoints = new List<GameObject> ();
    //Reference to Spawn points
    [SerializeField] private List<RainDrops> rain = new List<RainDrops>();

    private void OnTriggerEnter(Collider other)
    {
        //Collision Dectection
        if (other.CompareTag("Player") == true) 
        {
            Debug.Log("Rain Drop Hit");
            //Need to spawn rain in different points
            Vector3 spawnPosition = rainDropSpawnPoints[Random.Range(0, rainDropSpawnPoints.Count)].transform.position;
            // TODO 2023/12/11 11:11am Fix bug with 2 spawning due to multiple colliders on player character 

            //Check for Null
            if (rainDropPrefab != null)
            {
                GameObject newRainDrop = Instantiate(rainDropPrefab, spawnPosition, Quaternion.identity);
                rain.Add(newRainDrop.GetComponent<RainDrops>());
                foreach(RainDrops rainDropPrefab in rain) 
                {
                    newRainDrop.name = "Watch Out RAIN!";
                }
            }
        }
    }
}
