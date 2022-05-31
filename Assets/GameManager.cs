using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public void SceneReset()
    {
        string acticeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(acticeSceneName);
    }

    public void ChangeScene(string NextScene)
    {
        SceneManager.LoadScene(NextScene);
    }

    private int coinCount;
    private void Start()
    {
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate = 60;
        coinCount = 0;
    }
    public Text textComponent;
    public void addCoinCount()
    {
        coinCount = coinCount + 1;
        Debug.Log("coinCount:" + coinCount);
        textComponent.text = "coinCount : " + coinCount;
    }
}
