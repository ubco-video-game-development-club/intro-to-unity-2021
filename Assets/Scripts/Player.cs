using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. change the Transform component (specifically the x position value)
        // 2. only do this when the player pressed A or D (or arrow keys)
        float xInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(xInput, 0, 0) * speed * Time.deltaTime;

        // If the spacebar is pressed on this frame
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Blast the player in the air!
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
