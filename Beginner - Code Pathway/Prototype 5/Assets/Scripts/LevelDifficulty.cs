using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDifficulty : MonoBehaviour
{

    private Button button;
    private GameManager gameManager;
    public int difficulty; // 1 = Easy, 2 = Medium, 3 = Hard

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log("Difficulty set to: " + button.name);
        gameManager.StartGame(difficulty);
    }
}
