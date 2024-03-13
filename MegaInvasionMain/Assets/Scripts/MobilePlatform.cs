using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public float velocidad = 2.0f; // Velocidad de movimiento de la plataforma
    public float distancia = 4.0f; // Distancia total que recorrer� la plataforma
    public Vector3 direccion = Vector3.up; // Direcci�n del movimiento, por defecto hacia arriba

    private Vector3 posicionInicial;
    private float tiempoInicio;

    void Start()
    {
        posicionInicial = transform.position;
        tiempoInicio = Time.time;
    }

    void Update()
    {
        // Calcula el desplazamiento actual basado en el tiempo
        float desplazamiento = (Mathf.Sin((Time.time - tiempoInicio) * velocidad) + 1.0f) * 0.5f * distancia;

        // Calcula la nueva posici�n de la plataforma
        Vector3 nuevaPosicion = posicionInicial + direccion * desplazamiento;

        // Aplica la nueva posici�n a la plataforma
        transform.position = nuevaPosicion;
    }
}
