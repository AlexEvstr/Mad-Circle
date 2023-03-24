using UnityEngine;

public class UIPlayButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void OnClick()
    {
        _startPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
