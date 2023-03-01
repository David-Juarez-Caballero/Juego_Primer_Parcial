using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    [SerializeField] private AudioSource clickSoundEffect;

    // Update is called once per frame
    void Update()
    {
        //Input 
        movement.x=Input.GetAxis("Horizontal");
        movement.y=Input.GetAxis("Vertical");
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed",movement.sqrMagnitude);
        //Inputing the spacebar for an attack
        if(Input.GetKey("space")){
            clickSoundEffect.Play();
            animator.SetTrigger("Ataque");
        }
    }

    void FixedUpdate()
    {
        //Movement     
        rb.MovePosition(rb.position+movement*moveSpeed*Time.deltaTime);
    }

}
