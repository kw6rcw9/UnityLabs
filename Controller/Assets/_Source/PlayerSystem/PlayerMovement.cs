using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(Rigidbody rb, float speed)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(x * Time.deltaTime * speed, rb.velocity.y, z * Time.deltaTime * speed);
        }

        public void Jump(Rigidbody rb, float force)
        {
            rb.AddForce(new Vector3(0,force, 0), ForceMode.Force );
        }

        public void Rotate(Rigidbody rb, float speed)
        {
            //
        }
    }
}
