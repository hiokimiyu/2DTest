using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed;
    void Update()
    {
        gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
