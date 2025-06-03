// follow object with a space of -15 and 30
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target; // The object to follow
    public Vector3 offset = new Vector3(0, 5, 10); // Offset from the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Set the camera position based on the target's position and the offset
            transform.position = target.position + offset;
            // Optionally, make the camera look at the target
            transform.LookAt(target);
        }
    }
}