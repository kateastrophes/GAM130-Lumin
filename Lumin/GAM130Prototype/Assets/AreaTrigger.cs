using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AreaTrigger : MonoBehaviour
{
    public Collider m_collider;

    public UnityEvent m_action;
    public UnityEvent m_reverseAction;

    void Start()
    {
        if (m_collider == null) m_collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other) {
        m_action.Invoke();
    }

    private void OnTriggerExit(Collider other) {
        m_reverseAction.Invoke();
    }
}
