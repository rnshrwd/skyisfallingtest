﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wolfattack : MonoBehaviour
{
    private int health = 5;
    public GameObject gameOverText, restartButton;

    void Start()
    {
        gameOverText.SetActive(false); // sets game over text 
        restartButton.SetActive(false);
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("A wolf attacked you");
            health--;
        }
    }

    private void Update()
    {
        if(health <= 0)
        {
            //gameOverText.SetActive(true);
            //restartButton.SetActive(true);
            //gameObject.SetActive(false);

        }
    }

}