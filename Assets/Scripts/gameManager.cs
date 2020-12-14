using System.Collections;
using System.Collections.Generic;
using tsukiRT = Lunari.Tsuki.Runtime;
using tuskiED = Lunari.Tsuki.Editor;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject pointerArrow;

    //SINGLETON begin

    private static gameManager INSTANCE;

    public static gameManager getInstance { get { return INSTANCE; } }

    private void Awake()
    {
        if (INSTANCE != null && INSTANCE != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            INSTANCE = this;
        }
    }
    //SINGLETON end

    private void Start()
    {
        tsukiRT.Objects.Clone(player, new Vector2(player.transform.position.x + 20,
                                player.transform.position.y));
    }

    private void FixedUpdate()
    {
        ball.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.75f, -0.01f);
        //Lunari.Tsuki.Runtime.Debugging.DrawWireBox2D(new Vector2(0, 0), new Vector2(2, 1), Color.cyan);
        }

    public void respawnBall()
    {
        Vector3 respawnPos = new Vector3(player.transform.position.x, player.transform.position.y + 0.75f, -0.01f);
        ball = Instantiate(ball, respawnPos, Quaternion.identity);
        ball.name = "Bola";
    }

    //public void fixBallPosition()
    //{
    //    ball.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.75f, -0.01f);
    //}
}
