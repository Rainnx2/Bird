using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePairPrefab;

    public float spawnEvery = 2.5f;
    public float spawnX = 7f;
    public float minY = -1.5f;
    public float maxY = 1.5f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnEvery)
        {
            float randomY = Random.Range(minY, maxY);

            Instantiate(
                pipePairPrefab,
                new Vector3(spawnX, randomY, 0f),
                Quaternion.identity
            );

            timer = 0f;
        }
    }
}