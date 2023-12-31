using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Transform camera;

    public CharacterController characterController;

    public float speed = 4f;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        // Look for input from wasd
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
                

        if (direction.magnitude >= 0.1f)
        {
            //Change where character looks.
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            //Movement
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            characterController.Move(moveDirection * speed * Time.deltaTime);
        }
    }
}
