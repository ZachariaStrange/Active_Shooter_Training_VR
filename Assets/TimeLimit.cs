using UnityEngine;
using TMPro; // Add this for TextMeshPro

public class TimeLimit : MonoBehaviour
{
    public float timeLimit = 30f;
    private float timeRemaining;
    public TMP_Text timerText; // Use TMP_Text instead of Text

    private bool isTimeUp = false;

    void Start()
    {
        timeRemaining = timeLimit;
    }

    void Update()
    {
        if (!isTimeUp)
        {
            timeRemaining -= Time.deltaTime;

            if (timerText != null)
                timerText.text = "Time Remaining: " + Mathf.Max(0, Mathf.FloorToInt(timeRemaining));

            if (timeRemaining <= 0)
            {
                isTimeUp = true;
                TimerEnded();
            }
        }
    }

    void TimerEnded()
    {
        Debug.Log("Time's up!");
    }
}
