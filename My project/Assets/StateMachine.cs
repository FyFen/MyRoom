using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen, secondScreen;

    private GameObject currentScreen;

    private void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;

    }

    public void ChangeState(GameObject state)
    {
        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }       
    }
}
