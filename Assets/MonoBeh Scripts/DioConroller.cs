using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioConroller : MonoBehaviour
{
    public float health = 100; 
    public float speed;
    public float jumpForce;
    public float moveInput;
    private Rigidbody2D rb;
    private bool racingface = true;
    private bool idGround;
    public Transform feetPose;
    public bool IsLayerMask;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Animator anim;
    public void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (racingface == false && moveInput > 0)
        {
            Flip();
        }
        else if (racingface == true && moveInput < 0)
        {
            Flip();
        }
        if (moveInput == 0)
        {
            anim.SetBool("Walk", false);
        }
        else
        {
            anim.SetBool("Walk", true);
        }
    }
    private void Update()
    {
        idGround = Physics2D.OverlapCircle(feetPose.position, checkRadius, whatIsGround);
        if(idGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("take off");
        }
        if (idGround == true)
        {
            anim.SetBool("IsJumping", false);
        }
        else if (idGround == false)
        {
            anim.SetBool("IsJumping", true);

        }
    }
    void Flip()
    {
        racingface = !racingface;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
