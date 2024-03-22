using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject _bricksEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModofier playerModofier = other.attachedRigidbody.GetComponent<PlayerModofier>();
        if(playerModofier)
        {
            playerModofier.HitBarrier();
            Destroy(gameObject);
            Instantiate(_bricksEffectPrefab, transform.position, transform.rotation);
        }
    }
}
