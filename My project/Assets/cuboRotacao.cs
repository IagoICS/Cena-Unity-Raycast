using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboRotacao : MonoBehaviour
{
    public GameObject cubePrefab;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            // Destroi o cubo
            Destroy(gameObject);

            // Instancia um novo cubo a partir do prefab em uma posição aleatória
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(-5.0f, 5.0f);
        float randomY = transform.position.y; // Mantém a mesma altura do cubo original
        float randomZ = transform.position.z; // Mantém a mesma profundidade do cubo original

        return new Vector3(randomX, randomY, randomZ);
    }
}