using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shooting : MonoBehaviour
{
    [Header("OBJETO DO TIRO")]
    public GameObject bullet;
    [Header("LOCAL DE SPAWN DO TIRO")]
    public Transform spaw_bullet;
    [Header("TEMPO DE RECARGA")]
    public float realod_time;
    private int shots = 1;

    public void shooting(){
        if(shots >= 1){
            Instantiate(bullet, spaw_bullet.position, spaw_bullet.rotation);
            shots --;
            StartCoroutine(reload());
        }
    }

    IEnumerator reload(){
        yield return new WaitForSeconds(realod_time);
        shots ++;
    }

}
