using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public Renderer npcRenderer_inside;
    public Material npc_form_normal;
    public Material npc_form_ghost;
    public Material npc_form_ghost_angry;
    public Material npc_form_final;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        string triggerName = other.name;
        Debug.Log(triggerName);

        if(triggerName=="TriggerEvent1"){
            npcRenderer_inside.material = npc_form_ghost;
        }else if(triggerName=="TriggerEvent2"){
            npcRenderer_inside.material = npc_form_ghost_angry;
        }else if(triggerName=="TriggerEvent3"){
            npcRenderer_inside.material = npc_form_final;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
