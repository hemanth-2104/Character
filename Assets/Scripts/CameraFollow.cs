using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target; 

   public float smoothspeed = 0.125f;
   public UnityEngine.Vector3 offset;

   void FixedUpdate()
   {
        UnityEngine.Vector3 desiredPosition = target.position + offset;
        UnityEngine.Vector3 smoothedPosition = UnityEngine.Vector3.Lerp ( transform.position, desiredPosition, smoothspeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
   }
}