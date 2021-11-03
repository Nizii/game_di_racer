using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private int physicUpdateCount = 0;

    void FixedUpdate()
    {
        if (physicUpdateCount % 2 == 0)
        {

                Vector3 desiredPosition = target.position + target.transform.rotation * offset;
                Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothedPosition;
                //transform.rotation = Quaternion.LookRotation(target.transform.forward, target.transform.up);

                transform.LookAt(target);
        }
        physicUpdateCount++;

    }
}
