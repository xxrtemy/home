using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Bullet : MonoBehaviour
{   
    [SerializeField] private float BulletSpeed = 1;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public Vector3 TargetPos
    {
        get => _targetPos;
        set
        {
            _isShooted = true;
            _targetPos = value;
        }
    }

    public void MoveBullet(Vector3 dir)
    {
        _rigidbody.AddForce(dir * BulletSpeed, ForceMode.Impulse);
    }

    private bool _isShooted = false;
    private Vector3 _targetPos;
}
