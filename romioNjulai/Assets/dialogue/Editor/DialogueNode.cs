using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEditor.Experimental.GraphView;

public class DialogueNode : Node
{
    public string GUID;

    public string dialogueText;

    public bool entryPoint = false;
}
