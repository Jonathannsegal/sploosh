using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private string city;
    private InputField input;

    void Awake()
    {
       // input = GameObject.Find("InputField").GetComponent<InputField>();
    }
  public void SetObject(string city)
    {
        this.city = city;
    }
    public string GetObject()
    {
        return city;
    }
}
