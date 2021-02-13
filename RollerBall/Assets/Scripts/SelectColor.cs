using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectColor : MonoBehaviour
{

    public Dropdown PickColor;
    public Material mat;

    public void ChangeColor()
    {

        switch(PickColor.value)
        {
            case 1:
                mat.SetColor("_Color", Color.red);
                break;
            case 2:
                mat.SetColor("_Color", Color.green);
                break;
            case 3:
                mat.SetColor("_Color", Color.blue);
                break;
            default:
                break;
        }
    }

}
