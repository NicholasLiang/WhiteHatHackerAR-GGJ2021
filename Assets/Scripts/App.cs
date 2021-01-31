using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public static App app;

    public float someExampleVariable;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (app == null)
        {
            app = this;
        }
    }
}
