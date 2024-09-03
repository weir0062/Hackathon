using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D body;
    public bool InGame = true;
    public GameObject BallSpawnPoint;
    public float BallSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!InGame)
        {
            transform.position = BallSpawnPoint.transform.position;
            body.velocity = Vector2.zero; // Сбрасываем скорость перед запуском
        }
        if (Input.GetKey(KeyCode.Space) && !InGame)
        {
            InGame = true;
            body.velocity = Vector2.up * BallSpeed; // Задаем стабильную скорость
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bottom")
        {
            Debug.Log("YOU LOSE BITCH HAHAHHAHA");
            body.velocity = Vector2.zero;
            InGame = false;
        }
    }
}
