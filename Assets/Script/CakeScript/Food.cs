using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject _Food;
    public Player player;
    public Collider2D other;


    public AudioSource buttonSFX;

    private void OnMouseOver()
    {
        _Food.SetActive(true);
 
        if (Input.GetMouseButtonDown(0))
        {
            buttonSFX.Play();
            if(other.CompareTag("Quest5") )
            {
                Player.thisMushroom = true;
                player.QuestBuy();
            }
            else if (other.CompareTag("Quest5.2"))
            {
                Player.thisSalmon = true;
                player.QuestBuy();
            }
        }
    }
    private void OnMouseExit()
    {
        _Food.SetActive(false);
    }
    
}
