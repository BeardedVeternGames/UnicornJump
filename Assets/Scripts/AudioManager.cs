using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour{

public AudioSource audioSource;
[SerializeField]  private AudioClip[] audioClips=new AudioClip[7];
private AudioListener audioListener;
public bool isGamePlaying;







    // Start is called before the first frame update
    void Start()
    {
        audioListener=GetComponent<AudioListener>();
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying&&isGamePlaying){

            PlayRandom();
        }
    }

    void PlayRandom(){


        audioSource.clip=audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();

    }

    public void IsGamePlaying(){

        isGamePlaying=true;

    }

}
