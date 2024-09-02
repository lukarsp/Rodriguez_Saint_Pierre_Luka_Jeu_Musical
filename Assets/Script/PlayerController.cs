using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb; 
    [SerializeField] private float speed;
    
    private Vector2 moveInputValue;

    private void OnMove(InputValue value){
        moveInputValue = value.Get<Vector2>();
    }
    private void MoveLogiq(){
        Vector3 result = new Vector3(moveInputValue.x, 0, moveInputValue.y) * speed * Time.fixedDeltaTime;

        if(result.magnitude != 0){
            rb.AddForce(result);
        }


    }

    private void FixedUpdate(){
        MoveLogiq();
    }
}
