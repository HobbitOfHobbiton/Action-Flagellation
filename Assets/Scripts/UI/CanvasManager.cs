using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ScoreSystem;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _multiplierText;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        _scoreText.text = ScoreManager.Score.ToString();
        _multiplierText.text = "x" + ScoreManager.ScoreMultiplier;
	}

    public void Quit()
    {
        Application.Quit();
    }
}
