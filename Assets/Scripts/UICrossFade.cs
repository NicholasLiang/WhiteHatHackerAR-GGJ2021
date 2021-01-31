using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICrossFade : MonoBehaviour
{
    public float startTime;
    public float duration;
    private Image panel;
    void Start()
    {
        panel = GetComponent<Image>();
        StartCoroutine(fade(startTime, duration));
    }

    private IEnumerator fade(float startTime, float duration)
    {
        yield return new WaitForSeconds(startTime);
        panel.GetComponent<Image>().CrossFadeAlpha(0f, duration, false);
        yield return null;
    }
}
