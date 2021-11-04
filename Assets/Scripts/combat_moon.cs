using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat_moon : MonoBehaviour
{
    public float increase;
    public Transform obj_child, target;
    private float z;
    private Vector3 rotation;
    void Start()
    {
        
    }
    private void Update() {
        z += increase;
        rotation = new Vector3(0, 0, z);

        if(transform.rotation.z >= 360) z =0;
    }

    private void FixedUpdate() {
        transform.eulerAngles = rotation;
        obj_child.eulerAngles = rotation * -1;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer != 7){
            Destroy(other.gameObject);
        }
    }
}
