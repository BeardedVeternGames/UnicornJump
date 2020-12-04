using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class PlayerController : MonoBehaviour
{

private Animator animator;
private bool isOnGround;

[SerializeField] private Rigidbody playrig;
[SerializeField] private float jumpHeight=40f;
private Collider collide;
[SerializeField] float runUpSpeed=.1f;
private Vector3 movedirection = new Vector3 (1f, 0f, 0f);
private AudioSource jumpsound; 
[SerializeField] AudioClip jump;
protected GameManager gameManager;
public bool gameStart;



    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        collide=GetComponent<Collider>();
        jumpsound=GetComponent<AudioSource>();
        gameStart=false;
        
     }


    public void Update()
    {
        if (transform.position.y <= 0)
        {

            isOnGround = true;
            animator.SetBool("isOnGround", true);
        }
        else
        {

            isOnGround = false;
            animator.SetBool("isOnGround", false);
        }
        if (gameStart)
        {
            if (Input.GetMouseButtonDown(0)&&transform.position.x>=-9)
            {

            playrig.AddForce(0, jumpHeight, 0, ForceMode.Impulse);
            animator.Play("Jump");
            jumpsound.PlayOneShot(jump);
            }
        }




    }

    public void FixedUpdate(){

            if(transform.position.y <= 0 && transform.position.x <=0&&transform.position.x>=-9){

            playrig.MovePosition(transform.position+(movedirection*runUpSpeed*Time.deltaTime));

        }




}

public void GameStart(){

    gameStart=true;
}




    



}
