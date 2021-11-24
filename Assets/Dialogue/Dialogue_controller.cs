using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_controller : MonoBehaviour
{

    [System.Serializable]
    public enum language{
        pt, eng, spa
    }
    public language languages;

    [Header("COMPONENTS")]
    public GameObject dialogueObj;
    public Image profileSprite;
    public Text speechText;
    public Text actorNameText;

    [Header("SETTINGS")]
    public float typingSpeed;

    //controle
    private bool isShowing;
    private int index;
    private string[] sentences;
    private Sprite[] images_profile;

    public static Dialogue_controller instance;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator typeSentences(){
        foreach(char letter in sentences[index].ToCharArray()){
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence(){ //próxima frase
        if(speechText.text == sentences[index]){
            if(index < sentences.Length - 1){
                index++;
                speechText.text = "";
                profileSprite.sprite = images_profile[index];
                StartCoroutine(typeSentences());
            }
            else{//termina os textos
                speechText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                sentences = null;
                isShowing = false;
                GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().end_intro();
            }
        }
    }
    public void Speech(string[] txt, Sprite[] images){ //falar com npc
        if(!isShowing){
            dialogueObj.SetActive(true);
            sentences = txt;
            images_profile = images;
            profileSprite.sprite = images_profile[index];
            StartCoroutine(typeSentences());
            isShowing = true;
        }
    }

}
