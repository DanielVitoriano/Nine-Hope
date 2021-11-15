using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_powerups : MonoBehaviour
{

    // valores padrões
    private float default_speed;
    private int power_up_mod;
    [Header("Power Up Attributes")]
    // valores dos power ups
    public float power_up_time;
    public float speed_increase;
    public GameObject combat_moon;

    void Start()
    {
        default_speed = gameObject.GetComponent<Player_movement>().speed;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == 7){
            power_up_mod = other.gameObject.GetComponent<axolote>().axolote_mod;
            Destroy(other.gameObject);
            //Power_up(power_up_mod); // para teste
        }
    }

    private void Power_up(int mod){
        // power up 0 //setar os valores para os valores padrões e desativar qualquer efeito de habilidade
        switch(mod){
           case 0:
                gameObject.GetComponent<Player_movement>().speed = default_speed;
                combat_moon.SetActive(false);
                break;

            // power up 1//
            case 1:
                gameObject.GetComponent<Player_movement>().speed += speed_increase;
                combat_moon.SetActive(true);
                break;
                
            // power up 2//
            case 2:
                
                break;
            // power up 3//
            case 3:
                
                break;
            // power up 4//
            // power up 5//
        }
    }

    public void active_power_up(){
        Power_up(power_up_mod);
        StartCoroutine(Power_up_time()); 
    }

    IEnumerator Power_up_time(){
        yield return new WaitForSeconds(power_up_time);
        Power_up(0);
    }

}
