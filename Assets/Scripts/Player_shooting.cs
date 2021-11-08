using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_shooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform spaw_bullet;

    public void shooting(){
        Instantiate(bullet, spaw_bullet.position, spaw_bullet.rotation);
    }

}
