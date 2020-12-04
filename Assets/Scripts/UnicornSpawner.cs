using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornSpawner : MonoBehaviour
{
    [SerializeField] private GameObject [] unicorn = new GameObject[6];


    private Vector3 spawnposition= new Vector3(21f,7f,0f);
    private float spawnSpeed;
    private float elapsedTime=0f;
    
    public bool gameStart;



    // Start is called before the first frame update
    void Start()
    {
        
    spawnSpeed=15f;
    gameStart=false;
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime+=Time.deltaTime;

        

            if(gameStart){
                if(elapsedTime >= spawnSpeed){
                    elapsedTime = 0f;
                    spawnSpeed=Random.Range(1f,7f);
                        SpawnUnicorn();


                 }

        
            }

        



        
    }

    void SpawnUnicorn()
    {
       
        Instantiate(unicorn[Random.Range(0, unicorn.Length)], spawnposition, Quaternion.LookRotation(spawnposition, Vector3.up));
        
        

    }

        public void GameStart()
    {
        gameStart=true;
        
    }

}
