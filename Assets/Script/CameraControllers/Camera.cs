using UnityEngine;

namespace Script
{
    public class Camera : MonoBehaviour
    {
        public GameObject player;
 
        void Update()
        {
            transform.position = player.transform.position + new Vector3(0,5.30000019f,-9.55000019f);
        
        }
    }
}