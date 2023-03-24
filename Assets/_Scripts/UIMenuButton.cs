using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
