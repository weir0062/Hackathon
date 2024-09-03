using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int hitsToBreak = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitsToBreak--;
        if (hitsToBreak <= 0)
        {
            Destroy(gameObject);
        }
    }
}
