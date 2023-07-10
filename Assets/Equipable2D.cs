using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-2)]
public class Equipable2D : MonoBehaviour
{
    public Transform equipperHoldTransform;
    public Transform beingEquipTransform;
    public Vector3 beingEquipOffset;
    public Vector3 frontDirection;

    //private void Start()
    //{
    //    if (!equipperHoldTransform)
    //        return;

    //    Equip(equipperHoldTransform, beingEquipTransform, beingEquipOffset, frontDirection);
    //}

    public void Equip(Transform equipper, Transform beingEquip, Vector3 offset, Vector3 forwardDirection)
    {
        Vector3 direction = beingEquip.right;
        direction.z = 0;
        Vector3 targetDirection = forwardDirection;
        targetDirection.z = 0;
        Quaternion targetRotation = Quaternion.FromToRotation(direction.normalized, targetDirection.normalized);
        beingEquip.rotation = targetRotation * beingEquip.rotation;
        beingEquip.parent = equipper;
        beingEquip.localPosition = offset;
        beingEquip.localScale = new Vector3(Mathf.Abs(beingEquip.localScale.x), Mathf.Abs(beingEquip.localScale.y), Mathf.Abs(beingEquip.localScale.z));  
    }

    public void Equip(Transform equipper, Vector3 forwardDirection)
    {      
        Equip(equipper, transform, beingEquipOffset, forwardDirection);
    }

    public void UnEquip()
    {
        beingEquipTransform.parent = null;
    }


}
