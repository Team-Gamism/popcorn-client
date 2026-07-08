using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetSystem : MonoBehaviour
{
    public void ResetGame()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
