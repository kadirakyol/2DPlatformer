using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private Rigidbody2D myRigidbody2D;
    
    
    void Start()
    {
        
        
        
        
    }

    
    
    
    void Update()
    {
        myRigidbody2D.velocity = new Vector2(moveSpeed, 0f);




    }
    
    
    
}
