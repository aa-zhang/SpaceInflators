using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text timeText;
    [SerializeField] GameObject gameOverPanel;
    
    int score = 0;
    float secondsPassed = 0;

    public void EnableGameOverPanel(bool enable)
    {
        gameObject.SetActive(enable);
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
    }

    private void Update()
    {
        secondsPassed += Time.deltaTime;

        scoreText.text = $"Score: {score}";
        timeText.text = $"Time: {Mathf.FloorToInt(secondsPassed)}";
    }
}
