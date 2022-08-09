using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI gameTimer;
    public int timeLeft;
    public Image clockTimer;
    private float timeAmout = 1f;

    void Start()
    {
        InvokeRepeating("CountDawn",1,1);
    }

    // Update is called once per frame
    void Update()
    {

        clockTimer.fillAmount = timeAmout;
        timeAmout -= 0.017f * Time.deltaTime;
        
        gameTimer.text = ("" + timeLeft);
        if (timeLeft <= 0 )
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    private void CountDawn()
    {
        timeLeft--;
    }
}
