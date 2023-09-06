using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField] float moveSpped = 5f;
    Rigidbody2D rb;
    Animator myAnimator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    public void Update()
    {
        Move();
    }

    public void Move()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 getVel = new Vector3(horizontalInput, verticalInput, 0) * moveSpped;
        rb.velocity = getVel;

        myAnimator.SetFloat("MoveX", horizontalInput);
        myAnimator.SetFloat("MoveY", verticalInput); 


    }
}
