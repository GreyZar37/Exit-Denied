using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamster : MonoBehaviour
{

    public float Speed = 100;
    public Rigidbody rb;

    public float RotationSpeed = 100;

 

 
    void Update()
    {

        Vector3 movement = new Vector3();

        if(Input.GetKey(KeyCode.W))
        {
            movement += transform.forward; 
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotationSpeed*Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 200);
        }

        movement.y = rb.velocity.y;

        rb.velocity = new Vector3(movement.x*Speed * Time.deltaTime, movement.y, movement.z *Speed * Time.deltaTime);


    }
}
