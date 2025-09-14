using UnityEngine;

public class TestMainCamera : MonoBehaviour
{
    void Start()
    {
        if (Camera.main != null)
        {
            Debug.Log("¡Camera.main detectada correctamente! Cámara: " + Camera.main.name);
        }
        else
        {
            Debug.LogError("Camera.main NO está detectada. Revisa que alguna cámara tenga la etiqueta 'MainCamera'.");
        }
    }
}
