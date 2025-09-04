using UnityEngine;
using TMPro;

public class OpenURL : MonoBehaviour
{
    public string url; // URL a abrir

    public void OpenLink()
    {
        Application.OpenURL(url);
    }
}