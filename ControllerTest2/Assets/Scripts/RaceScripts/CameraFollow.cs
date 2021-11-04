using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private int physicUpdateCount = 0;
    // This value will change at the runtime depending on target movement. Initialize with zero vector.
    private Vector3 velocity = Vector3.zero;


    void FixedUpdate()
    {
        if (physicUpdateCount % 2 == 0)
        {

            Vector3 desiredPosition = target.position + target.transform.rotation * offset;

            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            //Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

            transform.position = smoothedPosition;

            transform.LookAt(target);
            Vector3 targetRotation = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, target.transform.eulerAngles.z);
            transform.rotation = Quaternion.Euler(targetRotation);

        }
        physicUpdateCount++;

    }
}