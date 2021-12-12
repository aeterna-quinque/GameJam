using Assets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField]
    private Usable[] _usablePresets;

    private float _spawnRadius;
    private float _rotationAngleUnit;

    private bool _isRotationFreezed;

    private HashSet<Usable> _usablesSet = new HashSet<Usable>();

    public Transform cam;

    private void Start()
    {
        _spawnRadius = _playerCollider.center.x;
        _rotationAngleUnit = 360 / _usablePresets.Length;
        float currentAngle = 0;

        foreach (var preset in _usablePresets)
        {
            Vector3 rotation = new Vector3(0, currentAngle, 0);

            var usable = Instantiate(preset, _parentTransform, true);
            usable.SetPositionAndRotation(_playerCollider.center, rotation);
            _usablesSet.Add(usable);
            usable.foodCanvas.cam = cam;
            usable.waterCanvas.cam = cam; 

            currentAngle += _rotationAngleUnit;
        }

        Usable.OnUsageStart += () => { _isRotationFreezed = true; };
        Usable.OnUsageEnd += () => { _isRotationFreezed = false; };
    }

    private void Update()
    {
        //if (_isRotationFreezed)
        //    return;
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            var y = transform.rotation.y;
            transform.Rotate(new Vector3(0, y + _rotationAngleUnit, 0), Space.Self);
        }
    }
}