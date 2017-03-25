using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FringeController : MonoBehaviour {

    public float growthRate = 1.5f;
    public int nextTragetMultiplier = 2;

    int particleCount = 0;
    int targetCount = 1;

    int prevTargetCount = 0;

    CircleCollider2D outterRing;
    EdgeCollider2D innerRing;
    new Camera camera;

    void Start()
    {
        outterRing = GetComponent<CircleCollider2D>();
        innerRing = GetComponent<EdgeCollider2D>();
        camera = Camera.main;
    }

    void Update()
    {

    }

	void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Particle entered");
        particleCount += 1;
        OnParticleCountIncrease();
    }


    void OnTriggerExit2D(Collider2D collider)
    {
        particleCount -= 1;
    }

    void OnParticleCountIncrease()
    {
        if (particleCount >= targetCount)
        {
            NextTarget();
            ExpandFringe();
        }
    }

    void ExpandFringe()
    {
        Debug.Log("Fringe expansion");
        innerRing.enabled = false;

        transform.localScale *= growthRate;

        innerRing.enabled = true;

        ZoomOut();
    }

    void ZoomOut()
    {
        // TODO: interpolate in coroutine to make it smooth
        camera.orthographicSize *= growthRate;
    }

    void NextTarget()
    {
        int curTargetCount = targetCount;
        targetCount = nextTragetMultiplier * (curTargetCount + prevTargetCount);
        prevTargetCount = curTargetCount;
    }
}
