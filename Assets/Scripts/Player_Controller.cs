using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    float horizontalInput;
    public float forceSpeed = 3;
    private bool faceRight;
    private Rigidbody2D playerRb;
    private bool isOnGround = true;
    public int points = 0;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // player input
        if (Input.GetKey("right"))
        {
            // moving player using it's transform component
            transform.Translate (Vector3.right * Time.deltaTime * forceSpeed);
            // faceRight = true;
        }
        else if (Input.GetKey("left"))
        {
            transform.Translate (Vector3.left * Time.deltaTime * forceSpeed);
        }

        // player jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * forceSpeed, ForceMode2D.Impulse);
            // isOnGround = false;
        }
    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.gameObject.CompareTag("Ground"))
    //     {
    //         isOnGround = true;
    //     }
    // }

}
