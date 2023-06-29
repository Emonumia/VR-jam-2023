using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Missileexplosion : MonoBehaviour
{
    public UnityEvent collisionEvent; // UnityEvent to trigger when a collision occurs

    private void OnCollisionEnter(Collision collision)
    {
        collisionEvent.Invoke();
    }
}
