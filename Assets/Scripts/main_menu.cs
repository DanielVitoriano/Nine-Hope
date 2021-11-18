using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    public void start_game(){
        SceneManager.LoadScene("fase1");
    }
    public void exit_game(){
        Application.Quit();
    }
}
