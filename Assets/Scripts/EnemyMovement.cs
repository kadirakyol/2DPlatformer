using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    private Rigidbody2D myRigidbody2D;
    
    
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();



    }

    
    
    
    void Update()
    {
        myRigidbody2D.velocity = new Vector2(moveSpeed, 0f);




    }

    void OnTriggerExit2D(Collider2D col)
    {

        moveSpeed = -moveSpeed;
        FlipEnemyFacing();

    }

    void FlipEnemyFacing()
    {
        transform.localScale = new Vector2 (-(Mathf.Sign(myRigidbody2D.velocity.x)), 1f);
        
    }
     
    
    
}
