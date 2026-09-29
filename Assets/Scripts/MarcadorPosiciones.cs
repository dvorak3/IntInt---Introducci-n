using UnityEngine;

public class MarcadorPosiciones : MonoBehaviour
{
    public ObjetoDesplazable esfera;
    public ObjetoDesplazable cubo;
    public ObjetoDesplazable cilindro;

    public Vector3 desplazamientoEsfera = new Vector3(0f, 2f, 0f);
    public Vector3 desplazamientoCubo = new Vector3(2f, 0f, 0f);
    public Vector3 desplazamientoCilindro = new Vector3(-2f, 0f, 0f);

    private bool espacioPulsado;

    private bool objetosDesplazados;

    void Update()
    {
        bool pulsadoAhora = Input.GetAxis("Jump") > 0f;

        if (pulsadoAhora && !espacioPulsado)
        {
            if (!objetosDesplazados)
            {
                esfera.desplazamiento = desplazamientoEsfera;
                cubo.desplazamiento = desplazamientoCubo;
                cilindro.desplazamiento = desplazamientoCilindro;

                esfera.AplicarDesplazamiento();
                cubo.AplicarDesplazamiento();
                cilindro.AplicarDesplazamiento();
            }
            else
            {
                esfera.VolverAlOrigen();
                cubo.VolverAlOrigen();
                cilindro.VolverAlOrigen();
            }

            objetosDesplazados = !objetosDesplazados;
        }

        espacioPulsado = pulsadoAhora;
    }
}