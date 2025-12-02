using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject fuelPrefab;
    public GameObject starPrefab;

    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -4f;
    public float maxY = 4f;

    public float minSpawnTime = 2f;
    public float maxSpawnTime = 4f;

    private float timer = 0f;
    private float nextSpawnTime;

    void Start()
    {
        SetNextSpawnTime();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= nextSpawnTime)
        {
            SpawnRandomCollectible();
            timer = 0f;
            SetNextSpawnTime();
        }
    }

    void SetNextSpawnTime()
    {
        nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
    }

    void SpawnRandomCollectible()
    {
        Vector3 spawnPos = new Vector3(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY),
            0f
        );

        GameObject prefabToSpawn = Random.value > 0.5f ? fuelPrefab : starPrefab;

        Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
    }
}
