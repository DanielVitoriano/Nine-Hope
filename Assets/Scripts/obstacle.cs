using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public float damage;

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
            destroy_self();
        }
    }
    public void destroy_self(){
        Destroy(gameObject);
    }
}
