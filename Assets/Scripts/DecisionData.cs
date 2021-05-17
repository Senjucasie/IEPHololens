using System;
using UnityEngine;
[Serializable]
public class DecisionDataHolder
{
    public string Title;
    public string Content;
    public Color Colour;

    public DecisionDataHolder(string title,string content,Color color)
    {
        Title = title;
        Content = content;
        Colour = color;
    }
  
}
