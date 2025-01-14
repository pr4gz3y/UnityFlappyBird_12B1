using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _maxHeight = 0.45f;
    [SerializeField] private GameObject _pipe;
    private float _timer;
    private void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_maxHeight, +_maxHeight));

        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 5f);
    }

    private void Start() => Spawn();

    private void Update()
    {
        if (_timer > _maxTime) 
        { 
            Spawn();

            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
