using UnityEngine;
using UnityEngine.InputSystem;


public class Spawner2D : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnInterval = 1f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnBall();
            timer = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        GameObject Ball = Instantiate(ballPrefab, new Vector3(transform.position.x + Random.Range(-8.2f, 8), transform.position.y, transform.position.z), Quaternion.identity);

        SpriteRenderer sr = Ball.GetComponent<SpriteRenderer>();
        sr.color = Random.ColorHSV();
    }
}
