using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogManInTheMiddle : MonoBehaviour
{
    void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();

        // particles
        List<ParticleSystem.Particle> inside = new List<ParticleSystem.Particle>();

        // get
        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Inside, inside);

        // iterate
        for (int i = 0; i < numEnter; i++)
        {
            ParticleSystem.Particle p = inside[i];
            // p.remainingLifetime = 0;
            p.startColor = new Color32(255, 0, 0, 255);
            inside[i] = p;
        }

        // set
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Inside, inside);
    }
}
