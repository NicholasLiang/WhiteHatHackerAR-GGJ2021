using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppData : MonoBehaviour
{
    public static AppData appdata;

    public float someExampleVariable;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (appdata == null)
        {
            appdata = this;
        }
    }
}
