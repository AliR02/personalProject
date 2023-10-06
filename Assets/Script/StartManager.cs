
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour//load personal project scene(game)
{

    public void goToNextScene()
    {
        SceneManager.LoadScene("PersonalProject");
    }
}
