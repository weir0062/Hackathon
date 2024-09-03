using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D body;
    public bool InGame = true;
    public GameObject BallSpawnPoint;
    public float BallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!InGame)
        {
            transform.position = BallSpawnPoint.transform.position;
        }
        Debug.Log(body.velocity);
        if (Input.GetKey(KeyCode.Space) && !InGame)
        {
            InGame = true;
            body.AddForce(Vector2.up * BallSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bottom")
        {
            Debug.Log("YOU LOSE BITCH HAHAHHAHA");
            body.velocity = Vector2.zero;
            InGame = false;

        }
    }
}
