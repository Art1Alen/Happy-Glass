using UnityEngine.SceneManagement;
using UnityEngine;

public class OurSceneManager : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void LoadScene(int sceneNo = 0)
    {
        SceneManager.LoadScene(sceneNo);
    }

}
