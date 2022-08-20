using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    public float Speed = 1.0f;
    private float Vertical;
    private float Horizontal;
    private Rigidbody2D Rigidbody2D;
    private bool CanWalk = true;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        if (Physics2D.Raycast(transform.position, transform.forward, 0.1f))
        {
            CanWalk = true;
        }
        else
        {
            CanWalk = false;
        }
    }

    private void FixedUpdate()
    {
        if (CanWalk)
        {
            Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Vertical * Speed);
        } else
        {
            Rigidbody2D.velocity = Vector2.zero;
        }
    }
}
