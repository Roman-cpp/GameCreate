using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    public float gravity;
    public float jumpForce;
    public float speed;
    public float jspeed = 0;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (_characterController.isGrounded)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            jspeed = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jspeed = jumpForce;
            }
        }

        jspeed += gravity * Time.deltaTime * 3f;
        Vector3 dir = new Vector3(horizontal * speed * Time.deltaTime, jspeed * Time.deltaTime,
            vertical * speed * Time.deltaTime);

        _characterController.Move(dir);
    }
}
