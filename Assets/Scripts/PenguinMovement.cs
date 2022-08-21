using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class PenguinMovement : MonoBehaviour
{



    [SerializeField] float Speed = 60.0f;
    private float Vertical;
    private float Horizontal;
    private Rigidbody2D rigidBody2D;
    private bool CanWalk = true;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //if(Horizontal < 0)
        //{
        //    //transform.eulerAngles = new Vector3(0, 180, 0);

        //}
        //else
        //{
        //    transform.eulerAngles = new Vector3(0, 180, 0);
        //}
        if (rigidBody2D.velocity.x < 0 && !spriteRenderer.flipX)
        {
            spriteRenderer.flipX = true;
        }
        else if (rigidBody2D.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        rigidBody2D.velocity = Vector2.ClampMagnitude(new Vector2(Horizontal, Vertical), 1) * Speed * Time.deltaTime;
    }
}
