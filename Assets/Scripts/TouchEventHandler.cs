using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEventHandler : MonoBehaviour
{
    void Update()
    {
        bool isTouch;

#if UNITY_EDITOR
        isTouch = Input.GetMouseButtonDown(0);
#else
        isTouch = Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
#endif

        if (isTouch)
        {

            Debug.Log("Touched");

            Ray ray;

#if UNITY_EDITOR
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
#else
            ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
#endif

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;

                Debug.Log("Mesh Touched");

                if (hitObject.TryGetComponent(out TouchEvent touchEvent))
                {
                    touchEvent.OnTouch();
                }
            }
        }
    }
}
