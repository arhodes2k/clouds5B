using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    [SerializeField] float speed = -1f;
    [SerializeField] float Xbound = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > Xbound){
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        } else {
            transform.position = new Vector3(-Xbound, 0f, 0f);
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }
        
    }
}
