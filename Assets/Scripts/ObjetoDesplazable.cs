using UnityEngine;

public class ObjetoDesplazable : MonoBehaviour
{
    public Vector3 desplazamiento;

    private Vector3 posicionOriginal;

    void Start()
    {
        posicionOriginal = transform.position;
    }

    public void AplicarDesplazamiento()
    {
        transform.position = posicionOriginal + desplazamiento;
    }

    public void VolverAlOrigen()
    {
        transform.position = posicionOriginal;
    }
}
