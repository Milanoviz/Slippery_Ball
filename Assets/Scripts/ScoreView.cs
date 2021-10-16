using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private ParticleSystem _bonusEffect;
    
    private int _score;

    private void Awake()
    {
        _losePanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Bonus bonus))
        {
            Instantiate(_bonusEffect, transform.position, Quaternion.identity);
            Destroy(bonus.gameObject);
            _score++;
            _scoreText.text = _score.ToString();
        }

        if (other.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            _losePanel.SetActive(true);
        }
    }
    
}
