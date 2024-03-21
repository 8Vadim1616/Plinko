using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    public void ShowScore(int score)
    {
        scoreText.text= score.ToString();
    }
}
