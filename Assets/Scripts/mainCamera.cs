using UnityEngine;
using System;

public class mainCamera : MonoBehaviour
{ 
    private GameObject _player;
    private Vector3 _deltaOfVectors;
    private void Start()
    {
        _player = SceneObjectContainer.Player;
        _deltaOfVectors = transform.position - _player.transform.position;
    }
    private void Update()
    {
        transform.position = _player.transform.position + _deltaOfVectors; 
    }
}
