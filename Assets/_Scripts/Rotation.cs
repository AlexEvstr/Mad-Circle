using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _speed = 150.0f;

    public bool isMove;

    private void Update()
    {
        if (isMove)
            transform.Rotate(0, 0, _speed * Time.deltaTime);
        else
            transform.Rotate(0, 0, -_speed * Time.deltaTime);
        ChangeDirection();
    }

    public void ChangeDirection()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        isMove = !isMove;
    }
}
