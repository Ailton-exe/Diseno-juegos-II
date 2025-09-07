using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DragController2D : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        // Calculamos el offset entre la posición del mouse y la posición del objeto
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z; // mantenemos Z del objeto
        offset = transform.position - mouseWorld;
    }

    void OnMouseDrag()
    {
        // Movemos el objeto siguiendo el mouse
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorld.z = transform.position.z; // mantenemos Z del objeto
        transform.position = mouseWorld + offset;
    }
}
