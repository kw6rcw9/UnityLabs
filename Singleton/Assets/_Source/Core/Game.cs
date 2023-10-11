using UnityEngine.SceneManagement;

namespace Core
{
    public class Game 
    {

        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    
    }
}
