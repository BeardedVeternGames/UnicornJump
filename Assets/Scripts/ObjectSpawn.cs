using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour  {
    [SerializeField] private GameObject [] obstacle = new GameObject[6];


    private Vector3 spawnposition= new Vector3(21f,0f,0f);
    [SerializeField] private float spawnSpeed;
    [SerializeField] private float spawnSpeedMin;
    [SerializeField] private float spawnSpeedMax;
    private float elapsedTime=0f;
    private float gameTime;
    public bool gameStart;
    
    




    // Start is called before the first frame update
    void Start()
    {
        gameStart=false;
        spawnSpeedMin=2f;
        spawnSpeedMax=4f;
    
        
    }

    // Update is called once per frame
    void Update()
    {



        
            if(gameStart==true){
                elapsedTime+=Time.deltaTime;
                gameTime+=Time.deltaTime;
                if(elapsedTime > spawnSpeed){
                    elapsedTime = 0f;
                    SpawnObstacle();
                    spawnSpeed=Random.Range(spawnSpeedMin, spawnSpeedMax);


                }

        
            }
        
        
        
        
        if(gameTime >= 40f && spawnSpeedMin >=0.5f){
            if(spawnSpeedMin ==0.5f){
                return;
            }
            gameTime = 0f;
            spawnSpeedMin=spawnSpeedMin-0.1f;
            spawnSpeedMax=spawnSpeedMax-0.1f;
            Debug.Log(spawnSpeedMin+" to "+spawnSpeedMax);


        }





        
    }

    void SpawnObstacle()
    {
       
       Instantiate(obstacle[Random.Range(0, obstacle.Length)], spawnposition, Quaternion.LookRotation(spawnposition, Vector3.up));

        

    }

        public void GameStart()
    {
        gameStart=true;
        
    }





}
