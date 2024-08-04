using UnityEngine;
using UnityEngine.Playables;

namespace Script.Cinematic
{
    public class PlayTimeline : MonoBehaviour
    {
        public PlayableDirector playableDirector;

        private bool hasPlayed = false;

        // public GameObject player;
        // public MoveWill movementPlayer;

        private void Start()
        {
            // movementPlayer = player.GetComponent<MoveWill>();
            // playableDirector.stopped += OnPlayerDirectorStopped;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!hasPlayed && other.CompareTag("Player"))
            {
                // movementPlayer.enabled = false;
                playableDirector.Play();
                hasPlayed = true;
            }
        }

        // private void OnPlayerDirectorStopped(PlayableDirector director)
        // {
        //     if (director == playableDirector)
        //     {
        //         movementPlayer.enabled = true;
        //     }
        // }

        // private void OnDestroy()
        // {
        //     playableDirector.stopped -= OnPlayerDirectorStopped;
        // }
    }
}
