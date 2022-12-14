using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int pt = 0;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            // script.points += 100;
            pt +=100;
        }
        else if(col.gameObject.tag == "Point")
        {
            // script.points += 100;
            pt +=100;
        }
    }
}
