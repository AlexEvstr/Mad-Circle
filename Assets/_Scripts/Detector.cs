using UnityEngine;

public class Detector : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
