using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsablesContainer : MonoBehaviour
{
    [SerializeField]
    private Transform _parentTransform;
    [SerializeField]
    private SphereCollider _playerCollider;
    [Header("Usables")]
    [SerializeField]
    private Usable _usablePrefab;
    [SerializeField] [Min(1)]
    private int _usablesCount;

    private float _spawnRadius;
    private float _rotationAngle;

    private bool _isRotationFreezed;

    private HashSet<Usable> _usablesSet = new HashSet<Usable>();

    private void Start()
    {
        _spawnRadius = _playerCollider.center.x;
        _rotationAngle = 360 / _usablesCount;

        for (int i = 0; i < _usablesCount; i++)
        {
            Vector3 rotation = new Vector3(0, _rotationAngle * i, 0);

            var usable = Instantiate(_usablePrefab, _parentTransform, true);
            usable.SetPositionAndRotation(_playerCollider.center, rotation);
            _usablesSet.Add(usable);
        }

        Usable.OnUsageStart += () => { _isRotationFreezed = true; };
        Usable.OnUsageEnd += () => { _isRotationFreezed = false; };
    }

    private void FixedUpdate()
    {
        //if (_isRotationFreezed)
        //    return;
        transform.Rotate(new Vector3(0, 1, 0), Space.Self);
    }
}