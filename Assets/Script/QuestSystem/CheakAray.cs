using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheakAray : MonoBehaviour
{
    

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Quest2"))
        {
            Player.cheakQ2 = true;
            Player.number = 1;
        }
        else if (collider.CompareTag("Quest2.2"))
        {
            Player.cheakQ2 = true;
            Player.number = 2;
        }
        else if (collider.CompareTag("Quest5"))
        {
            Player.cheakQ5 = true;
            Player.number = 1;
        }
        else if (collider.CompareTag("Quest5.2"))
        {
            Player.cheakQ5 = true;
            Player.number = 2;
        }
        else if (collider.CompareTag("Quest7"))
        {
            Player.cheakQ7 = true;
            Player.number = 1;
        }
        else if (collider.CompareTag("Quest7.2"))
        {
            Player.cheakQ7 = true;
            Player.number = 2;
        }
        else if (collider.CompareTag("Quest8"))
        {
            Player.cheakQ8 = true;
            Player.number = 1;
        }
        else if (collider.CompareTag("Quest8.2"))
        {
            Player.cheakQ8 = true;
            Player.number = 2;
        }
        else if (collider.CompareTag("Quest9"))
        {
            Player.cheakQ9 = true;
            Player.number = 1;
        }
        else if (collider.CompareTag("Quest9.2"))
        {
            Player.cheakQ9 = true;
            Player.number = 2;
        }
        else if (collider.CompareTag("Quest9.3"))
        {
            Player.cheakQ9 = true;
            Player.number = 3;
        }

    }
}
