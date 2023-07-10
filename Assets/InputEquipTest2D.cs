using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(1)]
public class InputEquipTest2D : MonoBehaviour
{
    public Transform equipper;
    public Equipable2D equipable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            equipable.Equip(equipper, equipper.right);
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            equipable.UnEquip();
        }
    }
}
