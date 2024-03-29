using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float traveled;
    private Vector2 init_pos;
    private float distance;

    private void Start() {
        init_pos = transform.position;
    }

    // Start is called before the first frame update
    private void Update() {
        distance = Vector2.Distance(transform.position, init_pos);
        if(distance >= traveled){
            destroy();
        }
    }

    private void FixedUpdate() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 8 || other.gameObject.layer == 10){
            other.gameObject.GetComponent<obstacle>().Hit();
            destroy();
        }
        if(other.gameObject.layer == 11){
            other.gameObject.GetComponent<Hook>().Hit();
        }
    }

    private void destroy(){
        Destroy(gameObject);
    }
}
