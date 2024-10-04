using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    [SerializeField] float life = 0.8f;
    AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnAwake(){
        sound.Play();
    }
}
