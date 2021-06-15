using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public bool isGameEndStarted;
    LineFactory lineFactory;
    public GameObject GameEndCanvas;
    public TMPro.TextMeshProUGUI starText;
    public GameObject LoadNextLevelButton;
    public int starCount;
    public bool gameCleared;
    public int LoadAfterSec;
    public int currentScene;

    public GameObject pencil;
    public bool hasGameStarted;
    public List<Vector2> points;
    void Start()
    {
        pencil.SetActive(false);
        GameEndCanvas.SetActive(false);
        lineFactory = FindObjectOfType<LineFactory>();
    }

    void Update()
    {
    //    if (lineFactory.hasGameStarted && !isGameEndStarted)
    //    {
    //        Invoke("StartEndScreed", LoadAfterSec);
    //        isGameEndStarted = true;
    //    }

        if (Input.GetMouseButtonDown(0))
        {
            hasGameStarted = true;
           
        }
        if (Input.GetMouseButtonUp(0))
        {
            hasGameStarted = false;
            pencil.SetActive(false);
        }
        if (hasGameStarted)
        {
            pencil.SetActive(true);
            pencil.transform.position = new Vector3
                (points[points.Count - 1].x, points[points.Count - 1].y, 0);
        }
    }
    public void StartEndScreed()
    {
        GameEndCanvas.SetActive(true);
        if (!gameCleared)
        {
            LoadNextLevelButton.SetActive(false);
        }
    }

    public void LoadNextScene()
    {
        FindObjectOfType<OurSceneManager>().LoadScene(currentScene + 1);
    }
    public void RestartScene()
    {
        FindObjectOfType<OurSceneManager>().LoadScene(currentScene);
    }
}
