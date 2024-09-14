using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;
    
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Button untuk Mulai ke scene game
    public void ButtonMulai(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    //Button untuk Mulai ke scene belajar
    public void ButtonBelajar(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    //Button untuk info ke infopanel
    public void ButtonInfo()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);

    }
    //Button untuk kembali dari infopanel ke main menu
    public void ButtonKembali()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    public void ButtonKeluar()
    {
        Application.Quit();
        Debug.Log("Tombol Keluar Telah Ditekan..");
    }
}
