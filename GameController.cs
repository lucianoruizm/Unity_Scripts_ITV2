using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int _score = 0;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
    }

    public void ScoreUp(int score)
    {
        _score += score;
    }

}
