using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUGUI;
    public GameObject scoreText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
        if (collision.gameObject.name == "ABC")
        {
            score++;
            TextMeshProUGUI.text = "Score: " + score;
            scoreText.SetActive(true);
            print("Score: " + score);   

        }

    }   
}
