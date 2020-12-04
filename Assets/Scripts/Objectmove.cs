using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmove : MonoBehaviour{

[SerializeField] private float moveSpeed = .1f;
private Vector3 endPoint = new Vector3 (-17f, 0f, 0f);
private Vector3 startPoint = new Vector3(21f, 0f, 0f);
[SerializeField] GameObject obsticale;








    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    
      transform.Translate(0, 0,-moveSpeed*Time.deltaTime);

      if(transform.position.x <-18){
          Destroy(obsticale);
      }

      if (transform.position.y > 17){

          Destroy(obsticale);
      }

      if (transform.position.z > 5 || transform.position.z < -5){
          Destroy(obsticale);
      }



        
    }
}
