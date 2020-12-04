using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public bool gameStart=false;

    [SerializeField] GameObject unicorn;
    public  Button startbtn;
    [SerializeField] GameObject title;
    public Button quitbtn;
    public Button restartbtn;
    public AudioManager audioManager;
    public Button sharebtn;
    
    



    // Start is called before the first frame update
    void Start()
    {
        startbtn.enabled=true;
        if(gameStart){
            title.gameObject.SetActive(false);
            startbtn.gameObject.SetActive(false);
        }else{
            title.gameObject.SetActive(true);
            startbtn.gameObject.SetActive(true);

        }
        audioManager.isGamePlaying=false;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //unicornNose.GetComponent<Transform>();
            if(unicorn.transform.position.x<=-9){
                GameEnd();
                Debug.Log("game should be ending");
                
            }
    }

    public void GameStart()
    {
        gameStart=true;
        audioManager.isGamePlaying=true;
        
        
    }
    public void GameEnd()
    {


        gameStart=false;
        quitbtn.gameObject.SetActive(true);
        restartbtn.gameObject.SetActive(true);
        sharebtn.gameObject.SetActive(true);
        title.gameObject.SetActive(true);

        
        
        
    }
    public void RestartGame()
    {
        
        SceneManager.LoadScene("MainScene");
        audioManager.audioSource.Stop();


    }

    public void QuitGame(){

        Application.Quit();

    }
}
