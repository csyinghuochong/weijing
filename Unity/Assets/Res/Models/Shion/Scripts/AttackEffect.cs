using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEffect : MonoBehaviour
{
    TrailRenderer tr;

    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.emitting = false;
    }

    public void AttackEffectOn()
    {
        tr.emitting = true;
    }

    public void AttackEffectOff()
    {
        tr.emitting = false;
    }
}
