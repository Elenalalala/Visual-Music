using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController player;
    

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    Vector3 velocity;
   

    // Update is called once per frame
    void Update()
    {

        // reset the gravity
        if(player.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && player.isGrounded)
        {
            // this is a jumping physics equation
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        player.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        player.Move(velocity * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("run in collision function");
        if (other.gameObject.CompareTag("Hint"))
        {
            //openCanvas();
            Debug.Log("collide with player");
        }

    }
}
