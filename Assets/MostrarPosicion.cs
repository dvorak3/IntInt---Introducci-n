using TMPro;
using UnityEngine;

public class MostrarPosicion : MonoBehaviour
{
    public TMP_Text textoPosicion;

    void Update()
    {
        textoPosicion.text = "Posición de la esfera: " + transform.position;
    }
}