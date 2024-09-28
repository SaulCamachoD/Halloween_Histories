using System;
using System.Collections;
using System.Collections.Generic;
using Dreamteck.Forever;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Died : MonoBehaviour
{
    [SerializeField] private PlayableDirector _timelineClip;
    [SerializeField] private LaneRunner _laneRunner;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstaculo"))
        {
            _laneRunner.enabled = false;
            _timelineClip.enabled = true;
            
        }
    }
    
}
