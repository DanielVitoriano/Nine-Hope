using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throw_hook : MonoBehaviour
{

    private int throws = 1;
    private GameObject player;
    private float distance;
    [Header("OBJETO DE DISPARO")]
    public GameObject hook;
    [Header("DISTANCIA PARA DISPARAR")]
    public float throw_houk_distance;
    [Header("TEMPO DE RECARGA")]
    public float realod_hook;

    private void Throw_hook(){
        Instantiate(hook, transform.position, transform.rotation);
        throws --;
        StartCoroutine(realod());
    }
    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update() {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance <= throw_houk_distance && throws >= 1){
            Throw_hook();
        }
        
    }

    IEnumerator realod(){
        yield return new WaitForSeconds(realod_hook);
        throws ++;
    }
    
}
