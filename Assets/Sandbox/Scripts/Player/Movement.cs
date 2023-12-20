using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    private Vector2 inputVector;

    [SerializeField] private float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        GetInputWithKeys();
        MovePlayer();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    private void GetInputWithKeys()
    {
        Vector2 input = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            input.y = +1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            input.y = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            input.x = +1;
        }

        inputVector = input.normalized;
    }
    private void MovePlayer()
    {
        Vector3 moveDirection = new Vector3(inputVector.x
            , 0.0f,
            inputVector.y);

        transform.position += moveDirection * speed * Time.deltaTime;


        transform.forward = Vector3.Slerp(transform.forward,moveDirection, Time.deltaTime * speed);

        //transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
