using System;
using UnityEngine;
//using UnityStandardAssets.Utility;

//namespace UnityStandardAssets.Characters.FirstPerson
//{
    public class HeadBob : MonoBehaviour
    {
        public Camera Camera;
//        public CurveControlledBob motionBob = new CurveControlledBob();
//        public LerpControlledBob jumpAndLandingBob = new LerpControlledBob();
//        public RigidbodyFirstPersonController rigidbodyFirstPersonController;
        public float StrideInterval;
        [Range(0f, 1f)] public float RunningStrideLengthen;

       // private CameraRefocus m_CameraRefocus;
        private bool m_PreviouslyGrounded;
        private Vector3 m_OriginalCameraPosition;

	    }
//}
