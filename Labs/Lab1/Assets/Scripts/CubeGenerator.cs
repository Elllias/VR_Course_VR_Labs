using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Exception = System.Exception;

public class CubeGenerator : MonoBehaviour
{
    [Header("Real Data")]
    [SerializeField] private GameObject cubeTemplate;
    [SerializeField] private Transform spawnPosition;
    
    [Header("UI Data")]
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        var countCubes = 0;
        
        try
        {
            countCubes = int.Parse(inputField.text);
        }
        catch (Exception exception)
        {
            Debug.LogException(exception);
        }

        if (countCubes > 0)
            StartCoroutine(GenerateCubes(countCubes));
    }

    private IEnumerator GenerateCubes(int countCubes)
    {
        for (int i = 0; i < countCubes; i++)
        {
            Instantiate(cubeTemplate, spawnPosition);
            yield return new WaitForSeconds(0.25f);
        }
    }
}
