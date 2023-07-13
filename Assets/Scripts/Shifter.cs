using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shifter : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D RB2D;
    private Vector2 moveInput;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        moveInput.x = Input.GetAxis("Mouse X");
        moveInput.y = Input.GetAxis("Mouse Y");
        moveInput.Normalize();
        RB2D.velocity = (moveInput * moveSpeed) * Time.deltaTime;
    }
}
