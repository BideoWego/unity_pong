using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerType;
    public float speed;
    public Rigidbody2D rb2d;

	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        Vector2 pos = transform.position;

        bool isPressed = Input.GetButton("Vertical " + playerType);
        float direction = Input.GetAxisRaw("Vertical " + playerType);

        if (isPressed)
        {
            pos.y += Time.deltaTime * direction * speed;
        }

        transform.position = new Vector2(pos.x, pos.y);
    }
}
