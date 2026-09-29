using UnityEngine;

public class DistanciasObjetos : MonoBehaviour
{
    public Transform cubo;
    public Transform cilindro;

    void Start()
    {
        Debug.Log("Distancia de la esfera al cubo: " +
                  Vector3.Distance(transform.position, cubo.position));

        Debug.Log("Distancia de la esfera al cilindro: " +
                  Vector3.Distance(transform.position, cilindro.position));
    }
}