using UnityEngine;

public class CompararVectores : MonoBehaviour
{
    public Vector3 vectorA = new Vector3(0f, 1f, 0f);
    public Vector3 vectorB = new Vector3(1f, 2f, 0f);

    public float magnitudA;
    public float magnitudB;
    public float angulo;
    public float distancia;

    void Start()
    {
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;
        angulo = Vector3.Angle(vectorA, vectorB);
        distancia = Vector3.Distance(vectorA, vectorB);

        Debug.Log("Magnitud A: " + magnitudA);
        Debug.Log("Magnitud B: " + magnitudB);
        Debug.Log("Ángulo: " + angulo + " grados");
        Debug.Log("Distancia: " + distancia);

        if (vectorA.y > vectorB.y)
            Debug.Log("El vector A está a mayor altura.");
        else if (vectorB.y > vectorA.y)
            Debug.Log("El vector B está a mayor altura.");
        else
            Debug.Log("Ambos vectores están a la misma altura.");
    }
}