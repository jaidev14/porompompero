using UnityEngine;

namespace Sanktuary.Sometimes.Resources
{
    public class FloatingController : MonoBehaviour {

        [Header("Floating Variables")]
        public float amplitude;         // Amplitude of the floating movement
        public float speed;             // Speed of the floating movement
        private Vector3 initPos;
        [SerializeField] private bool X = false;
        [SerializeField] private bool Y = false;
        [SerializeField] private bool Z = false;
        private Vector3 currentPos;     // Current position of the treasure

        void Start () 
        {
            initPos = transform.position;
            currentPos = initPos;
        }

        void Update () 
        {   
            currentPos = transform.position;
            if (X) {
                currentPos.y = transform.position.y;
                currentPos.x = initPos.x + amplitude * Mathf.Sin(speed * Time.time);
            } 
            if (Y) {
                currentPos.x = transform.position.x;
                currentPos.y = initPos.y + amplitude * Mathf.Sin(speed * Time.time);
            }
            if (Z) {
                currentPos.y = transform.position.y;
                currentPos.z = initPos.z + amplitude * Mathf.Sin(speed * Time.time);  
            }
            transform.position = currentPos;
        }
    }
}
