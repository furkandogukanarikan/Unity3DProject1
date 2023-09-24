using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Udemy3DProject1.Inputs;


namespace Unity3DProject1.Controllers
{
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rigidbody;
        DefaultInput _input;
        private bool _isForceUp;
        
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }


        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
        }


        private void FixedUpdate()
        {
            _rigidbody.AddForce(Vector3.up * Time.deltaTime * _force);
        }
    }
}

