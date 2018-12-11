using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb2d;

	// Use this for initialization
	void Start()
    {
        float rand = Random.Range(0, 2);
        int direction = rand > 1 ? 1 : -1;
        Vector2 v = new Vector2(direction * speed, 0);
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(v);
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            float x = rb2d.velocity.x;
            float y = (rb2d.velocity.y / 2) +
                (collision.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = new Vector2(x, y);
        }
    }
}
