using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
    public Transform target;
    void Update()
    {
        faceMouse();
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 direction = new Vector3(
            
            targetPosition.x - transform.position.x,
            targetPosition.y = 0,
            targetPosition.z - transform.position.z
            );

        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;

    }
}
