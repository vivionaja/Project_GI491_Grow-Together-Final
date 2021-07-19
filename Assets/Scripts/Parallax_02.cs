using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_02 : MonoBehaviour
{
    BoxCollider2D boxCollider;
    Rigidbody2D rb;
    float width;
    float speed = -1f;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = boxCollider.size.x;
        rb.velocity = new Vector2(speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            Reposition();
        }
    }

    void Reposition()
    {
        Vector2 vector = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
