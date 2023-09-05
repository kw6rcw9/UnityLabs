using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(Rigidbody rb, float speed)
        {

             float x = Input.GetAxis("Horizontal");
             float z = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(x * speed, rb.velocity.y, z * speed);
        }

        public void Jump(Rigidbody rb, float force)
        {
            rb.AddForce(Vector3.up * force);
        }

        public void Rotate(Rigidbody rb, float speed, Transform transform)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 rotationInput = new Vector3(x * speed,
                0, z * speed);
            if (rotationInput.magnitude > 0.1f)
            {
                
                Quaternion rotation = Quaternion.LookRotation(rotationInput);
                  
                rotation.x = 0;
                rotation.z = 0;
                
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
            }

        }
    }
}
