using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMotions : MonoBehaviour
{
    private Rigidbody rb;
    public float upForce;

    public float animTimer;
    private float time;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update() {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
    }

    public void JumpAction()
    {
        if (time <= 0)
        {
            time += animTimer;
            rb.AddForce(transform.up * upForce);
        }
    }
}
