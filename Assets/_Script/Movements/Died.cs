using System.Collections;
using Dreamteck.Forever;
using UnityEngine;
using UnityEngine.Playables;

public class Died : MonoBehaviour
{
    [SerializeField] private PlayableDirector _timelineClip;
    [SerializeField] private LaneRunner _laneRunner;
    [SerializeField] private Timer timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstaculo"))
        {
            _laneRunner.enabled = false;
            _timelineClip.enabled = true;
            StartCoroutine(TimerUI());
        }
    }

    IEnumerator TimerUI()
    {
        yield return new WaitForSeconds(2f);
        timer.Die();
    }
}
