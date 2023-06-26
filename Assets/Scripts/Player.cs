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
    int _count = 0;
    void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        gameObject.transform.position += new Vector3(h, y, 0) * _speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(_bullet, _bulletPos.position, Quaternion.identity);
        }

        if (Input.GetButtonDown("Jump") && _count <= 1)
        {
            _count++;
            y = 100f;
        }
        else
        {
            if (gameObject.transform.position.y > -4)
            {
                y = -0.8f;
            }
            else
            {
                _count = 0;
                y = 0;
            }
        }
    }
}
