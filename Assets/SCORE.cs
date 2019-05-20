using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (Time.timeSinceLevelLoad * 2f).ToString("0");
    }
}
