using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class ScoreScript : MonoBehaviour
{
  public int PlayerScore;
  public Text ScoreText;
  public GameObject GameOVERSCREEN;
  [ContextMenu("Increse Score")]
  public void addScore(int scoreToAdd)
    {
        PlayerScore = PlayerScore + scoreToAdd;
        ScoreText.text = PlayerScore.ToString();
    }

    
}
