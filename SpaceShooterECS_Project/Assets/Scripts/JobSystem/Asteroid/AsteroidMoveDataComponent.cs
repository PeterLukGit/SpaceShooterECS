﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

namespace ECS_SpaceShooterDemo
{
    [System.Serializable]
    public struct AsteroidMoveData : IComponentData
    {
        public float3 position;
        public float3 forwardDirection;
        public float3 rotationAxis;
        public float rotationSpeed;
        public float3 renderForward;
        public float speed;
    }
    public class AsteroidMoveDataComponent : ComponentDataWrapper<AsteroidMoveData> { }
}

