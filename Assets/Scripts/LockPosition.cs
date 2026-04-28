using UnityEngine;

public class LockPosition : MonoBehaviour
{
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void LateUpdate()
    {
        transform.position = initialPosition;
    }
}