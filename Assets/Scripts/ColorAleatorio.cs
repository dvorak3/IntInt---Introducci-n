using UnityEngine;

public class ColorAleatorio : MonoBehaviour
{
    public int framesDeEspera = 120;

    private Renderer renderizador;
    private int framesTranscurridos;

    void Start()
    {
        renderizador = GetComponent<Renderer>();
    }

    void Update()
    {
        framesTranscurridos++;

        if (framesTranscurridos >= framesDeEspera)
        {
            Vector3 componentes = new Vector3(
                Random.value, Random.value, Random.value
            );

            renderizador.material.color = new Color(
                componentes.x, componentes.y, componentes.z
            );

            framesTranscurridos = 0;
        }
    }
}