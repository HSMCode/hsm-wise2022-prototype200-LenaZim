using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UpdateTimer : MonoBehaviour
{
    // variable for GameUIs
        private GameObject _gameUI;
        private GameObject _gameOverUI;

    // variables for timer
        private Text timerUI;
        public string timerText = "Time: ";
        public float countRemaining = 60f;
        private bool countingDown = true;

    // variable for game over
        public bool gameOver;

        public GameObject Spawning;

    

    // Start is called before the first frame update
    void Start()
    {
        _gameUI = GameObject.Find("Game");
        _gameOverUI = GameObject.Find("GameOver");

        timerUI = GameObject.Find("Timer").GetComponent<Text>();

        _gameUI.SetActive(true);
        _gameOverUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        CountdownTimer();
    }

    private void CountdownTimer()
    {
        if(countingDown)
        {
            if(countRemaining > 0)
            {
                countRemaining -= Time.deltaTime;
                timerUI.text = timerText + Mathf.Round(countRemaining).ToString();
            }
            else 
            {
                countRemaining = 0;
                timerUI.text = timerText + countRemaining.ToString();
                countingDown = false;

                CheckGameOver();
            }
        }
    }

    private void CheckGameOver()
    {
        
        if(!countingDown)
        {
            
            gameOver = true;

            StartCoroutine(GameOver());
        }

        IEnumerator GameOver()
        {
            yield return new WaitForSeconds(2f);

            _gameUI.SetActive(true);
            _gameOverUI.SetActive(true);

            Destroy(Spawning);
        }
    }


}
