using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    [SerializeField]
    private float _speed, _health;
    public float damage;

    public float speed{
        get{return _speed;}
        set{_speed = value;}
    }
    public float health{
        get{return _health;}
        set{_health = value;}
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 6){
            other.gameObject.GetComponent<Player_life>().Hit(damage);
            Hit();
        }
    }
    public void Hit(){
        health--;
        if(health <= 0){
            Destroy(gameObject);
        }
    }
}
