using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicornmove : MonoBehaviour
{
[SerializeField] private float moveSpeed = 1f;
private Vector3 movedirection = new Vector3 (-17f, 0f, 0f);
private Vector3 startPoint = new Vector3(21f, 7f, 0f);
[SerializeField] GameObject unicorn;
[SerializeField] Rigidbody unicornrig;









    // Start is called before the first frame update
    void Start()
    {
        unicornrig = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    
      unicornrig.MovePosition(transform.position+(movedirection*moveSpeed*Time.deltaTime));

     

      if(transform.position.x <-18){
          Destroy(unicorn);
      }

      if (transform.position.y > 17){

          Destroy(unicorn);
      }

      if (transform.position.z > 5 || transform.position.z < -5){
          Destroy(unicorn);
      }
}

}
