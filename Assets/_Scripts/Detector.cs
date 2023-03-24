using UnityEngine;

public class Detector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game over");
    }
}
