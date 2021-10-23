using System;
using UnityEngine;

namespace ZennARFoundationDebug
{
    public class CubeGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject _cube;

        [SerializeField] private Camera mainCamera;

        public void GenerateRigidBodyCube()
        {
            if (_cube == null)
            {
                Debug.Log("cube prefab is null!");
                return;
            }

            if (mainCamera == null)
            {
                Debug.Log("camera is null!");
                return;
            }

            var transform1 = mainCamera.transform;
            var position = transform1.position + transform1.forward * 0.3f;

            Instantiate(_cube, position, Quaternion.identity);
        }
    }
}