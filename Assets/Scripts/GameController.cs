using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Image hearts;
    public GameObject objects;
    public GameObject buttons;
    // Start is called before the first frame update
    void Start()
    {
        
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
        buttons.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart_Game(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void exit_menu(){
        SceneManager.LoadScene("main_menu");
    }

}
