using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuestInfo : MonoBehaviour
{
    public GameObject _QuestWindow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuestButton()
    {
        _QuestWindow.SetActive(true);
    }
    public void BackButton()
    {
        _QuestWindow.SetActive(false);
    }
}
