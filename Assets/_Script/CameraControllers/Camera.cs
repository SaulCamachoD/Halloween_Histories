using UnityEngine;

namespace Script
{
    public class Camera : MonoBehaviour
    {
        public GameObject player;
 
        void Update()
        {
            transform.position = player.transform.position + new Vector3(0,8.77499962f,-12.8900003f);
        
        }
    }
}