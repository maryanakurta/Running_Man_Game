using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearance _gateAppearance;

    private void OnValidate()
    {
        _gateAppearance.UpdateVisual(_deformationType, _value);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModofier playerModofier = other.attachedRigidbody.GetComponent<PlayerModofier>();
        if(playerModofier != null)
        {
            if(_deformationType == DeformationType.Width)
            {
                playerModofier.AddWidth(_value);
            }
            else if(_deformationType == DeformationType.Height)
            {
                playerModofier.AddHeight(_value);
            }
            Destroy(gameObject);
        }
    }
}