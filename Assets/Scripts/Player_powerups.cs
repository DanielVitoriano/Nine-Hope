using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_powerups : MonoBehaviour
{

    // valores padrões
    private float default_speed;
    [Header("Power Up Attributes")]
    // valores dos power ups
    public float power_up_time;
    public float speed_increase;
    void Start()
    {
        default_speed = gameObject.GetComponent<Player_movement>().speed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 7){
            Power_up(other.gameObject.GetComponent<axolote>().axolote_mod);
            Destroy(other.gameObject);
            StartCoroutine(Power_up_time());
        }
    }

    private void Power_up(int mod){
        // power up 0 //setar os valores para os valores padrões e desativar qualquer efeito de habilidade
        if(mod == 0){
            gameObject.GetComponent<Player_movement>().speed = default_speed;
        }

        // power up 1//
        if(mod == 1){
            gameObject.GetComponent<Player_movement>().speed += speed_increase;
        }

        // power up 2//

        // power up 3//

        // power up 4//

        // power up 5//

    }

    IEnumerator Power_up_time(){
        yield return new WaitForSeconds(power_up_time);
        Power_up(0);
    }

}
