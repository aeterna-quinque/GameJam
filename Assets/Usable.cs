using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : MonoBehaviour
{
    [SerializeField]
    private Transform _objTransform;
    [SerializeField]
    private CallableCollider _collider;

    public static event Action OnUsageStart;
    public static event Action OnUsageEnd;
    
    public void SetPositionAndRotation(Vector3 position, Vector3 rotation)
    {
        _objTransform.SetPositionAndRotation(position, new Quaternion());
        transform.Rotate(rotation, Space.Self);
    }

    public virtual void Start()
    {
        _collider.OnInteractionStarted += HandleInteractionStarted;
        _collider.OnInteractionEnded += HandleInteractionEnded;
    }

    private void OnDestroy()
    {
        _collider.OnInteractionStarted -= HandleInteractionStarted;
        _collider.OnInteractionEnded -= HandleInteractionEnded;
    }

    protected virtual void HandleInteractionStarted(Collider collider)
    {
        OnUsageStart?.Invoke();
    }
    
    protected virtual void HandleInteractionEnded(Collider collider)
    {
        OnUsageEnd?.Invoke();
    }
}