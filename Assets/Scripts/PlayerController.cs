using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Expose Values
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {
    // Public Variables!
    public float speed;
    public Boundary boundary;

    // Private Variables!
    Rigidbody2D rBody;

    // Use this for initialization
    void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    // Fixed Update, this is used for physics, guaranted to run at a constant rate!

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal,moveVertical);

        rBody.velocity = movement * speed;

        rBody.position = new Vector2(Mathf.Clamp(rBody.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rBody.position.y, boundary.yMin, boundary.yMax));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
