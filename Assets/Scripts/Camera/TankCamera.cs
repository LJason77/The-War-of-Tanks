using UnityEngine;

namespace Camera
{
    public class TankCamera : MonoBehaviour
    {
        public Transform target;

        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}
