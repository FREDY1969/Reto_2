using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public string escenaDestino; // Nombre de la escena de destino

    public void CambiarAEscenaDestino()
    {
        SceneManager.LoadScene(escenaDestino);
    }
}
