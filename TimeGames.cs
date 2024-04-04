using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeGames : MonoBehaviour
{
    public GameObject takeMistakes;
    public GameObject CanvasObject;
    public Sprite gameover;
    public float timeRemaining = 30;
    public Text timeLeft;
    public AudioClip audioClipTime;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(audioClipTime);
    }

    // Update is called once per frame
    void Update()
    {
    
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timeLeft.text = "Time Left: " + ((int)timeRemaining).ToString();
        }
        else
        {
            takeMistakes.GetComponent<ChangeFlag>().setGameOver(gameover);
            CanvasObject.GetComponent<Canvas> ().enabled = false;
            StartCoroutine(waiter());
        }
            
           
        

    }
    IEnumerator waiter()
    {
    //Wait for 4 seconds
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene("GameOver");

    }
}
