using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] PreFinishBehviour _preFinishBehviour;
    [SerializeField] Animator _animator;

    void Start()
    {
        _playerMove.enabled = false;
        _preFinishBehviour.enabled = false;
    }

    public void Play()
    {
        _playerMove.enabled = true;
    }

    public void StartPreFinishBehaviour()
    {
        _playerMove.enabled = false;
        _preFinishBehviour.enabled = true;
    }

    public void StartFinishBehaviour()
    {
        _preFinishBehviour.enabled = false;
        _animator.SetTrigger("Dance");
    }
}
