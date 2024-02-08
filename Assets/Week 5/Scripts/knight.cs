using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    Vector2 destination;
    Vector2 movement;
    public float speed = 3;
    Rigidbody2D rb;
    Animator animator;
    bool clickingOnSelf = false;
    public float health;
    public float maxHealth = 5;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = maxHealth;
    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        if(movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }

        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !clickingOnSelf)
            //exclamation point means not
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        animator.SetFloat("movement", movement.magnitude);

        if(Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("attack");
        }
    }
    private void OnMouseDown()
    {
        clickingOnSelf = true;
        SendMessage("takeDamage", 1);
        
    }
    private void OnMouseUp()
    {
        clickingOnSelf = false;
    }

   
    public void takeDamage(float damage)
    {
        health -= damage;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health ==0)
        {
            //die?
            animator.SetTrigger("death");
        }
        else
        {
            animator.SetTrigger("takeDamage");
        }
        
    }
}
