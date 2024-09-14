using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Belajar : MonoBehaviour
{
    public GameObject belajarpanel;

    // Start is called before the first frame update
    void Start()
    {
        belajarpanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonKembali(string scenename)//balik kemain menu
    {
        SceneManager.LoadScene(scenename);
    }
    public void ButtonHerbivora(string scenename)//masuk ke scene herbivora
    {
        SceneManager.LoadScene(scenename);
    }
    public void ButtonKarnivora(string scenename)//masuk ke scene karnivora
    {
        SceneManager.LoadScene(scenename);
    }
    public void ButtonOmnivora(string scenename)//masuk ke scene omnivora
    {
        SceneManager.LoadScene(scenename);
    }

}