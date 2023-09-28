using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float sensitivity = 0.5f; // can adjust later
    private Vector2 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 delta = (Vector2)Input.mousePosition - lastMousePosition;
            float rotationX = delta.y * sensitivity;
            float rotationY = delta.x * sensitivity;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x - rotationX, transform.eulerAngles.y - rotationY, transform.eulerAngles.z);
        lastMousePosition = Input.mousePosition;
        }
    }
}