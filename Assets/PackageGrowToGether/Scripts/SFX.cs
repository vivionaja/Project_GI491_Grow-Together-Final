using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource playSFX;
    public AudioSource quitSFX;

    public AudioSource questInMapSFX;
    public AudioSource questInHomeSFX;
    public AudioSource questInMarketSFX;
    public AudioSource questInBakerySFX;
    public AudioSource questInMagicSFX;

    public AudioSource backInMarketSFX;
    public AudioSource backInBakerySFX;
    public AudioSource backInMagicSFX;

    public AudioSource leftSFX;
    public AudioSource rightSFX;
    public AudioSource spinSFX;

    public void PlayButton()
    {
        playSFX.Play();
    }

    public void QuitButton()
    {
        quitSFX.Play();
    }

    public void QuestInMapButton()
    {
        questInMapSFX.Play();
    }

    public void QuestInHomeButton()
    {
        questInHomeSFX.Play();
    }

    public void QuestInMarketButton()
    {
        questInMarketSFX.Play();
    }

    public void QuestInBakeryButton()
    {
        questInBakerySFX.Play();
    }

    public void QuestInMagicButton()
    {
        questInMagicSFX.Play();
    }

    public void BackInMarketButton()
    {
        backInMarketSFX.Play();
    }

    public void BackInBakeryButton()
    {
        backInBakerySFX.Play();
    }

    public void BackInMagicButton()
    {
        backInMagicSFX.Play();
    }

    public void LeftButton()
    {
        leftSFX.Play();
    }

    public void RightButton()
    {
        rightSFX.Play();
    }

    public void SpinButton()
    {
        spinSFX.Play();
    }
}
