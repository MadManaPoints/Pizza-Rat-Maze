using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] float speed; 
    float hInput; 
    float vInput;
    float maxSpeed = 5; 
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();
        Facing(); 
        LimitSpeed(); 
    }

    void PlayerInput(){
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical"); 

        Vector3 move = new Vector3(hInput, 0f, vInput); 

        playerRb.AddForce(move * speed);

        Vector3 facing = playerRb.rotation * Vector3.forward;
        Vector3 velocity = playerRb.velocity;
    }

    void LimitSpeed(){
        if(playerRb.velocity.magnitude > maxSpeed){
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, maxSpeed);
        }

        //stops moving when letting go of keys 
        if(!Input.anyKey){
            playerRb.velocity = Vector3.zero; 
        }
    }

    void Facing(){
        //turns character to face direction they're moving 
        //this is the best I could come up with for now 
        if(hInput > 0){
            transform.rotation =  Quaternion.Euler(transform.rotation.x, 90f, transform.rotation.z);  
        }

        if(hInput < 0){
            transform.rotation =  Quaternion.Euler(transform.rotation.x, 270f, transform.rotation.z); 
        }

        if(vInput > 0){
            transform.rotation =  Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z); 
        }

        if(vInput < 0){
            transform.rotation =  Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z); 
        }
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Pizza"){
            Destroy(col.gameObject);
            Debug.Log("YER"); 
        }
    }
}
