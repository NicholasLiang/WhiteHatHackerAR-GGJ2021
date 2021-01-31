using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TouchEvent : MonoBehaviour
{
    public UnityEvent m_OnTouchStart;

    public void OnTouch()
    {
        m_OnTouchStart.Invoke();
    }
}
