using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTouchButton : MonoBehaviour
{
    public void TurnRed()
    {
        this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
