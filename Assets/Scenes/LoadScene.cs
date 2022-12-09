using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
    }
    public void MoveToScene(int SIMULATION)
    {
        SceneManager.LoadScene(SIMULATION);
    }
}