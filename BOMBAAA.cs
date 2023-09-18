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
        if (collision.gameObject.tag == "lav") // lav etiketine sahipse bomba prefabını yok et
        {
            Destroy(bombPrefab);
        }
    }

    private void SpawnBomb()
    {
        float spawnX = Random.Range(-2.0f, 2.0f); // rastgele bir X pozisyonu
        float fallSpeed = Random.Range(minFallSpeed, maxFallSpeed); // rastgele düşme hızı

        GameObject newBomb = Instantiate(bombPrefab, new Vector3(spawnX, 10f, 0f), Quaternion.identity);
        
        Rigidbody2D bombRigidbody = newBomb.GetComponent<Rigidbody2D>(); // yeni bombaya rigidbody ekliyor
        
        bombRigidbody.velocity = new Vector2(0, -fallSpeed); //yeni bombaya düşme hızı ekleme kısmı
    }
}
