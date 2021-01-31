using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppData : MonoBehaviour
{
    public bool initialized;

    public bool camera1Touched;
    
    public bool camera2Touched;
    

    public bool KimFamilyHacked;

    public bool ChenFamilyHacked;

    public bool SimpsonsFamilyHacked;

    void Awake() 
    {
        DontDestroyOnLoad(this);

        GameObject[] objs = GameObject.FindGameObjectsWithTag("AppData");

        if (objs.Length > 1)
        {
            foreach (var obj in objs)
            {
                if (obj.GetComponent<AppData>().initialized == false)
                {
                    Destroy(obj);
                }
             }
        }

        initialized = true;

    }


    public void KimFailyHackedBool(bool value)
    {
        KimFamilyHacked = value;
    }
    public void ChenFailyHackedBool(bool value)
    {
        ChenFamilyHacked = value;
    }
    public void SimpsonsFailyHackedBool(bool value)
    {
        SimpsonsFamilyHacked = value;
    }

    public void Camera1TouchedBool(bool value)
    {
        camera1Touched = value;
    }
    public void Camera2TouchedBool(bool value)
    {
        camera2Touched = value;
    }


}
