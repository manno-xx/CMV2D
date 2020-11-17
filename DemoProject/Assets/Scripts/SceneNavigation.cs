
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// </summary>
public class SceneNavigation : MonoBehaviour
{

    /// <summary>
    /// nice dessciptive text
    /// </summary>
    /// <param name="sceneName"></param>
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
