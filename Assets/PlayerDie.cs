using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject gameOverText, restartButton;

    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }


    void OnCollisionEnter3D (Collision col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
