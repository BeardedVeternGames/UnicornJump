using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class scoremnger : MonoBehaviour{
public TextMeshProUGUI distancetext;
public TextMeshProUGUI personalbesttext;
private float distancescore;
private float personalbestscore;
private bool gameStart;
[SerializeField] GameObject unicorn;
[SerializeField] Button resetbtn;







    // Start is called before the first frame update
    void Start()
    {
        gameStart=false;
        distancescore=0;
        personalbestscore=PlayerPrefs.GetFloat("highscore", personalbestscore);
        distancetext.SetText("Score: " +distancescore.ToString("F2")+" m");
        personalbesttext.SetText("Personal Best: " + personalbestscore.ToString("F2")+" m");
        distancetext.gameObject.SetActive(false);
        personalbesttext.gameObject.SetActive(false);
        resetbtn.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if(unicorn.transform.position.x >-9&&gameStart){
        distancescore+=Time.deltaTime;
        distancetext.SetText("Score: " +distancescore.ToString("F2")+" m");
        }
        if(unicorn.transform.position.x <=-9){
            PersonalBest();
            GameEnd();
        }
    }

    public void PersonalBest()
    {

        if(personalbestscore < distancescore){

            personalbestscore = distancescore;
            PlayerPrefs.SetFloat("highscore", personalbestscore);
            personalbesttext.SetText("Personal Best: " + personalbestscore.ToString("F2")+" m");

        }


    }

    public void Gamestart(){

        gameStart=true;
    }

    void GameEnd(){
        gameStart=false;
        PersonalBest();


    }

    public void ResetScore(){

            personalbestscore = 0f;
            PlayerPrefs.SetFloat("highscore", personalbestscore);
            personalbesttext.SetText("Personal Best: " + personalbestscore.ToString("F2")+" m");

    }
}
