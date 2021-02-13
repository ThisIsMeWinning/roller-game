using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSize : MonoBehaviour
{
    public Dropdown PickSize;
    public GameObject player;

    public void ChangeSize()
    {

        GameObject obj = Instantiate(player, player.transform.position, Quaternion.identity) as GameObject;

        switch (PickSize.value)
        {
            case 1:
                obj.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                break;
            case 2:
                obj.transform.localScale = new Vector3(1, 1, 1);
                break;
            case 3:
                obj.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                break;
            default:
                break;
        }
    }
}
