using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameWinPannel;
    public MovementController movementController;
    // Start is called before the first frame update
    void Start()
    {
        gameWinPannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameWin()
    {
        movementController.isActive = false;
        gameWinPannel.SetActive(true);
    }
   
   
}
