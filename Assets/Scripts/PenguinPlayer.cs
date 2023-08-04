using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PenguinPlayer : MonoBehaviour
{
    public MovementJoystick movementJoystick;
    public float playerSpeed;
    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        if(movementJoystick.joystickVec.y != 0)
        {
            float xInput = movementJoystick.joystickVec.x;

            if (xInput < 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if(xInput > 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
