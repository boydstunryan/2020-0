using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntData : MonoBehaviour
{
    public int value = 1;

    public void ChangeValue(int number)
    {
        value += number;
    }
}
