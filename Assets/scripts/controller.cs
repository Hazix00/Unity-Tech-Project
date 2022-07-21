using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityTechProject.Assets.scripts;
using UnityTechProject.Assets.scripts.models;
using UnityEngine;

public class controller : MonoBehaviour
{
    private string jsonPath = "Assets/main.json";
    // Start is called before the first frame update
    void Start()
    {
        var json = File.ReadAllText(jsonPath);
        Nodes nodes = JsonConvert.DeserializeObject<Nodes>(json);
        Debug.Log(nodes.MainName);

        var nodesStore = new Dictionary<string, object>();
        
        foreach(var node in nodes.Main.Nodes) 
        {

            nodesStore.Add(node.NodeId.ToString(), node);
            if(node.NodeType == "SNode")
            {
                
                SNode currentNode = (SNode)node;
                foreach(var element in currentNode.NodeElements)
                {
                    switch(element.ElementType)
                    {
                        case "Character":
                            Character character = (element as CharacterElement).Character;
                            nodesStore.Add(character.Id, character);
                            break;
                        case "Sound":
                            Sound sound = (element as SoundElement).Sound;
                            nodesStore.Add(sound.ObjectId, sound);
                            break;
                    }
                }
            }
        }
        
        Debug.Log("SNode " + nodesStore["1"]);
        Debug.Log("LNode " + nodesStore["2"]);
        Debug.Log("Character " + nodesStore["B835u7t"]);
        Debug.Log("Sound " + nodesStore["iu8nfs"]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
