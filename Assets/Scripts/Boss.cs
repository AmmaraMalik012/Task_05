using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
     private Vector3 pos1 = new Vector3(-14,5.7f,0);
     private Vector3 pos2 = new Vector3(14,5.7f,0);
     public float speed = 0.5f;
 
     void Update()
     {
        //boss horizontal movement
        transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
     }
}
