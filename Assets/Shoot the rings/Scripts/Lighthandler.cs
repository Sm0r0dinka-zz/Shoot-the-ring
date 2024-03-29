﻿using UnityEngine;

public class Lighthandler : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject globalLight;
    public GameObject symbolslight;
    public GameObject lvlindicator;
    public GameObject colorButtons;
    public GameObject tutorialLightLvl1;
    public GameObject tutorialLightlvl3;

    public GameObject tutorialLightLvl1Finger;
    public GameObject tutorialLightLvl3Finger;


    public void Button_pressed(string trigger)
    {

        foreach (GameObject light in lights)
        {
            light.GetComponent<Animator>().SetTrigger(trigger);
        }
    }
    public void ResetState(string trigger)
    {

        foreach (GameObject light in lights)
        {
            if (!light.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("white"))
            {
                light.GetComponent<Animator>().SetTrigger(trigger);
            }
        }
    }




    public void ChangeLightBrightness(string trigger)
    {
        globalLight.GetComponent<Animator>().SetTrigger(trigger);
        symbolslight.GetComponent<Animator>().SetTrigger(trigger);
        colorButtons.transform.GetChild(0).GetComponent<Animator>().SetTrigger(trigger);
        colorButtons.transform.GetChild(1).GetComponent<Animator>().SetTrigger(trigger);
        colorButtons.transform.GetChild(2).GetComponent<Animator>().SetTrigger(trigger);
    }

    public void ChangeOnlyGlobalLight(string trigger)
    {
        globalLight.GetComponent<Animator>().SetTrigger(trigger);
    }

    public void TutorialLightLvl1(string trigger)
    {
        globalLight.GetComponent<Animator>().SetTrigger(trigger);
        tutorialLightLvl1.GetComponent<Animator>().SetTrigger(trigger);
        tutorialLightLvl1Finger.GetComponent<Animator>().SetTrigger("finger");
    }
    public void TutorialLightLvl3(string trigger)
    {
        globalLight.GetComponent<Animator>().SetTrigger(trigger);
        tutorialLightlvl3.GetComponent<Animator>().SetTrigger(trigger);
        tutorialLightLvl3Finger.GetComponent<Animator>().SetTrigger("finger");

    }

    public void ResetLvlIndicator()
    {
        lvlindicator.GetComponent<Animator>().SetTrigger("reset");
    }
}
