using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRegles : MonoBehaviour
{
    public void Retour()
    {
        SceneManager.LoadScene(0);
    }
}
