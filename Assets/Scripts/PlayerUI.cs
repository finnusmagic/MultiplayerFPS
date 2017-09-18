using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField] RectTransform thrusterFuelFill;

    [SerializeField] GameObject pauseMenu;

    PlayerController controller;

    void Update()
    {
        SetFuelAmount (controller.GetThrusterFuelAmount());

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void Start()
    {
        PauseMenu.isOn = false;
    }

    public void SetController(PlayerController _controller)
    {
        controller = _controller;
    }

    void SetFuelAmount(float _amount)
    {
        thrusterFuelFill.localScale = new Vector3(1f, _amount, 1f);
    }

    void TogglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        PauseMenu.isOn = pauseMenu.activeSelf;
    }
}
