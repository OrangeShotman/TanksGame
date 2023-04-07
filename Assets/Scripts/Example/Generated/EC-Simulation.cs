// THIS IS A GENERATED FILE, DO NOT EDIT
// any changes you make here will be overwritten with no mercy
#pragma warning disable 0168

#region Generated Code
using System;
using System.Collections.Generic;
using OrangeShotStudio.Packer;
using UnityEngine;

namespace Common.Simulation
{
    // DO NOT EDIT - generated from Generator/EC/Simulation/MovementComponent.cs
    public sealed class MovementComponent : IComponent
    {
        public Vector2 Movement;
        public void Reset()
        {
            Movement = default(Vector2);
        }
        public static bool DifferForPack(MovementComponent c1, MovementComponent c2)
        {
            bool null1, null2;
            if (c1.Movement.x != c2.Movement.x || c1.Movement.y != c2.Movement.y) return true;
            return false;
        }
        public void Repack()
        {
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is MovementComponent && (MovementComponent) obj == this;
        }
        public static void CopyMovement(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromMovement2 = fromEntity.Movement;
            if (fromMovement2 == null)
            {
                to[id].DelMovement();
                return;
            }
            var toMovement1 = toEntity.Movement;
            if (toMovement1 == null)
            {
                toMovement1 = to[id].AddMovement();
            }
            toMovement1.Movement = fromMovement2.Movement;
        }
        public static void CopyMovementPassive(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromMovement2 = fromEntity.Movement;
            if (fromMovement2 == null)
            {
                return;
            }
            var toMovement1 = toEntity.Movement;
            if (toMovement1 == null)
            {
                return;
            }
            toMovement1.Movement = fromMovement2.Movement;
        }
        public static bool operator ==(MovementComponent a, MovementComponent b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }
            if ((object)a == null && (object)b != null)
            {
                return false;
            }
            if ((object)a != null && (object)b == null)
            {
                return false;
            }
            bool aFieldIsNull, bFieldIsNull;
            if (Math.Abs(a.Movement.x - b.Movement.x) > 0.01f || Math.Abs(a.Movement.y - b.Movement.y) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(MovementComponent a, MovementComponent b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/Simulation/Projectile.cs
    public sealed class Projectile : IComponent
    {
        public float Damage;
        public int DestroyTick;
        public uint Source;
        public float Speed;
        public void Reset()
        {
            Damage = default(float);
            DestroyTick = default(int);
            Source = default(uint);
            Speed = default(float);
        }
        public static bool DifferForPack(Projectile c1, Projectile c2)
        {
            bool null1, null2;
            if (c1.Damage != c2.Damage) return true;
            if (c1.DestroyTick != c2.DestroyTick) return true;
            if (c1.Source != c2.Source) return true;
            if (c1.Speed != c2.Speed) return true;
            return false;
        }
        public void Repack()
        {
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is Projectile && (Projectile) obj == this;
        }
        public static void CopyProjectile(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromProjectile2 = fromEntity.Projectile;
            if (fromProjectile2 == null)
            {
                to[id].DelProjectile();
                return;
            }
            var toProjectile1 = toEntity.Projectile;
            if (toProjectile1 == null)
            {
                toProjectile1 = to[id].AddProjectile();
            }
            toProjectile1.Damage = fromProjectile2.Damage;
            toProjectile1.DestroyTick = fromProjectile2.DestroyTick;
            toProjectile1.Source = fromProjectile2.Source;
            toProjectile1.Speed = fromProjectile2.Speed;
        }
        public static void CopyProjectilePassive(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromProjectile2 = fromEntity.Projectile;
            if (fromProjectile2 == null)
            {
                return;
            }
            var toProjectile1 = toEntity.Projectile;
            if (toProjectile1 == null)
            {
                return;
            }
            toProjectile1.Damage = fromProjectile2.Damage;
            toProjectile1.DestroyTick = fromProjectile2.DestroyTick;
            toProjectile1.Source = fromProjectile2.Source;
            toProjectile1.Speed = fromProjectile2.Speed;
        }
        public static bool operator ==(Projectile a, Projectile b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }
            if ((object)a == null && (object)b != null)
            {
                return false;
            }
            if ((object)a != null && (object)b == null)
            {
                return false;
            }
            bool aFieldIsNull, bFieldIsNull;
            if (Math.Abs(a.Damage - b.Damage) > 0.01f)
            {
                return false;
            }
            if (a.DestroyTick != b.DestroyTick)
            {
                return false;
            }
            if (a.Source != b.Source)
            {
                return false;
            }
            if (Math.Abs(a.Speed - b.Speed) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Projectile a, Projectile b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/Simulation/RemoveEntityComponent.cs
    public sealed class RemoveEntityComponent : IComponent
    {
        public void Reset()
        {
        }
        public static bool DifferForPack(RemoveEntityComponent c1, RemoveEntityComponent c2)
        {
            bool null1, null2;
            return false;
        }
        public void Repack()
        {
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is RemoveEntityComponent && (RemoveEntityComponent) obj == this;
        }
        public static void CopyRemoveEntityComponent(TableSet from, TableSet to, uint id)
        {
            if (to[id].RemoveEntityComponent == null && from[id].RemoveEntityComponent != null)
            {
                to[id].AddRemoveEntityComponent();
            }
        }
        public static void CopyRemoveEntityComponentPassive(TableSet from, TableSet to, uint id)
        {
        }
        public static bool operator ==(RemoveEntityComponent a, RemoveEntityComponent b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }
            if ((object)a == null && (object)b != null)
            {
                return false;
            }
            if ((object)a != null && (object)b == null)
            {
                return false;
            }
            bool aFieldIsNull, bFieldIsNull;
            return true;
        }
        public static bool operator !=(RemoveEntityComponent a, RemoveEntityComponent b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/Simulation/Transform.cs
    public sealed class Transform : IComponent
    {
        public Vector2 Forward;
        public Vector3 Position;
        public void Reset()
        {
            Forward = default(Vector2);
            Position = default(Vector3);
        }
        public static bool DifferForPack(Transform c1, Transform c2)
        {
            bool null1, null2;
            if (c1.Forward.x != c2.Forward.x || c1.Forward.y != c2.Forward.y) return true;
            if (c1.Position.x != c2.Position.x || c1.Position.y != c2.Position.y || c1.Position.z != c2.Position.z) return true;
            return false;
        }
        public void Repack()
        {
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is Transform && (Transform) obj == this;
        }
        public static void CopyTransform(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromTransform2 = fromEntity.Transform;
            if (fromTransform2 == null)
            {
                to[id].DelTransform();
                return;
            }
            var toTransform1 = toEntity.Transform;
            if (toTransform1 == null)
            {
                toTransform1 = to[id].AddTransform();
            }
            toTransform1.Forward = fromTransform2.Forward;
            toTransform1.Position = fromTransform2.Position;
        }
        public static void CopyTransformPassive(TableSet from, TableSet to, uint id)
        {
            var fromEntity = from[id];
            if (fromEntity == null)
            {
                return;
            }
            var toEntity = to[id];
            if (toEntity == null)
            {
                return;
            }
            var fromTransform2 = fromEntity.Transform;
            if (fromTransform2 == null)
            {
                return;
            }
            var toTransform1 = toEntity.Transform;
            if (toTransform1 == null)
            {
                return;
            }
            toTransform1.Forward = fromTransform2.Forward;
            toTransform1.Position = fromTransform2.Position;
        }
        public static bool operator ==(Transform a, Transform b)
        {
            if ((object)a == null && (object)b == null)
            {
                return true;
            }
            if ((object)a == null && (object)b != null)
            {
                return false;
            }
            if ((object)a != null && (object)b == null)
            {
                return false;
            }
            bool aFieldIsNull, bFieldIsNull;
            if (Math.Abs(a.Forward.x - b.Forward.x) > 0.01f || Math.Abs(a.Forward.y - b.Forward.y) > 0.01f)
            {
                return false;
            }
            if (Math.Abs(a.Position.x - b.Position.x) > 0.01f || Math.Abs(a.Position.y - b.Position.y) > 0.01f || Math.Abs(a.Position.z - b.Position.z) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Transform a, Transform b)
        {
            return !(a == b);
        }
    }
    [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
    [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
    [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
    public sealed class TableSet
    {
        public sealed class Pools
        {
            public Pool<Entity> Entity = new Pool<Entity>();
            public uint[] EntityUseCount = new uint[1024];
            public Pool<MovementComponent> MovementComponent = new Pool<MovementComponent>();
            public Pool<Projectile> Projectile = new Pool<Projectile>();
            public Pool<RemoveEntityComponent> RemoveEntityComponent = new Pool<RemoveEntityComponent>();
            public Pool<Transform> Transform = new Pool<Transform>();
            public Pools()
            {
            }
        }
        [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
        [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.ArrayBoundsChecks, false)]
        [Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.DivideByZeroChecks, false)]
        public sealed class Packer
        {
            public struct Stats
            {
                public int Entities;
                public int Movement;
                public int Projectile;
                public int RemoveEntityComponent;
                public int Transform;
            }
            public void Pack(TableSet ts, BitPacker p)
            {
                Pack(ts, p, ref dummyStat);
            }
            public void Pack(TableSet ts, BitPacker p, ref Stats stats)
            {
                p.PackUInt32(ts.NextId);
                stats.Entities = -p.BitCount;
                p.PackUInt32((uint)ts._entityCount, EntityCountBits);
                var entityIdBits = BitMath.CalcUsedBits(ts.NextId);
                uint prevId = 0;
                for (var i = 0; i < ts._entityCount; i++)
                {
                    var id = ts._entityIds[i];
                    var dId = id - prevId;
                    if (dId < 16)
                    {
                        p.PackByte((byte)dId, 4);
                    }
                    else
                    {
                        p.PackByte(0, 4);
                        p.PackUInt32(id, entityIdBits);
                    }
                    prevId = id;
                }
                stats.Entities += p.BitCount;
                var entityIndexBits = BitMath.CalcUsedBits((uint)ts._entityCount + 1u);
                stats.Movement = -p.BitCount;
                if (ts.Movement.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Movement.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Movement.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Movement);
                    }
                }
                stats.Movement += p.BitCount;
                stats.Projectile = -p.BitCount;
                if (ts.Projectile.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Projectile.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Projectile.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackFloat(c.Damage);
                        p.PackSInt32(c.DestroyTick);
                        p.PackUInt32(c.Source);
                        p.PackFloat(c.Speed);
                    }
                }
                stats.Projectile += p.BitCount;
                stats.RemoveEntityComponent = -p.BitCount;
                if (ts.RemoveEntityComponent.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.RemoveEntityComponent.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.RemoveEntityComponent.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                    }
                }
                stats.RemoveEntityComponent += p.BitCount;
                stats.Transform = -p.BitCount;
                if (ts.Transform.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Transform.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Transform.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Forward);
                        p.PackVector3(c.Position);
                    }
                }
                stats.Transform += p.BitCount;
            }
            public void PersonalizedPack(TableSet ts, BitPacker p, uint clientId, ref Stats stats)
            {
                p.PackUInt32(ts.NextId);
                stats.Entities = -p.BitCount;
                p.PackUInt32((uint)ts._entityCount, EntityCountBits);
                var entityIdBits = BitMath.CalcUsedBits(ts.NextId);
                uint prevId = 0;
                for (var i = 0; i < ts._entityCount; i++)
                {
                    var id = ts._entityIds[i];
                    var dId = id - prevId;
                    if (dId < 16)
                    {
                        p.PackByte((byte)dId, 4);
                    }
                    else
                    {
                        p.PackByte(0, 4);
                        p.PackUInt32(id, entityIdBits);
                    }
                    prevId = id;
                }
                stats.Entities += p.BitCount;
                var entityIndexBits = BitMath.CalcUsedBits((uint)ts._entityCount + 1u);
                stats.Movement = -p.BitCount;
                if (ts.Movement.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Movement.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Movement.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Movement);
                    }
                }
                stats.Movement += p.BitCount;
                stats.Projectile = -p.BitCount;
                if (ts.Projectile.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Projectile.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Projectile.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackFloat(c.Damage);
                        p.PackSInt32(c.DestroyTick);
                        p.PackUInt32(c.Source);
                        p.PackFloat(c.Speed);
                    }
                }
                stats.Projectile += p.BitCount;
                stats.RemoveEntityComponent = -p.BitCount;
                if (ts.RemoveEntityComponent.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.RemoveEntityComponent.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.RemoveEntityComponent.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                    }
                }
                stats.RemoveEntityComponent += p.BitCount;
                stats.Transform = -p.BitCount;
                if (ts.Transform.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Transform.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Transform.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Forward);
                        p.PackVector3(c.Position);
                    }
                }
                stats.Transform += p.BitCount;
            }
            public void Unpack(TableSet ts, BitUnpacker p)
            {
                ts.NextId = p.UnpackUInt32();
                int count = (int)p.UnpackUInt32(EntityCountBits);
                ts.DiscardAndResizeEntities(count);
                var entityIdBits = BitMath.CalcUsedBits(ts.NextId);
                uint prevId = 0;
                for (int i = 0; i < count; i++)
                {
                    var id = (uint)p.UnpackByte(4);
                    if (id > 0) id += prevId;
                    else id = p.UnpackUInt32(entityIdBits);
                    ts._entityData[i].Id = id;
                    ts._entityIds[i] = id;
                    prevId = id;
                }
                var entityIndexBits = BitMath.CalcUsedBits((uint)ts._entityCount + 1u);
                if (p.UnpackByte(1) == 0)
                {
                    ts.Movement.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Movement.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Movement.SetAtIndex(i, id);
                        c.Movement = p.UnpackVector2();
                    }
                }
                if (p.UnpackByte(1) == 0)
                {
                    ts.Projectile.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Projectile.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Projectile.SetAtIndex(i, id);
                        c.Damage = p.UnpackFloat();
                        c.DestroyTick = p.UnpackSInt32();
                        c.Source = p.UnpackUInt32();
                        c.Speed = p.UnpackFloat();
                    }
                }
                if (p.UnpackByte(1) == 0)
                {
                    ts.RemoveEntityComponent.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.RemoveEntityComponent.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.RemoveEntityComponent.SetAtIndex(i, id);
                    }
                }
                if (p.UnpackByte(1) == 0)
                {
                    ts.Transform.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Transform.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Transform.SetAtIndex(i, id);
                        c.Forward = p.UnpackVector2();
                        c.Position = p.UnpackVector3();
                    }
                }
            }
            public void PackDiff(TableSet ts1, TableSet ts2, BitPacker p)
            {
                PackDiff(ts1, ts2, p, ref dummyStat);
            }
            public void PackDiff(TableSet ts1, TableSet ts2, BitPacker p, ref Stats stats)
            {
                p.PackUInt32(ts1.NextId);
                stats.Entities = -p.BitCount;
                _entityBits = BitMath.CalcUsedBits((uint)Math.Max(ts1._entityCount, ts2._entityCount) + 1u);
                p.PackByte((byte)_entityBits, 4);
                _delIndices.Clear();
                _addIds.Clear();
                int idx1 = 0, idx2 = 0;
                while (idx1 < ts1._entityCount && idx2 < ts2._entityCount)
                {
                    if (ts1._entityIds[idx1] == ts2._entityIds[idx2])
                    {
                        idx1++;
                        idx2++;
                    }
                    else if (ts1._entityIds[idx1] > ts2._entityIds[idx2])
                    {
                        _addIds.Add(ts2._entityIds[idx2]);
                        idx2++;
                    }
                    else
                    {
                        _delIndices.Add(idx1);
                        idx1++;
                    }
                }
                while (idx1 < ts1._entityCount)
                {
                    _delIndices.Add(idx1);
                    idx1++;
                }
                while (idx2 < ts2._entityCount)
                {
                    _addIds.Add(ts2._entityIds[idx2]);
                    idx2++;
                }
                p.PackUInt32((uint)_delIndices.Count, _entityBits);
                p.PackUInt32((uint)_addIds.Count, _entityBits);
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                uint prevId = 0;
                for (var i = 0; i < _addIds.Count; i++)
                {
                    var id = _addIds[i];
                    var dId = id - prevId;
                    if (dId < 16)
                    {
                        p.PackByte((byte)dId, 4);
                    }
                    else
                    {
                        p.PackByte(0, 4);
                        p.PackUInt32(id);
                    }
                    prevId = id;
                }
                stats.Entities += p.BitCount;
                stats.Movement = -p.BitCount;
                PackDiffMovement(ts1, ts2, p);
                stats.Movement += p.BitCount;
                stats.Projectile = -p.BitCount;
                PackDiffProjectile(ts1, ts2, p);
                stats.Projectile += p.BitCount;
                stats.RemoveEntityComponent = -p.BitCount;
                PackDiffRemoveEntityComponent(ts1, ts2, p);
                stats.RemoveEntityComponent += p.BitCount;
                stats.Transform = -p.BitCount;
                PackDiffTransform(ts1, ts2, p);
                stats.Transform += p.BitCount;
            }
            public void PersonalizedPackDiff(TableSet ts1, TableSet ts2, BitPacker p, uint clientId, ref Stats stats)
            {
                p.PackUInt32(ts1.NextId);
                stats.Entities = -p.BitCount;
                _entityBits = BitMath.CalcUsedBits((uint)Math.Max(ts1._entityCount, ts2._entityCount) + 1u);
                p.PackByte((byte)_entityBits, 4);
                _delIndices.Clear();
                _addIds.Clear();
                int idx1 = 0, idx2 = 0;
                while (idx1 < ts1._entityCount && idx2 < ts2._entityCount)
                {
                    if (ts1._entityIds[idx1] == ts2._entityIds[idx2])
                    {
                        idx1++;
                        idx2++;
                    }
                    else if (ts1._entityIds[idx1] > ts2._entityIds[idx2])
                    {
                        _addIds.Add(ts2._entityIds[idx2]);
                        idx2++;
                    }
                    else
                    {
                        _delIndices.Add(idx1);
                        idx1++;
                    }
                }
                while (idx1 < ts1._entityCount)
                {
                    _delIndices.Add(idx1);
                    idx1++;
                }
                while (idx2 < ts2._entityCount)
                {
                    _addIds.Add(ts2._entityIds[idx2]);
                    idx2++;
                }
                p.PackUInt32((uint)_delIndices.Count, _entityBits);
                p.PackUInt32((uint)_addIds.Count, _entityBits);
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                uint prevId = 0;
                for (var i = 0; i < _addIds.Count; i++)
                {
                    var id = _addIds[i];
                    var dId = id - prevId;
                    if (dId < 16)
                    {
                        p.PackByte((byte)dId, 4);
                    }
                    else
                    {
                        p.PackByte(0, 4);
                        p.PackUInt32(id);
                    }
                    prevId = id;
                }
                stats.Entities += p.BitCount;
                stats.Movement = -p.BitCount;
                PackDiffMovement(ts1, ts2, p);
                stats.Movement += p.BitCount;
                stats.Projectile = -p.BitCount;
                PackDiffProjectile(ts1, ts2, p);
                stats.Projectile += p.BitCount;
                stats.RemoveEntityComponent = -p.BitCount;
                PackDiffRemoveEntityComponent(ts1, ts2, p);
                stats.RemoveEntityComponent += p.BitCount;
                stats.Transform = -p.BitCount;
                PackDiffTransform(ts1, ts2, p);
                stats.Transform += p.BitCount;
            }
            public void UnpackDiff(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                ts2.NextId = p.UnpackUInt32();
                _entityBits = (int)p.UnpackUInt32(4);
                _addIds.Clear();
                _delIndices.Clear();
                int delCount = (int)p.UnpackUInt32(_entityBits);
                int addCount = (int)p.UnpackUInt32(_entityBits);
                int ts2count = ts1._entityCount + addCount - delCount;
                for (int i = 0; i < delCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _delIndices.Add(idx);
                }
                uint prevId = 0;
                for (int i = 0; i < addCount; i++)
                {
                    var id = (uint)p.UnpackByte(4);
                    if (id > 0) id += prevId;
                    else id = p.UnpackUInt32();
                    _addIds.Add(id);
                    prevId = id;
                }
                ts2.DiscardAndResizeEntities(ts2count);
                int iadd = 0, idel = 0;
                int idx2 = 0;
                for (int idx1 = 0; idx1 < ts1._entityCount; idx1++)
                {
                    while (iadd < addCount && _addIds[iadd] < ts1._entityIds[idx1])
                    {
                        ts2._entityIds[idx2++] = _addIds[iadd++];
                    }
                    if (idel < delCount)
                    {
                        if (_delIndices[idel] == idx1)
                        {
                            idel++;
                            continue;
                        }
                    }
                    ts2._entityIds[idx2] = ts1._entityIds[idx1];
                    idx2++;
                }
                while (iadd < addCount)
                {
                    ts2._entityIds[idx2++] = _addIds[iadd++];
                }
                for (int i = 0; i < ts2._entityCount; i++) ts2._entityData[i].Id = ts2._entityIds[i];
                UnpackDiffMovement(ts1, ts2, p);
                UnpackDiffProjectile(ts1, ts2, p);
                UnpackDiffRemoveEntityComponent(ts1, ts2, p);
                UnpackDiffTransform(ts1, ts2, p);
            }
            private struct UpdatedIndex
            {
                public int Personal;
                public int Base;
                public int Current;
            }
            private struct AddedIndex
            {
                public uint Id;
                public int Current;
            }
            private struct DeletedIndex
            {
                public int Personal;
                public int Base;
            }
            private Stats dummyStat;
            private int _entityBits;
            private List<uint> _addIds = new List<uint>(12);
            private List<int> _delIndices = new List<int>(12);
            private List<int> _updIndices = new List<int>(12);
            private List<AddedIndex> _addPersonalIndices = new List<AddedIndex>(12);
            private List<DeletedIndex> _delPersonalIndices = new List<DeletedIndex>(12);
            private List<UpdatedIndex> _updPersonalIndices = new List<UpdatedIndex>(12);
            private void PackMovement(TableSet ts, MovementComponent c, BitPacker p)
            {
                p.PackVector2(c.Movement);
            }
            private void PackProjectile(TableSet ts, Projectile c, BitPacker p)
            {
                p.PackFloat(c.Damage);
                p.PackSInt32(c.DestroyTick);
                p.PackUInt32(c.Source);
                p.PackFloat(c.Speed);
            }
            private void PackTransform(TableSet ts, Transform c, BitPacker p)
            {
                p.PackVector2(c.Forward);
                p.PackVector3(c.Position);
            }
            private void PackDiffMovement(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Movement.Count;
                var count2 = ts2.Movement.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Movement.At(idx1);
                        var kv2 = ts2.Movement.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.Simulation.MovementComponent.DifferForPack(kv1.Value, kv2.Value))
                            {
                                _updIndices.Add(idx1);
                            }
                            idx1++; t1end = idx1 >= count1;
                            idx2++; t2end = idx2 >= count2;
                        }
                        else if (kv1.Key > kv2.Key)
                        {
                            _addIds.Add(kv2.Key);
                            idx2++; t2end = idx2 >= count2;
                        }
                        else
                        {
                            _delIndices.Add(idx1);
                            idx1++; t1end = idx1 >= count1;
                        }
                    }
                    while (!t1end)
                    {
                        _delIndices.Add(idx1);
                        idx1++; t1end = idx1 >= count1;
                    }
                    while (!t2end)
                    {
                        _addIds.Add(ts2.Movement.IdAt(idx2));
                        idx2++; t2end = idx2 >= count2;
                    }
                }
                if (_delIndices.Count + _addIds.Count + _updIndices.Count == 0)
                {
                    p.PackByte(0, 1);
                    return;
                }
                p.PackByte(1, 1);
                if (_delIndices.Count + _addIds.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    p.PackUInt32((uint)_delIndices.Count, _entityBits);
                    p.PackUInt32((uint)_addIds.Count, _entityBits);
                }
                p.PackUInt32((uint)_updIndices.Count, _entityBits);
                var ts2Count = ts2.Movement.Count;
                if (ts2Count == 0) return;
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                for (int i = 0; i < _addIds.Count; i++)
                {
                    p.PackUInt32((uint)ts2._entityIds.BinarySearch(ts2._entityCount, _addIds[i]), _entityBits);
                }
                for (int i = 0; i < _updIndices.Count; i++)
                {
                    p.PackUInt32((uint)_updIndices[i], _entityBits);
                }
                {
                    int iadd = 0, iupd = 0, idel = 0;
                    int idx1 = 0, idx2 = 0;
                    for (int i = 0; i < count1; i++)
                    {
                        var kv1 = ts1.Movement.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Movement.CmpAt(idx2);
                            PackMovement(ts2, cur, p);
                            idx2++;
                            iadd++;
                        }
                        if (idel < _delIndices.Count)
                        {
                            if (_delIndices[idel] == idx1)
                            {
                                idel++;
                                idx1++;
                                continue;
                            }
                        }
                        if (iupd < _updIndices.Count)
                        {
                            if (_updIndices[iupd] == idx1)
                            {
                                var cur = ts2.Movement.CmpAt(idx2);
                                PackMovement(ts2, cur, p);
                                idx2++;
                                iupd++;
                                idx1++;
                                continue;
                            }
                        }
                        idx2++;
                        idx1++;
                    }
                    while (iadd < _addIds.Count)
                    {
                        var cur = ts2.Movement.CmpAt(idx2);
                        PackMovement(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void PackDiffProjectile(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Projectile.Count;
                var count2 = ts2.Projectile.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Projectile.At(idx1);
                        var kv2 = ts2.Projectile.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.Simulation.Projectile.DifferForPack(kv1.Value, kv2.Value))
                            {
                                _updIndices.Add(idx1);
                            }
                            idx1++; t1end = idx1 >= count1;
                            idx2++; t2end = idx2 >= count2;
                        }
                        else if (kv1.Key > kv2.Key)
                        {
                            _addIds.Add(kv2.Key);
                            idx2++; t2end = idx2 >= count2;
                        }
                        else
                        {
                            _delIndices.Add(idx1);
                            idx1++; t1end = idx1 >= count1;
                        }
                    }
                    while (!t1end)
                    {
                        _delIndices.Add(idx1);
                        idx1++; t1end = idx1 >= count1;
                    }
                    while (!t2end)
                    {
                        _addIds.Add(ts2.Projectile.IdAt(idx2));
                        idx2++; t2end = idx2 >= count2;
                    }
                }
                if (_delIndices.Count + _addIds.Count + _updIndices.Count == 0)
                {
                    p.PackByte(0, 1);
                    return;
                }
                p.PackByte(1, 1);
                if (_delIndices.Count + _addIds.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    p.PackUInt32((uint)_delIndices.Count, _entityBits);
                    p.PackUInt32((uint)_addIds.Count, _entityBits);
                }
                p.PackUInt32((uint)_updIndices.Count, _entityBits);
                var ts2Count = ts2.Projectile.Count;
                if (ts2Count == 0) return;
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                for (int i = 0; i < _addIds.Count; i++)
                {
                    p.PackUInt32((uint)ts2._entityIds.BinarySearch(ts2._entityCount, _addIds[i]), _entityBits);
                }
                for (int i = 0; i < _updIndices.Count; i++)
                {
                    p.PackUInt32((uint)_updIndices[i], _entityBits);
                }
                {
                    int iadd = 0, iupd = 0, idel = 0;
                    int idx1 = 0, idx2 = 0;
                    for (int i = 0; i < count1; i++)
                    {
                        var kv1 = ts1.Projectile.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Projectile.CmpAt(idx2);
                            PackProjectile(ts2, cur, p);
                            idx2++;
                            iadd++;
                        }
                        if (idel < _delIndices.Count)
                        {
                            if (_delIndices[idel] == idx1)
                            {
                                idel++;
                                idx1++;
                                continue;
                            }
                        }
                        if (iupd < _updIndices.Count)
                        {
                            if (_updIndices[iupd] == idx1)
                            {
                                var cur = ts2.Projectile.CmpAt(idx2);
                                PackProjectile(ts2, cur, p);
                                idx2++;
                                iupd++;
                                idx1++;
                                continue;
                            }
                        }
                        idx2++;
                        idx1++;
                    }
                    while (iadd < _addIds.Count)
                    {
                        var cur = ts2.Projectile.CmpAt(idx2);
                        PackProjectile(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void PackDiffRemoveEntityComponent(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.RemoveEntityComponent.Count;
                var count2 = ts2.RemoveEntityComponent.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.RemoveEntityComponent.At(idx1);
                        var kv2 = ts2.RemoveEntityComponent.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            idx1++; t1end = idx1 >= count1;
                            idx2++; t2end = idx2 >= count2;
                        }
                        else if (kv1.Key > kv2.Key)
                        {
                            _addIds.Add(kv2.Key);
                            idx2++; t2end = idx2 >= count2;
                        }
                        else
                        {
                            _delIndices.Add(idx1);
                            idx1++; t1end = idx1 >= count1;
                        }
                    }
                    while (!t1end)
                    {
                        _delIndices.Add(idx1);
                        idx1++; t1end = idx1 >= count1;
                    }
                    while (!t2end)
                    {
                        _addIds.Add(ts2.RemoveEntityComponent.IdAt(idx2));
                        idx2++; t2end = idx2 >= count2;
                    }
                }
                if (_delIndices.Count + _addIds.Count == 0)
                {
                    p.PackByte(0, 1);
                    return;
                }
                p.PackByte(1, 1);
                p.PackUInt32((uint)_delIndices.Count, _entityBits);
                p.PackUInt32((uint)_addIds.Count, _entityBits);
                var ts2Count = ts2.RemoveEntityComponent.Count;
                if (ts2Count == 0) return;
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                for (int i = 0; i < _addIds.Count; i++)
                {
                    p.PackUInt32((uint)ts2._entityIds.BinarySearch(ts2._entityCount, _addIds[i]), _entityBits);
                }
            }
            private void PackDiffTransform(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Transform.Count;
                var count2 = ts2.Transform.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Transform.At(idx1);
                        var kv2 = ts2.Transform.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.Simulation.Transform.DifferForPack(kv1.Value, kv2.Value))
                            {
                                _updIndices.Add(idx1);
                            }
                            idx1++; t1end = idx1 >= count1;
                            idx2++; t2end = idx2 >= count2;
                        }
                        else if (kv1.Key > kv2.Key)
                        {
                            _addIds.Add(kv2.Key);
                            idx2++; t2end = idx2 >= count2;
                        }
                        else
                        {
                            _delIndices.Add(idx1);
                            idx1++; t1end = idx1 >= count1;
                        }
                    }
                    while (!t1end)
                    {
                        _delIndices.Add(idx1);
                        idx1++; t1end = idx1 >= count1;
                    }
                    while (!t2end)
                    {
                        _addIds.Add(ts2.Transform.IdAt(idx2));
                        idx2++; t2end = idx2 >= count2;
                    }
                }
                if (_delIndices.Count + _addIds.Count + _updIndices.Count == 0)
                {
                    p.PackByte(0, 1);
                    return;
                }
                p.PackByte(1, 1);
                if (_delIndices.Count + _addIds.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    p.PackUInt32((uint)_delIndices.Count, _entityBits);
                    p.PackUInt32((uint)_addIds.Count, _entityBits);
                }
                p.PackUInt32((uint)_updIndices.Count, _entityBits);
                var ts2Count = ts2.Transform.Count;
                if (ts2Count == 0) return;
                for (int i = 0; i < _delIndices.Count; i++)
                {
                    p.PackUInt32((uint)_delIndices[i], _entityBits);
                }
                for (int i = 0; i < _addIds.Count; i++)
                {
                    p.PackUInt32((uint)ts2._entityIds.BinarySearch(ts2._entityCount, _addIds[i]), _entityBits);
                }
                for (int i = 0; i < _updIndices.Count; i++)
                {
                    p.PackUInt32((uint)_updIndices[i], _entityBits);
                }
                {
                    int iadd = 0, iupd = 0, idel = 0;
                    int idx1 = 0, idx2 = 0;
                    for (int i = 0; i < count1; i++)
                    {
                        var kv1 = ts1.Transform.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Transform.CmpAt(idx2);
                            PackTransform(ts2, cur, p);
                            idx2++;
                            iadd++;
                        }
                        if (idel < _delIndices.Count)
                        {
                            if (_delIndices[idel] == idx1)
                            {
                                idel++;
                                idx1++;
                                continue;
                            }
                        }
                        if (iupd < _updIndices.Count)
                        {
                            if (_updIndices[iupd] == idx1)
                            {
                                var cur = ts2.Transform.CmpAt(idx2);
                                PackTransform(ts2, cur, p);
                                idx2++;
                                iupd++;
                                idx1++;
                                continue;
                            }
                        }
                        idx2++;
                        idx1++;
                    }
                    while (iadd < _addIds.Count)
                    {
                        var cur = ts2.Transform.CmpAt(idx2);
                        PackTransform(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void UnpackMovement(TableSet ts, MovementComponent c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Movement = p.UnpackVector2();
            }
            private void UnpackProjectile(TableSet ts, Projectile c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Damage = p.UnpackFloat();
                c.DestroyTick = p.UnpackSInt32();
                c.Source = p.UnpackUInt32();
                c.Speed = p.UnpackFloat();
            }
            private void UnpackTransform(TableSet ts, Transform c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Forward = p.UnpackVector2();
                c.Position = p.UnpackVector3();
            }
            private void UnpackDiffMovement(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyMovement(ts1);
                    return;
                }
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                int delCount = 0;
                int addCount = 0;
                if (p.UnpackByte(1) != 0)
                {
                    delCount = (int)p.UnpackUInt32(_entityBits);
                    addCount = (int)p.UnpackUInt32(_entityBits);
                }
                int updCount = (int)p.UnpackUInt32(_entityBits);
                int table2count = ts1.Movement.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Movement.Clear();
                    return;
                }
                for (int i = 0; i < delCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _delIndices.Add(idx);
                }
                for (int i = 0; i < addCount; i++)
                {
                    uint id = ts2._entityIds[p.UnpackUInt32(_entityBits)];
                    _addIds.Add(id);
                }
                for (int i = 0; i < updCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _updIndices.Add(idx);
                }
                ts2.Movement.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Movement.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Movement.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Movement.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackMovement(ts2, c, p);
                    }
                    if (idel < delCount)
                    {
                        if (_delIndices[idel] == idx1)
                        {
                            idel++;
                            idx1++;
                            continue;
                        }
                    }
                    if (iupd < updCount)
                    {
                        if (_updIndices[iupd] == idx1)
                        {
                            var c = ts2.Movement.SetAtIndex(idx2++, kv1.Key);
                            UnpackMovement(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Movement.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyMovement(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Movement.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackMovement(ts2, c, p);
                }
            }
            private void UnpackDiffProjectile(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyProjectile(ts1);
                    return;
                }
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                int delCount = 0;
                int addCount = 0;
                if (p.UnpackByte(1) != 0)
                {
                    delCount = (int)p.UnpackUInt32(_entityBits);
                    addCount = (int)p.UnpackUInt32(_entityBits);
                }
                int updCount = (int)p.UnpackUInt32(_entityBits);
                int table2count = ts1.Projectile.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Projectile.Clear();
                    return;
                }
                for (int i = 0; i < delCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _delIndices.Add(idx);
                }
                for (int i = 0; i < addCount; i++)
                {
                    uint id = ts2._entityIds[p.UnpackUInt32(_entityBits)];
                    _addIds.Add(id);
                }
                for (int i = 0; i < updCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _updIndices.Add(idx);
                }
                ts2.Projectile.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Projectile.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Projectile.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Projectile.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackProjectile(ts2, c, p);
                    }
                    if (idel < delCount)
                    {
                        if (_delIndices[idel] == idx1)
                        {
                            idel++;
                            idx1++;
                            continue;
                        }
                    }
                    if (iupd < updCount)
                    {
                        if (_updIndices[iupd] == idx1)
                        {
                            var c = ts2.Projectile.SetAtIndex(idx2++, kv1.Key);
                            UnpackProjectile(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Projectile.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyProjectile(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Projectile.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackProjectile(ts2, c, p);
                }
            }
            private void UnpackDiffRemoveEntityComponent(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyRemoveEntityComponent(ts1);
                    return;
                }
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                int delCount = 0;
                int addCount = 0;
                delCount = (int)p.UnpackUInt32(_entityBits);
                addCount = (int)p.UnpackUInt32(_entityBits);
                int table2count = ts1.RemoveEntityComponent.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.RemoveEntityComponent.Clear();
                    return;
                }
                for (int i = 0; i < delCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _delIndices.Add(idx);
                }
                for (int i = 0; i < addCount; i++)
                {
                    uint id = ts2._entityIds[p.UnpackUInt32(_entityBits)];
                    _addIds.Add(id);
                }
                ts2.RemoveEntityComponent.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.RemoveEntityComponent.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.RemoveEntityComponent.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.RemoveEntityComponent.SetAtIndex(idx2++, _addIds[iadd++]);
                    }
                    if (idel < delCount)
                    {
                        if (_delIndices[idel] == idx1)
                        {
                            idel++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.RemoveEntityComponent.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyRemoveEntityComponent(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.RemoveEntityComponent.SetAtIndex(idx2++, _addIds[iadd++]);
                }
            }
            private void UnpackDiffTransform(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyTransform(ts1);
                    return;
                }
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                int delCount = 0;
                int addCount = 0;
                if (p.UnpackByte(1) != 0)
                {
                    delCount = (int)p.UnpackUInt32(_entityBits);
                    addCount = (int)p.UnpackUInt32(_entityBits);
                }
                int updCount = (int)p.UnpackUInt32(_entityBits);
                int table2count = ts1.Transform.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Transform.Clear();
                    return;
                }
                for (int i = 0; i < delCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _delIndices.Add(idx);
                }
                for (int i = 0; i < addCount; i++)
                {
                    uint id = ts2._entityIds[p.UnpackUInt32(_entityBits)];
                    _addIds.Add(id);
                }
                for (int i = 0; i < updCount; i++)
                {
                    int idx = (int)p.UnpackUInt32(_entityBits);
                    _updIndices.Add(idx);
                }
                ts2.Transform.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Transform.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Transform.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Transform.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackTransform(ts2, c, p);
                    }
                    if (idel < delCount)
                    {
                        if (_delIndices[idel] == idx1)
                        {
                            idel++;
                            idx1++;
                            continue;
                        }
                    }
                    if (iupd < updCount)
                    {
                        if (_updIndices[iupd] == idx1)
                        {
                            var c = ts2.Transform.SetAtIndex(idx2++, kv1.Key);
                            UnpackTransform(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Transform.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyTransform(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Transform.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackTransform(ts2, c, p);
                }
            }
        }
        public uint NextId = 2;
        public Table<MovementComponent> Movement;
        public Table<Projectile> Projectile;
        public Table<RemoveEntityComponent> RemoveEntityComponent;
        public Table<Transform> Transform;
        public int EntityCount
        {
            get { return _entityCount; }
        }
        public TableSet(Pools pools)
        {
            _pools = pools;
            Movement = new Table<MovementComponent>(_pools.MovementComponent);
            Projectile = new Table<Projectile>(_pools.Projectile);
            RemoveEntityComponent = new Table<RemoveEntityComponent>(_pools.RemoveEntityComponent);
            Transform = new Table<Transform>(_pools.Transform);
        }
        public void CopyMovement(TableSet ts2)
        {
            Movement.CopyIds(ts2.Movement);
            var count = Movement.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyMovement(Movement.CmpAt(i), ts2.Movement.CmpAt(i));
            }
        }
        public void CopyProjectile(TableSet ts2)
        {
            Projectile.CopyIds(ts2.Projectile);
            var count = Projectile.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyProjectile(Projectile.CmpAt(i), ts2.Projectile.CmpAt(i));
            }
        }
        public void CopyRemoveEntityComponent(TableSet ts2)
        {
            RemoveEntityComponent.CopyIds(ts2.RemoveEntityComponent);
        }
        public void CopyTransform(TableSet ts2)
        {
            Transform.CopyIds(ts2.Transform);
            var count = Transform.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyTransform(Transform.CmpAt(i), ts2.Transform.CmpAt(i));
            }
        }
        public void Copy(TableSet ts2)
        {
            if( this == ts2 )
            {
                return;
            }
            NextId = ts2.NextId;
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            CopyMovement(ts2);
            CopyProjectile(ts2);
            CopyRemoveEntityComponent(ts2);
            CopyTransform(ts2);
        }
        public void MergeWithPredicted(TableSet ts2)
        {
            if( this == ts2 )
            {
                return;
            }
            NextId = ts2.NextId;
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            CopyMovement(ts2);
            CopyProjectile(ts2);
            CopyRemoveEntityComponent(ts2);
            CopyTransform(ts2);
        }
        public void DeleteEmptyEntities()
        {
            if (_entityCount > _pools.EntityUseCount.Length) _pools.EntityUseCount = new uint[_entityCount + 64];
            else Array.Clear(_pools.EntityUseCount, 0, _entityCount);
            var count = _pools.EntityUseCount;
            var movementCount = Movement.Count;
            for (int i = 0; i < movementCount; i++)
            {
                var id = Movement.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var projectileCount = Projectile.Count;
            for (int i = 0; i < projectileCount; i++)
            {
                var id = Projectile.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var removeEntityComponentCount = RemoveEntityComponent.Count;
            for (int i = 0; i < removeEntityComponentCount; i++)
            {
                var id = RemoveEntityComponent.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var transformCount = Transform.Count;
            for (int i = 0; i < transformCount; i++)
            {
                var id = Transform.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var j = 0;
            for (var i = 0; i < _entityCount; i++)
            {
                if (count[i] == 0)
                {
                    _pools.Entity.Release(_entityData[i]);
                }
                else
                {
                    _entityIds[j] = _entityIds[i];
                    _entityData[j] = _entityData[i];
                    j++;
                }
            }
            _entityCount = j;
        }
        public void Clear()
        {
            Movement.Clear();
            Projectile.Clear();
            RemoveEntityComponent.Clear();
            Transform.Clear();
            for (var i = 0; i < _entityCount; i++)
            {
                _pools.Entity.Release(_entityData[i]);
            }
            _entityCount = 0;
        }
        public void CopyEntity(Entity source, Entity destination)
        {
            if(source.Movement != null)
            {
                var newComponent = destination.AddMovement();
                CopyMovement(newComponent, source.Movement);
            }
            else
            {
                destination.DelMovement();
            }
            if(source.Projectile != null)
            {
                var newComponent = destination.AddProjectile();
                CopyProjectile(newComponent, source.Projectile);
            }
            else
            {
                destination.DelProjectile();
            }
            if(source.RemoveEntityComponent != null)
            {
                var newComponent = destination.AddRemoveEntityComponent();
                CopyRemoveEntityComponent(newComponent, source.RemoveEntityComponent);
            }
            else
            {
                destination.DelRemoveEntityComponent();
            }
            if(source.Transform != null)
            {
                var newComponent = destination.AddTransform();
                CopyTransform(newComponent, source.Transform);
            }
            else
            {
                destination.DelTransform();
            }
        }
        public Entity this[uint id]
        {
            get
            {
                int idx = _entityIds.BinarySearch(_entityCount, id);
                if (idx < 0) return null;
                return _entityData[idx];
            }
        }
        public Entity CreateEntity()
        {
            return CreateEntity(NextId++);
        }
        public Entity CreateEntity(uint id)
        {
            int idx = _entityIds.BinarySearch(_entityCount, id);
            if (idx >= 0) return _entityData[idx];
            idx = ~idx;
            if (_entityCount == _entityIds.Length)
            {
                var oldids = _entityIds;
                var olddata = _entityData;
                _entityIds = new uint[_entityCount + 16];
                _entityData = new Entity[_entityCount + 16];
                Buffer.BlockCopy(oldids, 0, _entityIds, 0, idx * sizeof(uint));
                Buffer.BlockCopy(oldids, idx * sizeof(uint), _entityIds, (idx + 1) * sizeof(uint), (_entityCount - idx) * sizeof(uint));
                Array.Copy(olddata, _entityData, idx);
                Array.Copy(olddata, idx, _entityData, idx + 1, _entityCount - idx);
            }
            else
            {
                Buffer.BlockCopy(_entityIds, idx * sizeof(uint), _entityIds, (idx + 1) * sizeof(uint), (_entityCount - idx) * sizeof(uint));
                Array.Copy(_entityData, idx, _entityData, idx + 1, _entityCount - idx);
            }
            var entity = _pools.Entity.Get();
            entity.TableSet = this;
            entity.Id = id;
            _entityIds[idx] = id;
            _entityData[idx] = entity;
            _entityCount++;
            return entity;
        }
        public void RepackMovement()
        {
            var count = Movement.Count;
            for (int i = 0; i < count; ++i)
            {
                Movement.CmpAt(i).Repack();
            }
        }
        public void RepackProjectile()
        {
            var count = Projectile.Count;
            for (int i = 0; i < count; ++i)
            {
                Projectile.CmpAt(i).Repack();
            }
        }
        public void RepackRemoveEntityComponent()
        {
        }
        public void RepackTransform()
        {
            var count = Transform.Count;
            for (int i = 0; i < count; ++i)
            {
                Transform.CmpAt(i).Repack();
            }
        }
        public void Repack()
        {
            RepackMovement();
            RepackProjectile();
            RepackRemoveEntityComponent();
            RepackTransform();
        }
        public void InterpolateBase1(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts1._entityCount);
            for (var i = 0; i < ts1._entityCount; i++) _entityData[i].Id = ts1._entityIds[i];
            Buffer.BlockCopy(ts1._entityIds, 0, _entityIds, 0, ts1._entityCount * sizeof(uint));
            Movement.CopyIds(ts1.Movement);
            int movementCount = Movement.Count;
            for (int i = 0; i < movementCount; ++i)
            {
                var c = Movement.CmpAt(i);
                var c1 = ts1.Movement.CmpAt(i);
                c.Movement = c1.Movement;
            }
            Projectile.CopyIds(ts1.Projectile);
            int projectileCount = Projectile.Count;
            for (int i = 0; i < projectileCount; ++i)
            {
                var c = Projectile.CmpAt(i);
                var c1 = ts1.Projectile.CmpAt(i);
                c.Damage = c1.Damage;
                c.DestroyTick = c1.DestroyTick;
                c.Source = c1.Source;
                c.Speed = c1.Speed;
            }
            RemoveEntityComponent.CopyIds(ts1.RemoveEntityComponent);
            Transform.CopyIds(ts1.Transform);
            int transformCount = Transform.Count;
            for (int i = 0; i < transformCount; ++i)
            {
                var c = Transform.CmpAt(i);
                var c1 = ts1.Transform.CmpAt(i);
                var cId = Transform.IdAt(i);
                var c2 = ts2.Transform[cId];
                if (c2 != null) c.Forward = Vector2.LerpUnclamped(c1.Forward, c2.Forward, normalizedTime);
                else c.Forward = c1.Forward;
                if (c2 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c1.Position;
            }
        }
        public void InterpolateBase2(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            Movement.CopyIds(ts2.Movement);
            int movementCount = Movement.Count;
            for (int i = 0; i < movementCount; ++i)
            {
                var c = Movement.CmpAt(i);
                var c2 = ts2.Movement.CmpAt(i);
                c.Movement = c2.Movement;
            }
            Projectile.CopyIds(ts2.Projectile);
            int projectileCount = Projectile.Count;
            for (int i = 0; i < projectileCount; ++i)
            {
                var c = Projectile.CmpAt(i);
                var c2 = ts2.Projectile.CmpAt(i);
                c.Damage = c2.Damage;
                c.DestroyTick = c2.DestroyTick;
                c.Source = c2.Source;
                c.Speed = c2.Speed;
            }
            RemoveEntityComponent.CopyIds(ts2.RemoveEntityComponent);
            Transform.CopyIds(ts2.Transform);
            int transformCount = Transform.Count;
            for (int i = 0; i < transformCount; ++i)
            {
                var c = Transform.CmpAt(i);
                var c2 = ts2.Transform.CmpAt(i);
                var cId = Transform.IdAt(i);
                var c1 = ts1.Transform[cId];
                if (c1 != null) c.Forward = Vector2.LerpUnclamped(c1.Forward, c2.Forward, normalizedTime);
                else c.Forward = c2.Forward;
                if (c1 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c2.Position;
            }
        }
        public void Interpolate(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            if (normalizedTime < 1.0f)
            {
                InterpolateBase1(ts1, ts2, normalizedTime);
            }
            else
            {
                InterpolateBase2(ts1, ts2, normalizedTime);
            }
        }
        private int _entityCount = 0;
        private uint[] _entityIds = new uint[2000];
        private Entity[] _entityData = new Entity[2000];
        private readonly Pools _pools;
        private const int EntityCountBits = 16;
        private void CopyMovement(MovementComponent c1, MovementComponent c2)
        {
            c1.Movement = c2.Movement;
        }
        private void CopyProjectile(Projectile c1, Projectile c2)
        {
            c1.Damage = c2.Damage;
            c1.DestroyTick = c2.DestroyTick;
            c1.Source = c2.Source;
            c1.Speed = c2.Speed;
        }
        private void CopyRemoveEntityComponent(RemoveEntityComponent c1, RemoveEntityComponent c2)
        {
        }
        private void CopyTransform(Transform c1, Transform c2)
        {
            c1.Forward = c2.Forward;
            c1.Position = c2.Position;
        }
        private void DiscardAndResizeEntities(int size)
        {
            if (size < _entityCount)
            {
                for (var i = size; i < _entityCount; i++) _pools.Entity.Release(_entityData[i]);
            }
            else
            {
                if (_entityIds.Length < size)
                {
                    var oldData = _entityData;
                    _entityIds = new uint[size];
                    _entityData = new Entity[size];
                    Array.Copy(oldData, _entityData, _entityCount);
                }
                for (var i = _entityCount; i < size; i++)
                {
                    _entityData[i] = _pools.Entity.Get();
                    _entityData[i].TableSet = this;
                }
            }
            _entityCount = size;
        }
    }
    public sealed class Entity
    {
        public uint Id;
        public TableSet TableSet;
        public MovementComponent Movement
        {
            get { return TableSet.Movement[Id]; }
        }
        public Projectile Projectile
        {
            get { return TableSet.Projectile[Id]; }
        }
        public RemoveEntityComponent RemoveEntityComponent
        {
            get { return TableSet.RemoveEntityComponent[Id]; }
        }
        public Transform Transform
        {
            get { return TableSet.Transform[Id]; }
        }
        public MovementComponent AddMovement()
        {
            return TableSet.Movement.Insert(Id);
        }
        public void DelMovement()
        {
            TableSet.Movement.Delete(Id);
        }
        public Projectile AddProjectile()
        {
            return TableSet.Projectile.Insert(Id);
        }
        public void DelProjectile()
        {
            TableSet.Projectile.Delete(Id);
        }
        public RemoveEntityComponent AddRemoveEntityComponent()
        {
            return TableSet.RemoveEntityComponent.Insert(Id);
        }
        public void DelRemoveEntityComponent()
        {
            TableSet.RemoveEntityComponent.Delete(Id);
        }
        public Transform AddTransform()
        {
            return TableSet.Transform.Insert(Id);
        }
        public void DelTransform()
        {
            TableSet.Transform.Delete(Id);
        }
        public void DeleteAll()
        {
            DelMovement();
            DelProjectile();
            DelRemoveEntityComponent();
            DelTransform();
        }
    }
}
#endregion Generated Code
