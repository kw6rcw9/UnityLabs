using UnityEngine;

namespace PlayerSystem
{
    public class PlayerMovement
    {
        public void Move(float x, float z, Rigidbody rb, float speed)
        {

             
            rb.velocity = new Vector3(x * speed, rb.velocity.y, z * speed);
        }

        public void Jump(Rigidbody rb, float force)
        {
            rb.AddForce(Vector3.up * force);
        }

        public void Rotate(float x, float z, Rigidbody rb, float speed, Transform transform)
        {
            
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
