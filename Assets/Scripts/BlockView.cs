using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BlockView : MonoBehaviour
{
    public UnityEvent OnBlockViewEnter;
    public UnityEvent OnBlockViewExit;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            OnBlockViewEnter.Invoke();
        }
    }

    //When the Primitive exits the collision, it will change Color
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            OnBlockViewExit.Invoke();
        }
    }
}
