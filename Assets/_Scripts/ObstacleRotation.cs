using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour
{
    private float _speed = 100.0f;
    private float _randomTime;

    public bool isMove;

    private void Start()
    {
        _randomTime = Random.Range(3, 5);
        StartCoroutine(Rotate());
    }

    private void Update()
    {
        if (isMove)
            transform.Rotate(0, 0, _speed * Time.deltaTime);
        else
            transform.Rotate(0, 0, -_speed * Time.deltaTime);
    }

    public IEnumerator Rotate()
    {
        while(true)
        {
            isMove = !isMove;
            yield return new WaitForSeconds(_randomTime);
        }
    }
}
