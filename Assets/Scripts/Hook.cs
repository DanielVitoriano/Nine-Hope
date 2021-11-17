using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public float speed;
    public float time_alive;
    public float damage;
    private Vector2 dir;

    private void Start() {
        dir = GameObject.FindGameObjectWithTag("Player").transform.position - transform.position;
        StartCoroutine(destroy());
    }
    private void FixedUpdate() {
        transform.Translate(dir* speed * Time.deltaTime);
    }

    IEnumerator destroy(){
        yield return new WaitForSeconds(time_alive);
        Hit();
    }

    public void Hit(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 6){
            other.gameObject.GetComponent<Player_life>().Hit(damage);
            Hit();
        }
    }

}