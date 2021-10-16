using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Color[] _colors;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        SetColor(_colors[Random.Range(0, _colors.Length)]);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    { 
        _enemy.transform.Translate(_speed * Time.deltaTime, 0, 0);
    }

    private void SetColor(Color color)
    {
        _spriteRenderer.color = color;
    }
}
