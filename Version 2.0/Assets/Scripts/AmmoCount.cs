using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoCount : MonoBehaviour
{
    public int ammoNum = 10;
    public static AmmoCount instance;

    /*public Image ten;
    public Image nine;
    public Image eight;
    public Image seven;
    public Image six;
    public Image five;
    public Image four;
    public Image three;
    public Image two;*/
    public Image[] numAmmo = new Image[10];

    int lastChange = 10;

    Color color;

    void Awake()
    {
        instance = this;
    }

    public void changeAmount(int num)
    {
        if(num < 0)
        {   
            --lastChange;
            color = numAmmo[lastChange].color;
            color.a = 0;
            numAmmo[lastChange].color = color;
            
        }
        if(num > 0)
        {
            color = numAmmo[lastChange].color;
            color.a = 1;
            numAmmo[lastChange].color = color;
            ++lastChange;
        }
    }

}
