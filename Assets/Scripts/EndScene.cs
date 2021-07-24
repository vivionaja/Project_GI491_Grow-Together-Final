using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public GameObject _ExitButton;

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
