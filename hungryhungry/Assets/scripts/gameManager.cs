using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    
    //ends the game to game over screen
    public void Endgame()
    {
        
        SceneManager.LoadScene("Endgame");
    }


    // restarts the game on button click
    public void Startgame()
    {
        SceneManager.LoadScene("Prototype 2");
    }
}
