using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeChanger : MonoBehaviour
{
    public GameObject[] themes;
    public GameObject[] themeSymbols;
    public AudioSource audioSource;
    private int currentTheme = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        for (int i = 0; i < themes.Length; i++) {
            themes[i].SetActive(false);
            themeSymbols[i].SetActive(false);
        }
        themes[currentTheme].SetActive(true);
        themeSymbols[currentTheme].SetActive(true);        
    }

    void OnMouseDown()
    {
        currentTheme = (currentTheme + 1) % themes.Length;
        ChangeTheme(currentTheme);
        audioSource.Play();
    }

    public void ChangeTheme(int themeIndex) {
        for (int i = 0; i < themes.Length; i++) {
            themes[i].SetActive(i == themeIndex);
            themeSymbols[i].SetActive(i == themeIndex);
        }
    }
}
