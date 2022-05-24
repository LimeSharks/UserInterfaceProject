using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public void EnterMainScene()
    {
        SceneManager.LoadScene(0);
    }
    
    public void EnterButtonSearchScene()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterButtonClassicScene()
    {
        SceneManager.LoadScene(2);
    }

    public void EnterButtonSurviveScene()
    {
        SceneManager.LoadScene(3);
    }

    public void EnterSuperCupScene()
    {
        SceneManager.LoadScene(4);
    }

    public void EnterWinScene()
    {
        SceneManager.LoadScene(5);
    }
    
}
