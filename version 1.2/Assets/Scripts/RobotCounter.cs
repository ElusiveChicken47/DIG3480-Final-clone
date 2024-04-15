using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RobotCounter : MonoBehaviour
{
    public static RobotCounter instance;

    public TMP_Text robotText;
    public int robotsFixed = 0;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        robotText.text = "ROBOTS FIXED: " + robotsFixed.ToString();
    }

    // Update is called once per frame
    public void IncreaseCount()
    {
        ++robotsFixed;
        robotText.text = "ROBOTS FIXED: " + robotsFixed.ToString();

        if (robotsFixed >= 4)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
