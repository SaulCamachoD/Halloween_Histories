using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject TimeUI;

    [SerializeField] TMP_Text record;
    [SerializeField] TMP_Text current;

    public void ShowGameOver(string recordText, string currentText)
    {
        GameOverUI.SetActive(true);
        TimeUI.SetActive(false);
        record.text = recordText;
        current.text = currentText;
    }
}
