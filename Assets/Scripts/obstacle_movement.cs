using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_movement : MonoBehaviour
{

    private GameObject[] gameObj_in_scene;
    private int i;
    private float speed;
    private Vector3 movement = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        att_objects_list();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        att_objects_list();
    }

    private void att_objects_list(){
        gameObj_in_scene = new GameObject[transform.childCount];

        foreach(Transform child in transform){
            gameObj_in_scene[i] = child.gameObject;
            speed = gameObj_in_scene[i].GetComponent<obstacle>().speed;
            gameObj_in_scene[i].transform.position -= movement * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 8){
            Destroy(other.gameObject);
        }
    }

}
