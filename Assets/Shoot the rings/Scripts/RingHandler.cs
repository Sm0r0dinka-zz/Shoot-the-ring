﻿
using UnityEngine;

public class RingHandler : MonoBehaviour
{

    public void RingsReachAbility(string color)
    {
        int ringCount = transform.Find(color).transform.childCount;

        if (ringCount > 0)
        {
            for (int i = 0; ringCount > i; i++)
            {
                transform.Find(color).transform.GetChild(i).GetComponent<Ring>().SwitchOnOff();
                transform.Find(color).transform.GetChild(i).GetComponent<Ring>().GetComponent<Animator>().SetTrigger(color);
            }
        }
    }
    public void DelateAllRings()
    {
        Destroy(transform.GetChild(0).gameObject);
        Destroy(transform.GetChild(1).gameObject);
        Destroy(transform.GetChild(2).gameObject);
        Destroy(transform.GetChild(3).gameObject);

        GameObject red = new GameObject
        {
            name = "red rings"
        };
        red.transform.parent = this.transform;

        GameObject blue = new GameObject
        {
            name = "blue rings"
        };
        blue.transform.parent = this.transform;

        GameObject green = new GameObject
        {
            name = "green rings"
        };
        green.transform.parent = this.transform;

        GameObject white = new GameObject
        {
            name = "white rings"
        };
        white.transform.parent = this.transform;

    }
}
