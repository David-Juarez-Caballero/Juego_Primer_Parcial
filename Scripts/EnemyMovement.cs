using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;


public class EnemyMovement : MonoBehaviour
{
    public Transform personaje;
    private NavMeshAgent agente;
    
 
    private BoxCollider2D colEspada;
    
    private void Awake(){
        agente = GetComponent<NavMeshAgent>();
        colEspada=GetComponent<BoxCollider2D>();
    }
    
    private void Start() {
        agente.updateRotation = false;
        agente.updateUpAxis= false;
    }

    private void Update() {
        agente.SetDestination(personaje.position);      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
