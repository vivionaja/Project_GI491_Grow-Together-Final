using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Player.money >= 1000 && LootSystem._itemToEndGame01 == true && LootSystem._itemToEndGame02 == true)
        {
            Debug.Log("end");
            SceneManager.LoadScene(2);
        }
    }
}
