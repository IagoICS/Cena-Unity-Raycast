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
          
            Destroy(gameObject);

          
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(cubePrefab, transform.position, Quaternion.Euler(spawnPosition));
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(75f, 80f);
        float randomY = transform.position.y; 
        float randomZ = transform.position.z; 

        return new Vector3(randomX, randomY, randomZ);
    }
}
