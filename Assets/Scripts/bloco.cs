using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloco : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D thisCollider;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        thisCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.collider.gameObject;
        if (collider.tag.ToLower().Equals("bola"))
        {
            rb.constraints = new RigidbodyConstraints2D();
            thisCollider.isTrigger = true;
        }
    }
}
