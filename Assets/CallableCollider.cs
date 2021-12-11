using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallableCollider : MonoBehaviour
{
    public event Action<Collider> OnInteractionStarted;
    public event Action<Collider> OnInteractionEnded;

    private void OnTriggerEnter(Collider other) => OnInteractionStarted?.Invoke(other);

    private void OnTriggerExit(Collider other) => OnInteractionEnded?.Invoke(other);
}
