using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{

    private Vector2 launchVector;
    [SerializeField] private float speed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Awake()
    {
        //TODO: fazer com que a bola seja instanciada num intervalo de 15 à 165 graus de ângulo mantendo a mesma velocidade.
        float angle = Random.Range(15f, 180f - 15f);

        Debug.Log("Angulo de lancamento: " + angle);

        float vectorX = Mathf.Cos(angle * (Mathf.PI / 180)) * speed;
        float vectorY = Mathf.Sin(angle * (Mathf.PI / 180)) * speed;

        launchVector = new Vector2(vectorX, vectorY);


    }

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(launchVector);
    }



}
