using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private float _score;
    private float _speed = 150.0f;

    public bool isMove;

    private void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        if (isMove)
            transform.Rotate(0, 0, _speed * Time.deltaTime);
        else
            transform.Rotate(0, 0, -_speed * Time.deltaTime);
        ChangeDirection();

        _scoreText.text = _score.ToString();
    }

    public void ChangeDirection()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            isMove = !isMove;
            _score++;
        }
    }
}
