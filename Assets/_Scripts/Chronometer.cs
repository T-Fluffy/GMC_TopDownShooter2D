using UnityEngine;
using UnityEngine.UI;
public class Chronometer : MonoBehaviour
{
    float timer;
    public Text timerText;
    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = Mathf.Floor(timer).ToString();
    }
}
