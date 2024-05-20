using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void LoadUIandUXAssignmentScene()
    {
        // Load the "UIandUXAssignment" scene
        SceneManager.LoadScene("Game");
    }

    public void LoadLostScene()
    {
        // Load the "Lost" scene
        SceneManager.LoadScene("lost");
    }
   
}
