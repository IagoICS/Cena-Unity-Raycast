using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linha : MonoBehaviour
{
    public float distanciaMaxima = 10f;
    public Color corAmarela = Color.yellow;
    public Color corVermelha = Color.red;

    private GameObject linhaGameObject;
    public LineRenderer linhaRenderer;

    public Transform cameraTransform;

    private void Start()
    {
        

        
        if (linhaRenderer == null)
        {
            linhaGameObject = new GameObject("Linha");
            linhaRenderer = gameObject.AddComponent<LineRenderer>();
            linhaRenderer.startWidth = 0.1f;
            linhaRenderer.endWidth = 0.1f;
        }

    
        linhaRenderer.material.color = corAmarela;
    }

    private void Update()
    {
        Vector3 direcao = cameraTransform.forward;
        Ray ray = new Ray(transform.position, direcao);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, distanciaMaxima))
        {
        
            linhaRenderer.SetPosition(0, transform.position);
            linhaRenderer.SetPosition(1, hitInfo.point);

        
            linhaRenderer.material.color = corVermelha;
        }
        else
        {
          
            Vector3 endPoint = transform.position + direcao * distanciaMaxima;
            linhaRenderer.SetPosition(0, transform.position);
            linhaRenderer.SetPosition(1, endPoint);

        
            linhaRenderer.material.color = corAmarela;
        }
    }

    private void OnDestroy()
    {
        
        if (linhaGameObject != null)
            Destroy(linhaGameObject);
    }
}