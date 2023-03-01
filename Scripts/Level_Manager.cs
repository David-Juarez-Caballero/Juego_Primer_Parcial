using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
   
{
    public enum Levels { Main_Menu = 0, Lv_1 = 1}    

    public void ChangeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Salir()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
