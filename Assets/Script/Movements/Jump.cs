using UnityEngine;
using UnityEngine.Serialization;

namespace Script
{
    public class Jump : MonoBehaviour
    {
        private Rigidbody _rb;
       // public Animator anim;
        private bool _jump;
       [SerializeField] private LayerMask ground;
       [SerializeField] private Transform tf;
       [SerializeField] private float force = 3f;
      
        void Awake()
        {
            _rb = GetComponent<Rigidbody>();
           // anim = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {

            _jump = Physics.Raycast(tf.position, Vector2.down, 3f, ground);
            // condición para que no haga doble salto
            if (Input.GetKeyDown(KeyCode.Space) && _jump)
            {
                _rb.AddForce(Vector3.up * force, ForceMode.Impulse);

            }

        }

        void OnDrawGizmosSelected()
        {
            // Draws a 5 unit long red line in front of the object  
            Gizmos.color = Color.red;
            Vector3 direction = tf.TransformDirection(Vector3.down) * 3;
            Gizmos.DrawRay(tf.position, direction);
        }
    }
}