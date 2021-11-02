using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    public float speed;
    public FixedJoystick joystick;
    private Vector2 movement;
    private Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void FixedUpdate() {
        playerRB.MovePosition(playerRB.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    void move(){
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f), Mathf.Clamp(transform.position.y, -3.2f, 1000f), transform.position.z);
    }
}
