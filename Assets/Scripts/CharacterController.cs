using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        // Move our object based on input from the player

        // To be able to move with WASD / Arrow Keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // For the character to move + normalise to move same speed diagonalllyyy
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize();

        // Dont wanna move character to fast, moving 6 metres per frame
        transform.Translate(movement * 6.0f * Time.deltaTime);

    }
}
