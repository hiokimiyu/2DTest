using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _bulletPos;
    [SerializeField] float _speed;
    bool _isJamp = false;
    float y = 0;
    void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        gameObject.transform.position += new Vector3(h, y, 0) * _speed * Time.deltaTime;

        if (_isJamp)
        {
            y = 3f;
        }
        else
        {
            if (gameObject.transform.position.y > -4)
            {
                y = -9.8f;
            }
            else
            {
                y = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(_bullet, _bulletPos.position, Quaternion.identity, gameObject.transform);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJamp = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _isJamp = false;
        }
    }
}
