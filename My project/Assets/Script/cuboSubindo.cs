using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboSubindo : MonoBehaviour
{
   public GameObject cubePrefab;
    public float movementSpeed = 2.0f;
    public float maxHeight = 5.0f;
    public float minHeight = 0.0f;

    private bool movingUp = true;

    void Update()
    {
        
        if (movingUp)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);

            if (transform.position.y >= maxHeight)
                movingUp = false;
        }
        else
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

            if (transform.position.y <= minHeight)
                movingUp = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {

            Destroy(gameObject);

           
            Vector3 spawnPosition = GetRandomSpawnPosition();
            GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

         
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = transform.position.x; // Mantém a mesma posição horizontal do cubo original
        float randomY = Random.Range(minHeight, maxHeight);
        float randomZ = transform.position.z; // Mantém a mesma posição em profundidade do cubo original

        return new Vector3(randomX, randomY, randomZ);
    }
}
