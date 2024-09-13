using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
using Unity.VisualScripting;

namespace Script
{
    public class Move : MonoBehaviour
    {
        [SerializeField] private float jumpForce = 10f;
        [SerializeField] public float timer;
        private float _incrementTime = 40f,_speedIncrement = 5f;
        [SerializeField] private LayerMask ground;
        [SerializeField] private Transform tf;
      //  [SerializeField] private Animator anim;


        private LaneRunner _runner;
        private Rigidbody _rb;
        private bool _jump;
        private void Start()
        {
            _runner = GetComponent<LaneRunner>();
            _rb = GetComponent<Rigidbody>();
            // anim = FindObjectOfType<Animator>();
            // StartCoroutine(Animation());
        }

        private void Update()
        {
            timer += Time.fixedDeltaTime;

            if (timer >= _incrementTime)
            {
                _runner.followSpeed += _speedIncrement;
                timer = 0f;
                
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)) _runner.lane--;
            if(Input.GetKeyDown(KeyCode.RightArrow)) _runner.lane++;
            
            _jump = Physics.Raycast(tf.position, Vector2.down, 2f, ground);

            if(Input.GetKeyDown(KeyCode.Space) && _jump) _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }

        // IEnumerator Animation()
        // {
        //     yield return new WaitForSeconds(2f);
        //     anim.SetTrigger("Action");
        // }

      /*  private void OnCollisionEnter(Collision collision)
        {
            if(collision.collider.tag =="Obstaculo")
            {
                _runner.follow = false;
                anim.ResetTrigger("Action");
                
            }
        }*/
    }
}