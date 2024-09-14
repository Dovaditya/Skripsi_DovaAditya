using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KarnivoraScript : MonoBehaviour
{
    void Start()
    {
 
    }
    void Update()
    {
        
    }
    public void Harimau(string scenename)//masuk ke menu deskripsi gajah
    {
        SceneManager.LoadScene(scenename);
    }

    public void Singa(string scenename)//masuk ke menu deskripsi sapi
    {
        SceneManager.LoadScene(scenename);
    }

    public void Trex(string scenename)//masuk ke menu deskripsi jerapah
    {
        SceneManager.LoadScene(scenename);
    }

    public void ButtonKembali(string scenename)//balik ke main menu
    {
        SceneManager.LoadScene(scenename);
    }
}
