using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Turel : MonoBehaviour
{
   [SerializeField] float Vision_radius = 10;
   [SerializeField] Transform Joint;
   [SerializeField] Transform Test_Object;
   [SerializeField] private float rotation_speed = 1;
    
   private SphereCollider vision_Collider;
    void Awake()
    {
        vision_Collider = GetComponent<SphereCollider>();
    }
    void Start()
    {
        vision_Collider.radius = Vision_radius;
    }
    void Update()
    {
        var rotDirection = Test_Object.position - Joint.position;
        Joint.rotation = Quaternion.LookRotation(rotDirection.normalized);
    }
}
