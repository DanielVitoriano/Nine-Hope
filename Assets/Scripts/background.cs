using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public Transform bg1, bg2;
    public float min_Ypos, rest_Ypos, speed;
    private Vector3 dir = new Vector2(0, 1);

    private void Update() {
        if(bg1.position.y < min_Ypos){
            bg1.position = new Vector2(0, rest_Ypos);
        }
        else if(bg2.position.y < min_Ypos){
            bg2.position = new Vector2(0, rest_Ypos);
        }
    }
    private void FixedUpdate() {
        bg1.position -= dir * speed * Time.deltaTime;
        bg2.position -= dir * speed * Time.deltaTime;
    }
    
}
