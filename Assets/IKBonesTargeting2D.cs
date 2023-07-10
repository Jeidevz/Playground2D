using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

[DefaultExecutionOrder(-1)]
public class IKBonesTargeting2D : MonoBehaviour
{
    public Transform target;
    public Transform boneTransform;
    //public HumanBodyBones[] bones;
    //public Transform[] boneTransforms;
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>();
        //boneTransforms = new Transform[bones.Length];
        //for (int i = 0; i < boneTransforms.Length; i++)
        //{
        //    boneTransforms[i] = animator.GetBoneTransform(bones[i]);
        //}
    }

    // Update is called once per frame
    void LateUpdate()
    {
        BoneAimAtTarget(boneTransform, target.position);
    }

    void BoneAimAtTarget(Transform bone, Vector3 targetPosition)
    {
        Vector3 aimDirection = transform.right;
        Vector3 targetDirection = targetPosition - transform.position;
        Quaternion aimTowards = Quaternion.FromToRotation(aimDirection, targetDirection);
        bone.rotation = aimTowards * bone.rotation;

    }
}
