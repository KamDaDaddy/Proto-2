using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private
    private float horizontalInput;
    private bool gameOver = false; 
    //public
    public float speed = 10.0f;
    public GameObject projectilePrefab;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xRange)
        {   
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x < -xRange)
        {   
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //gets horizontal key input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //if space is pressed, player "jumps".
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
