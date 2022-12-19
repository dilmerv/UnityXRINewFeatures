using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    [SerializeField]
    private Vector3 force = Vector3.forward;

    private Rigidbody cachedRigidBody;

    private void Awake()
    {
        cachedRigidBody = GetComponent<Rigidbody>();
    }
    public void Force()
    {
        cachedRigidBody.AddForce(force);
    }
}
