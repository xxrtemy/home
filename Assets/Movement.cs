using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 m_Movement;
    [SerializeField] float m_Speed = 1;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        m_Movement.Set(horizontal, 0f, vertical);
        transform.Translate(m_Movement * Time.deltaTime * m_Speed); 
    }
}
