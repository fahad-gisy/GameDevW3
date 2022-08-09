using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI gameTimer;
    public int timeLeft;
    void Start()
    {
        InvokeRepeating("CountDawn",1,1);
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer.text = ("" + timeLeft);
        if (timeLeft <= 0 )
        {
            
        }
    }

    private void CountDawn()
    {
        timeLeft--;
    }
}
