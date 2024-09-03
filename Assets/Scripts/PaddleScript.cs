using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float speed = 6.9f;

    float leftEdge = -12.69f;
    float rightEdge = 12.69f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        if(transform.position.x > leftEdge-0.01f && transform.position.x < rightEdge+0.01f)
        {

        transform.Translate(Vector2.right * inputX * Time.deltaTime * speed);
        }

        //safety checks

        if( transform.position.x < leftEdge)
        {
            transform.position = new Vector2( leftEdge, -4);
        }

        if (transform.position.x > rightEdge)
        {
            transform.position = new Vector2(rightEdge, -4);
        }
    }
}
