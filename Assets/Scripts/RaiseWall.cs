using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseWall : MonoBehaviour
{
    public Animator targetAnimator;
    public GameObject self;

    void OnTriggerEnter(Collider other)
    {
        targetAnimator.enabled = true;
        self.SetActive(false);
    }
}
