using UnityEngine;

public class CameraController : MonoBehaviour
{
    // public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public GameObject target;
    private void FixedUpdate()
    {
        Rigidbody rb = target.GetComponent<Rigidbody>();
        Vector3 desiredPosition = rb.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(rb.transform);

    }
}