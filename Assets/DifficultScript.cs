using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonKembali(string scenename)//balik kemain menu
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1f;
    }
    public void ButtonEasy()
    {
        int index = Random.Range(2, 10);
        SceneManager.LoadScene(index);
        Time.timeScale = 1f;
    }
    public void ButtonMenengah()
    {
        int index = Random.Range(11, 19);
        SceneManager.LoadScene(index);
        Time.timeScale = 1f;
    }
    public void ButtonSulit()
    {
        int index = Random.Range(20, 28);
        SceneManager.LoadScene(index);
        Time.timeScale = 1f;
    }
}
