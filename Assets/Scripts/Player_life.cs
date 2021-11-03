using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    public float health;
    public GameController gc_script;
    private Collider2D coll;
    //private Animator animator_player;

    private void Start() {
        //animator_player = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }

    public void Hit(float damage){
        if(health >= 0){
            health -= damage;
            gc_script.att_health(health);
            //animator_player.SetInteger("hit", 1);
            coll.enabled = false;
            StartCoroutine(finish_anim_hit());
        }
        else{
            GetComponent<Player_movement>().enabled = false;
        }
    }

    IEnumerator finish_anim_hit(){
        yield return new WaitForSeconds(0.833f);
        //animator_player.SetInteger("hit", 0);
        coll.enabled = true;
    }
}
