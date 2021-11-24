using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject axolote_mounted;
    public GameObject intro;
    public Image hearts;
    public GameObject objects;
    public GameObject menu_buttons, buttons, hearts_menu;
    // Start is called before the first frame update
    void Start()
    {
        menu_buttons.SetActive(false);
        buttons.SetActive(false);
        objects.SetActive(false);
        hearts_menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void att_health(float health){
       hearts.fillAmount = health / 3;
       if(health <= 0) Game_Over();
    }

    public void Game_Over(){
        //objects.GetComponent<obstacle_movement>().enabled = false;
        menu_buttons.SetActive(true);
        buttons.SetActive(false);
        pause(0);
    }
    public void Restart_Game(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        buttons.SetActive(true);
        pause(1);
    }
    public void pause(int value){
        Time.timeScale = value;
    }

    public void exit_menu(){
        SceneManager.LoadScene("main_menu");
    }
    public void end_intro(){
        menu_buttons.SetActive(false);
        buttons.SetActive(true);
        objects.SetActive(true);
        hearts_menu.SetActive(true);
        Destroy(intro);
        axolote_mounted.SetActive(true);
    }

}
