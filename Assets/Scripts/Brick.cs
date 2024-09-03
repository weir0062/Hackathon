using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hitsToBreak = 2;
    public Sprite DefaultSprite;
    public Sprite BrokenSprite;



    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = DefaultSprite;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitsToBreak--;

        if (hitsToBreak == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = BrokenSprite;

        }
        if (hitsToBreak <= 0)
        {
            Destroy(gameObject);
        }
    }
}
