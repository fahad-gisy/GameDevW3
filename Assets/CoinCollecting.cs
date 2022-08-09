using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCollecting : MonoBehaviour
{
    // Start is called before the first frame update
    public SoundActions _soundActions;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<FPSMovingWThree>(out var playerMovingWThree))
        {
            _soundActions.PlayerCoinCollectSound();
            playerMovingWThree.coinCount++;
            Debug.Log("COINS : " + playerMovingWThree.coinCount);
            Destroy(gameObject);
        }
    }
}
