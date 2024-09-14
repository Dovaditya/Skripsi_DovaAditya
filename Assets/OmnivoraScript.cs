using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OmnivoraScript : MonoBehaviour
{
    void Start()
    {
 
    }
    void Update()
    {
        
    }
    public void Babi(string scenename)//masuk ke menu deskripsi gajah
    {
        SceneManager.LoadScene(scenename);
    }

    public void Beruang(string scenename)//masuk ke menu deskripsi sapi
    {
        SceneManager.LoadScene(scenename);
    }

    public void ButtonKembali(string scenename)//balik ke main menu
    {
        SceneManager.LoadScene(scenename);
    }
}