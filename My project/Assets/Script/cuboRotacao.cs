using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboRotacao : MonoBehaviour
{
    public GameObject cubePrefab;
    public

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Destroy(collision.gameObject);
            // Destroi o cubo
            Destroy(gameObject);

            // Instancia um novo cubo a partir do prefab em uma posição aleatória
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(cubePrefab, transform.position, Quaternion.Euler(spawnPosition));
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(75f, 80f);
        float randomY = transform.position.y; // Mantém a mesma altura do cubo original
        float randomZ = transform.position.z; // Mantém a mesma profundidade do cubo original

        return new Vector3(randomX, randomY, randomZ);
    }
}