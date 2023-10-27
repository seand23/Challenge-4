using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLButton : MonoBehaviour
{
    public void OpenURL()
    {
        Application.OpenURL("https://github.com/seand23?tab=repositories");
    }
}
