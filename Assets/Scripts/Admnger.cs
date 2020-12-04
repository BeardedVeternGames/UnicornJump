using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class Admnger : MonoBehaviour{

    private string gameIDAndroid="3915741";
    private string gameIDIOS="3915740";
    public bool testMode=true;
    public bool isTargetPlayStore;

    private string InterstialAd="video";
    private string bannerad="banner";



    // Start is called before the first frame update
    void Start()
    {
        
        InitializeAdvertisement();
        StartCoroutine(ShowBannerWhenReady());
    }

    private void InitializeAdvertisement(){
        if(isTargetPlayStore){
            Advertisement.Initialize(gameIDAndroid, testMode);
            return;
        }
            Advertisement.Initialize(gameIDIOS, testMode);

        




    }

    // Update is called once per frame
    public void ShowAdvertisement()
    {
        if(!Advertisement.IsReady(InterstialAd)){
            return;
        }
        Advertisement.Show(InterstialAd);

        
    }

    IEnumerator ShowBannerWhenReady(){

                while (!Advertisement.IsReady (bannerad)) {
            yield return new WaitForSeconds (2f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
        Advertisement.Banner.Show (bannerad);
    }



    
}
