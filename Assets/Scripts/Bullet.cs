using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed;
    float _timer = 0;
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 3)
        {
            Destroy(gameObject);
        }
        gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
