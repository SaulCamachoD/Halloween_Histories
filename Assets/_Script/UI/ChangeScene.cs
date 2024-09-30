using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Script.UI
{
    public class ChangeScene : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject creditsPanel;

        private void Awake()
        {
            menuPanel.SetActive(true);
            creditsPanel.SetActive(false);
        }

        public void Play(string nameScene)
        {
            SceneManager.LoadScene(nameScene);
        }

        public void Credits()
        {
            menuPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }
        
        public void Quit()
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
    }
}
