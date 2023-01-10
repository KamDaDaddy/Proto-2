using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    float sideBounds = 24;

    GameManager gamu;
    
    // Start is called before the first frame update
    void Start()
    {
        gamu = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game Over! HA HA");
            Destroy(gameObject);

            gamu.UpdateLives(-1);
        }
    
        if(transform.position.x < -sideBounds || transform.position.x > sideBounds)
        {
            gamu.UpdateLives(-1);
            Destroy(gameObject);
        }
    
    }
}
