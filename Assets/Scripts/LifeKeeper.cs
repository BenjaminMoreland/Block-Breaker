using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeKeeper : MonoBehaviour
{
    int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = lives.ToString();
    }
    public void DecreaseLives()
    {
        lives--;
        GetComponent<Text>().text = lives.ToString();
    }
}