using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed;
  public float jumpAmount;
  float inputMovement;
  Rigidbody2D rb;

 bool touchesGround;
 public Transform groundChecker;
 public LayerMask groundMask;

 public float radius;


 void Start()
 {
  rb = GetComponent<Rigidbody2D>();

 }

 private void FixedUpdate()
 {
    touchesGround = Physics2D.OverlapCircle(groundChecker.position, radius, groundMask);
    inputMovement = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(inputMovement * speed, rb.velocity.y);
 }


void Update()
{
    if (touchesGround && Input.GetKeyDown(KeyCode.UpArrow))
    {
        rb.velocity = Vector2.up * jumpAmount;

    }


}



}