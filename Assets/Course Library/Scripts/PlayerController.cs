using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Horizontal and Vertical Inout declaration
    private float horizontalInput;
    private float verticalInput;
    
    //player speed in-game
    public float speed = 10.0f;
   
    //Prefab instance contained inside player
    public GameObject projectilePrefab;
    public float xRange = 25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forbids player from going out of bounds
        if(transform.position.x > xRange)
        {   
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x < -xRange)
        {   
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
       
        //Gets access for wasd to move up and down
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        //Makes wasd work
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //when space is pressed, a projectille is thrown (Instantiated)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    
    }
}
