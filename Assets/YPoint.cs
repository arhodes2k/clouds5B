using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YPoint : MonoBehaviour
{ 
    [SerializeField] GameObject Shot;



    void Start() {
    
     
    }
    // Update is called once per frame
    void Update()
    {
        float moveX;
        moveX = Input.GetAxis("Horizontal"); 
        GameObject shot;
        float boundX = 7.7f;
        float boundY = 12f; 
        float speed = 2f;
        float move; 
        move = Input.GetAxis("Vertical");
        
       

        if (transform.position.x > boundX)
     {
         transform.position = new Vector3(boundX, transform.position.y , 0f);
     } else {
         transform.Translate(speed * moveX * Time.deltaTime, 0f, 0f); 
     }
        if (transform.position.x < -boundX) 
     {
       transform.position = new Vector3(-boundX, transform.position.y, 0f);
     } else { 
       transform.Translate(speed * moveX * Time.deltaTime, 0f, 0f); 
     }
      if(transform.position.y > boundY){ 
        transform.position = new Vector3(transform.position.x, boundY, 0f);
     } else { 
        transform.Translate(0f, move * speed * Time.deltaTime, 0f); 
     }
      if(transform.position.y < -boundY){ 
        transform.position = new Vector3(transform.position.x, -boundY, 0f);
     } else {
        transform.Translate(0f, move * speed * Time.deltaTime, 0f);
        }

      if(Input.GetButtonDown("Fire1"))
     {
        shot = Instantiate(Shot);
        shot.transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
     }
    }
}
