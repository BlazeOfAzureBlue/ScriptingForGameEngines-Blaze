using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float Speed;
    private Vector3 movement = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>();
        Speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movement = transform.TransformDirection(movement);
            movement *= Speed;
        }

        controller.Move(movement * Time.deltaTime);
    }
}
