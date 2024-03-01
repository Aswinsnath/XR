using UnityEngine;

public class SpawnObjectOnClick : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnDistance = 3f;

    void Start()
    {
        // Register a method to be called when the button is clicked
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(SpawnObject);
    }

    void SpawnObject()
    {
        // Calculate a random position in front of the player
        Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * spawnDistance;

        // Instantiate the object at the calculated position
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
