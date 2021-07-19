using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RouletteSpin : MonoBehaviour
{
    public GameObject _Roulette01;
    public GameObject _Roulette02;
    public GameObject _SpinItem_Window;

    public int SpinPrice;

    bool Check;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpinToWin()
    {
        
        if (Player.money >= SpinPrice)
        {
            Check = true;
            _Roulette01.SetActive(false);
            _Roulette02.SetActive(true);
            Player.money -= SpinPrice;   
        }
        StartCoroutine(OpenSpinWindow());
    }

    public void Close()
    {
        _Roulette01.SetActive(true);
        _Roulette02.SetActive(false);
        _SpinItem_Window.SetActive(false);
    }

    IEnumerator OpenSpinWindow()
    {
        if (Check == true)
        {
            yield return new WaitForSeconds(2f);
            _Roulette01.SetActive(true);
            _Roulette02.SetActive(false);
            _SpinItem_Window.SetActive(true);
            Check = false;
        }
    }

}
