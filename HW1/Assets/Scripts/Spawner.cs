using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Drag & Drop the Prefab in Inspector
    public Transform spawnPoint; // Optional: Set a spawn location
    public KeyCode spawnKey = KeyCode.Space; // Change this to any key

    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            Vector3 spawnPosition = spawnPoint != null ? spawnPoint.position : transform.position;
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Prefab is not assigned!");
        }
    }
}
