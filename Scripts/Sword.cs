using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private BoxCollider2D colEspada;
    [SerializeField] private AudioSource clickSoundEffect;
    private void Awake(){
        colEspada=GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
      
        if (collision.gameObject.tag == "Enemy"){
         
            Destroy(collision.gameObject);
            clickSoundEffect.Play();
        }
    }
    
}
