using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboDirecao : MonoBehaviour
{

  public GameObject cubePrefab;
    public float movementSpeed = 2.0f;
    public float maxX = 5.0f;
    public float minX = -5.0f;

    private bool movingRight = true;

    void Start()
    {
        StartCoroutine(MoveCube());
    }

    IEnumerator MoveCube()
    {
        while (true)
        {
           
            if (movingRight)
            {
                transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

                if (transform.position.x >= maxX)
                    movingRight = false;
            }
            else
            {
                transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

                if (transform.position.x <= minX)
                    movingRight = true;
            }

            yield return null;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

            
            Vector3 spawnPosition = GetRandomSpawnPosition();
            Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = transform.position.y; 
        float randomZ = transform.position.z; 

        return new Vector3(randomX, randomY, randomZ);
    }
}