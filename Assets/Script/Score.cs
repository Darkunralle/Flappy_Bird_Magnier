using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int _score;

    public void addScore()
    {
        _score++;
        GetComponent<TextMeshProUGUI>().text = "score : " + _score.ToString();
        
    }
}
