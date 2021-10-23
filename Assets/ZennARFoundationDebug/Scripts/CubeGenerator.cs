using System;
using Unity.Mathematics;
using UnityEngine;

namespace ZennARFoundationDebug
{
    public class CubeGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject _cube;

        private Camera mainCamera;

        private void Start()
        {
            mainCamera = Camera.main;
        }

        public void GenerateRigidBodyCube()
        {
            if (_cube == null)
            {
                return;
            }

            var transform1 = mainCamera.transform;
            var position = transform1.position + transform1.forward * 0.1f;

            Instantiate(_cube, position, quaternion.identity);
        }
    }
}