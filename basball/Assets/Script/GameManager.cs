using UnityEngine;
using UnityEngine.SceneManagement;   //引用 場景管理器 API

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void RestarGame()
    {
        SceneManager.LoadScene("basketball");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
