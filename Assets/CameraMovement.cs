using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform Playerbody;
    [SerializeField] float MouseSensetivity = 1;

    float y = 0;
    void Start()
    {

    }
    void Update()
    {
        var xRot = Input.GetAxis("Mouse X");
        var yRot = Input.GetAxis("Mouse Y");

        Playerbody.Rotate(new Vector3(0, xRot * MouseSensetivity, 0));
    }
}
