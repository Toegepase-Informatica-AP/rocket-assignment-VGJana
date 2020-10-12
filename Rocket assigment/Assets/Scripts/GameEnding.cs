using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEnding : MonoBehaviour
{
    private string endgame = "You Won!";

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        textCoins.text = endgame.ToString();
    }
}
