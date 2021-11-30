using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu: MonoBehaviour
{
[SerializeField] int Score;
public Text ScoreText;

    public void ButtonClick()
    {
        Score++;
    }
  
  public void Update()
  {
      ScoreText.text = Score.ToString();
  }
}
