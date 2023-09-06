using UnityEditor;
using UnityEngine;

public class FallingBombs : MonoBehaviour
{
    public GameObject bombPrefab; // Bomba prefabı
    public float minSpawnInterval = 1.0f; // Minimum düşme aralığı
    public float maxSpawnInterval = 5.0f; // Maksimum düşme aralığı
    public float minFallSpeed = 2.0f; // Minimum düşme hızı
    public float maxFallSpeed = 4.0f; // Maksimum düşme hızı

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    private void Update()
    {
        nextSpawnTime -= Time.deltaTime;
        if (nextSpawnTime <= 0)
        {
            SpawnBomb();
            nextSpawnTime = Random.Range(minSpawnInterval, maxSpawnInterval);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "lav")
        {
            Destroy(bombPrefab);
        }
    }

    private void SpawnBomb()
    {
        float spawnX = Random.Range(-2.0f, 2.0f); // Rastgele bir X pozisyonu
        float fallSpeed = Random.Range(minFallSpeed, maxFallSpeed); // Rastgele düşme hızı

        GameObject newBomb = Instantiate(bombPrefab, new Vector3(spawnX, 10f, 0f), Quaternion.identity);
        Rigidbody2D bombRigidbody = newBomb.GetComponent<Rigidbody2D>();
        bombRigidbody.velocity = new Vector2(0, -fallSpeed);
    }
}
