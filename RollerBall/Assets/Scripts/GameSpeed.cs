using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{

    public void SetTimeScale(float newValue)
    {
        Time.timeScale = newValue;
    }
}
