using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static int life = 3;
    GroundMovement groundMovement;
    Jump jump;
    ObjectSpawn objectSpawn;
    MusicianSpawn musicianSpawn;
    GameObject life1;
    GameObject life2;
    GameObject life3;

    GameObject start;
    GameObject credits;
    Credits creditScript;
    GameObject controls;
    GameObject exit;
    GameObject canvas;

    Animator animator;

    Score scoreScript;
    GameObject highScore;

    AudioSource backgroundMusic;
    GameObject title;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;

        groundMovement = GameObject.Find("ground").GetComponent<GroundMovement>();
        jump = GameObject.Find("Character").GetComponent<Jump>();
        objectSpawn = GameObject.Find("Spawner").GetComponent<ObjectSpawn>();
        musicianSpawn = GameObject.Find("MusicianSpawner").GetComponent<MusicianSpawn>();
        
        GameObject lifes = GameObject.Find("lifes");
        life1 = lifes.transform.GetChild(0).gameObject;
        life2 = lifes.transform.GetChild(1).gameObject;
        life3 = lifes.transform.GetChild(2).gameObject;
        start = GameObject.Find("Start");
        credits = GameObject.Find("Credits");
        creditScript = GameObject.Find("Credits").GetComponent<Credits>();
        controls = GameObject.Find("Controls");
        exit = GameObject.Find("Exit");

        highScore = GameObject.Find("HighScore");
        
        canvas = GameObject.Find("Canvas");
        
        animator = GetComponent<Animator>();

        scoreScript = GetComponent<Score>();

        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();

        title = GameObject.Find("Title");

        Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 2){
            life3.SetActive(false);
        }
        else if (life == 1){
            life2.SetActive(false);
        }
        else if (life == 0){
            life1.SetActive(false);
            Stop();
        }
    }

    public void Play(){
        groundMovement.enabled = true;
        jump.enabled = true;
        objectSpawn.enabled = true;
        musicianSpawn.enabled = true;
        musicianSpawn.ResetTimer();

        start.SetActive(false);
        exit.SetActive(false);
        credits.SetActive(false);
        creditScript.Close();
        controls.SetActive(false);

        life = 3;
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);

        animator.SetBool("Running", true);

        scoreScript.ResetCurrentScore();
        highScore.SetActive(false);
        title.SetActive(false);
    }

    void Stop(){
        groundMovement.enabled = false;
        jump.enabled = false;
        objectSpawn.enabled = false;
        musicianSpawn.enabled = false;
        MusicianSpawn.spawned = false;

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Finish");
        foreach (GameObject o in objects){
            Destroy(o);
        }

        animator.SetBool("Running", false);

        start.SetActive(true);
        credits.SetActive(true);
        controls.SetActive(true);
        exit.SetActive(true);
    
        Shooting.loaded = false;
        highScore.SetActive(true);
        scoreScript.HighScoreUpdate();

        backgroundMusic.pitch = 1;
        title.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Obstacle
        if (collider.gameObject.layer == 13){
            Destroy(collider.gameObject);
            life--;
        }
    }
}
