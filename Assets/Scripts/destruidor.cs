using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruidor : MonoBehaviour
{


    [SerializeField] private GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collider = collision.collider.gameObject;
        if (collider.tag.ToLower().Equals("bola"))
        {
            //gameManager.getInstance.respawnBall();
            //GameObject.Destroy(collider);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Destroy(collision.gameObject);
    }
}
