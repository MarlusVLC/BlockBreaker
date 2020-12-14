using System.Collections;
using System.Collections.Generic;
using Lunari.Tsuki.Runtime;
using UnityEngine;

public class jogador : MonoBehaviour
{
    public float Velocidade = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D rb;


    private void Start()
    {


        //Lunari.Tsuki.Runtime.GameObjects.CreateWith<BoxCollider2D>();

                                  
        Lunari.Tsuki.Runtime.GameObjects.GetOrAddComponent<BoxCollider2D>(this.gameObject);

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis =Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Velocidade * HorizontalAxis, 0);
    }
}
