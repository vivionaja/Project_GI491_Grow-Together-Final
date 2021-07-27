using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTu : MonoBehaviour
{
    public GameObject iconClick;
    public GameObject iconClick2;
    public GameObject _Food;
    public Player player;
    public Collider2D other;
    public GameObject wrong;
    public AudioSource wrongSFX;


    public AudioSource buttonSFX;

    private void OnMouseOver()
    {
        _Food.SetActive(true);

        if (Input.GetMouseButtonDown(0))
        {

            if (other.CompareTag("Quest5"))
            {
                Player.thisMushroom = true;
                buttonSFX.Play();
                player.QuestBuy();
                iconClick.SetActive(false);
                iconClick2.SetActive(true);
            }
            else if (other.CompareTag("Quest5.2"))
            {
                Player.thisSalmon = true;
                buttonSFX.Play();
                player.QuestBuy();
                iconClick.SetActive(false);
            }
            else
            {
                wrong.SetActive(true);
                wrongSFX.Play();
                StartCoroutine(DeleyWrong());
            }
        }
    }
    private void OnMouseExit()
    {
        _Food.SetActive(false);
    }
    IEnumerator DeleyWrong()
    {
        yield return new WaitForSeconds(2.0f);
        wrong.SetActive(false);
    }
    public void DelClick()
    {
        iconClick.SetActive(false);
    }

}
