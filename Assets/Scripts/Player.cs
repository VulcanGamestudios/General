using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed;
    public float jumpForce;
    Rigidbody2D rb;
    Vector3 refVelocity = Vector3.zero;
    bool grounded = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector3.SmoothDamp(rb.velocity, new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y), ref refVelocity, 0.05f);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            grounded = false;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
