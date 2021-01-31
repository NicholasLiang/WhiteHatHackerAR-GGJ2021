using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LoadSceneWhenStart : MonoBehaviour
{
    private AppData appData;
    public UnityEvent onCamera1Touched;
    public UnityEvent onCamera2Touched;
    public UnityEvent onKimFamilyWifiHacked;
    public UnityEvent onChenFamilyWifiHacked;
    public UnityEvent onSimpsonsFamilyWifiHacked;

    void Start()
    {
        appData = (AppData)GameObject.Find("AppData").GetComponent<AppData>();
        LoadScene();
    }

    public void KimFamilyWifiHackedEvent()
    {
        onKimFamilyWifiHacked.Invoke();
    }
    public void ChenFamilyWifiHackedEvent()
    {
        onChenFamilyWifiHacked.Invoke();
    }
    public void SimpsonsFamilyWifiHackedEvent()
    {
        onSimpsonsFamilyWifiHacked.Invoke();
    }
    public void Camera1TouchedEvent()
    {
        onCamera1Touched.Invoke();
    }
    public void Camera2TouchedEvent()
    {
        onCamera2Touched.Invoke();
    }
    public void LoadScene()
    {
        if (appData.camera1Touched)
        {
            Camera1TouchedEvent();
        }
        if (appData.camera2Touched)
        {
            Camera2TouchedEvent();
        }
        if (appData.KimFamilyHacked)
        {
            KimFamilyWifiHackedEvent();
        }
    }
}
