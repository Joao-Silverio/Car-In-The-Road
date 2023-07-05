using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera hoodCamera;
    public Camera mainCamera;
    public KeyCode switchkey;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Definindo Inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Mover o carro para frente
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Mover o carro para os lados
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //Mudar de camera
        if (Input.GetKeyDown(switchkey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
