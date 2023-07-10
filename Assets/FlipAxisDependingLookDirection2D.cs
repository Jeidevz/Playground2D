using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FlipAxisDependingLookDirection2D : MonoBehaviour
{
    [System.Serializable]
    public class Axis
    {
        public bool x = false, y = false, z = false;
    }

    //[System.Serializable]
    public enum LookDirection
    {
        RIGHT,
        LEFT,
        NONE
    }

    public Transform targetDirectionTransform;
    public Transform lookerTransform;
    public Axis flipAxis;
    [Space(10)]
    public LookDirection defaultLookDirection;

    LookDirection currentLookDirection = LookDirection.NONE;

    private void Start()
    {
        if (defaultLookDirection == LookDirection.NONE)
            return;

        FlipToDirection(lookerTransform, defaultLookDirection, flipAxis.x, flipAxis.y, flipAxis.z);
        currentLookDirection = defaultLookDirection;
    }

    void Update()
    {
        LookDirection lookDirection = CheckLookDirection();

        if (lookDirection == currentLookDirection)
            return;

        FlipToDirection(transform, lookDirection, flipAxis.x, flipAxis.y, flipAxis.z);
        currentLookDirection = lookDirection;
    }

    void FlipAxis(bool flipX, bool flipY, bool flipZ)
    {
        float x = (flipX) ? -transform.localScale.x : transform.localScale.x;
        float y = (flipY) ? -transform.localScale.y : transform.localScale.y;
        float z = (flipZ) ? -transform.localScale.z : transform.localScale.z;
        transform.localScale = new Vector3(x, y, z);
    }

    bool IsLookingRight()
    {
        float dotResult = Vector3.Dot(transform.right, (targetDirectionTransform.position - lookerTransform.position).normalized);
        if (dotResult > 0)
        {
            return true;
        }

        return false;
    }

    LookDirection CheckLookDirection()
    {
        if(IsLookingRight())
        {
            return LookDirection.RIGHT;
        }

        return LookDirection.LEFT;
    }
     void FlipAxis(LookDirection defaultLookDirection)
    {
        if(!IsLookingRight() && transform.localScale.y < 0)
        {
            FlipAxis(flipAxis.x, flipAxis.y, flipAxis.z);
            currentLookDirection = LookDirection.LEFT;
        }

        currentLookDirection = LookDirection.RIGHT;
    }

    Vector3 GetSpecificTransformScaleValuesAsPositive(Vector3 scaleValues, bool changeXValue, bool changeYValue, bool changeZValue)
    {
        float x = (changeXValue) ? Mathf.Abs(scaleValues.x) : scaleValues.x;
        float y = (changeYValue) ? Mathf.Abs(scaleValues.y) : scaleValues.y;
        float z = (changeZValue) ? Mathf.Abs(scaleValues.z) : scaleValues.z;
        Vector3 result = new Vector3(x, y, z);

        return result;
    }

    Vector3 GetSpecificTransformScaleValuesAsNegative(Vector3 scaleValues, bool changeXValue, bool changeYValue, bool changeZValue)
    {
        Vector3 scaleValuesAsPositive = GetSpecificTransformScaleValuesAsPositive(scaleValues, changeXValue, changeYValue, changeZValue);
        float x = (changeXValue) ? -scaleValues.x : scaleValues.x;
        float y = (changeYValue) ? -scaleValues.y : scaleValues.y;
        float z = (changeZValue) ? -scaleValues.z : scaleValues.z;
        Vector3 result = new Vector3(x, y, z);

        return result;
    }


    void FlipToDirection(Transform flippingTransform, LookDirection direction, bool targetXAxis, bool targetYAxis, bool targetZAxis)
    {
        if (direction == LookDirection.NONE)
            return;

        if(direction == LookDirection.RIGHT)
        {
            Vector3 scaleDirection = GetSpecificTransformScaleValuesAsPositive(flippingTransform.localScale, targetXAxis, targetYAxis, targetZAxis);
            flippingTransform.localScale = scaleDirection;
            return;
        }

        if(direction == LookDirection.LEFT)
        {
            Vector3 scaleDirection = GetSpecificTransformScaleValuesAsNegative(flippingTransform.localScale, targetXAxis, targetYAxis, targetZAxis);
            flippingTransform.localScale = scaleDirection;
        }
    }
}
