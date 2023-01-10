using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    int lives = 10;
    
    GameObject plyer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score; " + score + "/n" + "Lives: " + lives);
        plyer = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int value)
    {
        lives += value;

        if (lives < 1)
        {
            lives = 0;
            Destroy(plyer);
        }




    }









}
