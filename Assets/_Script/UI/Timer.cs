
using TMPro;

using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;
    [SerializeField] private float timeElapsed;
    [SerializeField] private int minutes, seconds;
    [SerializeField] UIManager gameOverUI;

    private float currentTime, maxTime;
    public string CurrentTime => GetStringTime(currentTime);
    public string MaxTime => GetStringTime(maxTime);

    private bool _isDie;
    private void Update()
    {
        if (!_isDie)
        {
            timeElapsed += Time.deltaTime;
            textMesh.text = GetStringTime(timeElapsed);
        }
    }

    private string GetStringTime(float timeElapsed)
    {
        minutes = (int)(timeElapsed / 60f);
        seconds = (int)(timeElapsed - minutes * 60f);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Die()
    {
        _isDie = true;

        float maxTimeElapsed = PlayerPrefs.GetFloat("MaxTime");
        float currentTimeElapsed = timeElapsed;

        currentTime = currentTimeElapsed;
        maxTime = maxTimeElapsed;

        if (currentTimeElapsed > maxTimeElapsed)
        {
            PlayerPrefs.SetFloat("MaxTime", currentTimeElapsed);
        }

        gameOverUI.ShowGameOver(MaxTime, CurrentTime);

    }


}
