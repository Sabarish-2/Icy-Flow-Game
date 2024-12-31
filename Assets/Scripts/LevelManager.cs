using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float score = 0f;
    [SerializeField] private TMPro.TextMeshProUGUI scoreNumber;
    [SerializeField] private TMPro.TextMeshProUGUI scoreGameOver;
    public int health = 3;
    //[SerializeField] private TMPro.TextMeshProUGUI healthNumber;
    [SerializeField] private GameObject[] healths;
    [SerializeField] private GameObject gameOver;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        //healths = GameObject.FindGameObjectsWithTag("Health");
    }

    private void FixedUpdate()
    {
        if (health > 0) score += Time.deltaTime;
        scoreNumber.text = ((int)score).ToString();
    }
    // Update is called once per frame
    void Update()
    {

        if (health == 0)
        {
            // Pause the game completely
            Time.timeScale = 0;
            gameOver.SetActive(true);
            GameObject[] deactivate = GameObject.FindGameObjectsWithTag("PauseBtn");
            foreach (GameObject obj in deactivate) obj.SetActive(false);
            Destroy(player);
            scoreGameOver.text = ((int)score).ToString();
            healths[0].SetActive(false);
            healths[1].SetActive(false);
            healths[2].SetActive(false);
            healths[3].SetActive(false);
            healths[4].SetActive(false);
            health--;
        }
        else if (health == 1)
        {
            healths[0].SetActive(true);
            healths[1].SetActive(false);
            healths[2].SetActive(false);
            healths[3].SetActive(false);
            healths[4].SetActive(false);
        }
        else if (health == 2)
        {
            healths[0].SetActive(true);
            healths[1].SetActive(true);
            healths[2].SetActive(false);
            healths[3].SetActive(false);
            healths[4].SetActive(false);
        }
        else if (health == 3)
        {
            healths[0].SetActive(true);
            healths[1].SetActive(true);
            healths[2].SetActive(true);
            healths[3].SetActive(false);
            healths[4].SetActive(false);
        }
        else if (health == 4)
        {
            healths[0].SetActive(true);
            healths[1].SetActive(true);
            healths[2].SetActive(true);
            healths[3].SetActive(true);
            healths[4].SetActive(false);
        }
        else if (health == 5)
        {
            healths[0].SetActive(true);
            healths[1].SetActive(true);
            healths[2].SetActive(true);
            healths[3].SetActive(true);
            healths[4].SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}