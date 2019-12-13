using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private Rigidbody playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        //get the playes hitbox
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //send the player up when they hit the ground
        playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }
}
