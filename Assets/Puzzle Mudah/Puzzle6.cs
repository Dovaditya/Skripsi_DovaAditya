using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Puzzle6 : MonoBehaviour
{
    public GameObject[] item;
    public GameObject[] itemDrop;
    public int jarak;
    public Vector3[] itemPos;
    bool[] isDrop = new bool[4];//ini buat koreksi kalo udah di dalem kotak
    public GameObject panelwin;//ini buat kalo udah selesai puzzlenya
    public GameObject paneltimeout;
    public Image[] imagesLifes;//ini buat nyawa
    public Sprite spriteEmptyLife;
    int lifeCount;
    public Image imageDone;
    public Sprite[] spriteWinLose;
    [SerializeField] TextMeshProUGUI timerText; //ini buat field script timer
    [SerializeField] float remainingTime; //ini buat masukin berapa waktu yang diinginkan

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < itemPos.Length; i++)
        {
            itemPos[i] = item[i].transform.localPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;//ini kalo waktunya udah abis warnanya bakalan merah
            paneltimeout.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LifeChanceLeft()
    {  
        if(lifeCount < imagesLifes.Length - 1)//ini buat 3 kesempatan doang langsung kalah
        {
            imagesLifes[lifeCount].sprite = spriteEmptyLife;
            lifeCount++;
        }
        else
        {
            imagesLifes[lifeCount].sprite = spriteEmptyLife;//ini buat kalo gambar nyawanya bener kosong pas kalah
            imageDone.sprite = spriteWinLose[1];
            Time.timeScale = 0f;
            panelwin.SetActive(true);
            
            Debug.Log("Kalah");
        }
    }

    public void ItemDrag(int number)//ini buat drag gambarnya
    {
        if(isDrop[number] == false)
        {
        item[number].transform.position = Input.mousePosition;
        }
    }
    
    public void ItemEndDrag(int number)//ini buat drop gamabarnya
    {
        float distance = Vector3.Distance(item[number].transform.localPosition, itemDrop[number].transform.localPosition);

        if(distance < jarak)
        {
            item[number].transform.localPosition = itemDrop[number].transform.localPosition;

            isDrop[number] = true;

            CheckWin();//ini kalo bener semua naronya bakal muncul panel win

            Debug.Log("benar");
        }
        else
        {
            for (int i = 0; i < itemDrop.Length; i++)
            {
                if (i != number)
                {
                    float wrongPlace = Vector3.Distance(item[number].transform.localPosition, itemDrop[i].transform.localPosition);

                    if (wrongPlace < jarak)
                    {
                        Debug.Log("salah");

                        LifeChanceLeft();//ini kalo salah nyawanya berkurang 1

                        break;
                    }
                }
            }

            item[number].transform.localPosition = itemPos[number];
        }
    }

    void CheckWin()//ini buat panel win kalo game nya udah kelar
    {
        for (int i = 0; i < isDrop.Length; i++)
        {
         if(isDrop[i] == false)
         {
            return;
         }
         else
         {
            if(i == isDrop.Length - 1)
            {
                Time.timeScale = 0f;
                panelwin.SetActive(true);

                imageDone.sprite = spriteWinLose[0];
            }
         }   
        }
    }
    public void BBack(string scenename)//ini buton balik ke main menu
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1f;
    }
    public void BUlang(string scenename)//ini tombol buat ngulang scene
    {
        SceneManager.LoadScene(scenename);
        Time.timeScale = 1f;
    }
}