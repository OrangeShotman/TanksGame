// THIS IS A GENERATED FILE, DO NOT EDIT
// any changes you make here will be overwritten with no mercy
#pragma warning disable 0168

#region Generated Code
using System;
using System.Collections.Generic;
using OrangeShotStudio.Packer;
using UnityEngine;

namespace Common.World
{
    // DO NOT EDIT - generated from Generator/EC/World/Avatar.cs
    public sealed class Avatar : IComponent
    {
        public int OwnerUserId;
        public void Reset()
        {
            OwnerUserId = default(int);
        }
        public static bool DifferForPack(Avatar c1, Avatar c2)
        {
            bool null1, null2;
            if (c1.OwnerUserId != c2.OwnerUserId) return true;
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
            return obj is Avatar && (Avatar) obj == this;
        }
        public static void CopyAvatar(TableSet from, TableSet to, uint id)
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
            var fromAvatar2 = fromEntity.Avatar;
            if (fromAvatar2 == null)
            {
                to[id].DelAvatar();
                return;
            }
            var toAvatar1 = toEntity.Avatar;
            if (toAvatar1 == null)
            {
                toAvatar1 = to[id].AddAvatar();
            }
            toAvatar1.OwnerUserId = fromAvatar2.OwnerUserId;
        }
        public static void CopyAvatarPassive(TableSet from, TableSet to, uint id)
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
            var fromAvatar2 = fromEntity.Avatar;
            if (fromAvatar2 == null)
            {
                return;
            }
            var toAvatar1 = toEntity.Avatar;
            if (toAvatar1 == null)
            {
                return;
            }
            toAvatar1.OwnerUserId = fromAvatar2.OwnerUserId;
        }
        public static bool operator ==(Avatar a, Avatar b)
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
            if (a.OwnerUserId != b.OwnerUserId)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Avatar a, Avatar b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/Player.cs
    public sealed class Player : IComponent
    {
        public bool InputIsAcknowledged;
        public int UserId;
        public void Reset()
        {
            InputIsAcknowledged = default(bool);
            UserId = default(int);
        }
        public static bool DifferForPack(Player c1, Player c2)
        {
            bool null1, null2;
            if (c1.InputIsAcknowledged != c2.InputIsAcknowledged) return true;
            if (c1.UserId != c2.UserId) return true;
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
            return obj is Player && (Player) obj == this;
        }
        public static void CopyPlayer(TableSet from, TableSet to, uint id)
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
            var fromPlayer2 = fromEntity.Player;
            if (fromPlayer2 == null)
            {
                to[id].DelPlayer();
                return;
            }
            var toPlayer1 = toEntity.Player;
            if (toPlayer1 == null)
            {
                toPlayer1 = to[id].AddPlayer();
            }
            toPlayer1.InputIsAcknowledged = fromPlayer2.InputIsAcknowledged;
            toPlayer1.UserId = fromPlayer2.UserId;
        }
        public static void CopyPlayerPassive(TableSet from, TableSet to, uint id)
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
            var fromPlayer2 = fromEntity.Player;
            if (fromPlayer2 == null)
            {
                return;
            }
            var toPlayer1 = toEntity.Player;
            if (toPlayer1 == null)
            {
                return;
            }
            toPlayer1.InputIsAcknowledged = fromPlayer2.InputIsAcknowledged;
            toPlayer1.UserId = fromPlayer2.UserId;
        }
        public static bool operator ==(Player a, Player b)
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
            if (a.InputIsAcknowledged != b.InputIsAcknowledged)
            {
                return false;
            }
            if (a.UserId != b.UserId)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Player a, Player b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/Transform.cs
    public sealed class Transform : IComponent
    {
        public Vector3 Position;
        public void Reset()
        {
            Position = default(Vector3);
        }
        public static bool DifferForPack(Transform c1, Transform c2)
        {
            bool null1, null2;
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
            public Pool<Avatar> Avatar = new Pool<Avatar>();
            public Pool<Player> Player = new Pool<Player>();
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
                public int Avatar;
                public int Player;
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
                stats.Avatar = -p.BitCount;
                if (ts.Avatar.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Avatar.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Avatar.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackSInt32(c.OwnerUserId);
                    }
                }
                stats.Avatar += p.BitCount;
                stats.Player = -p.BitCount;
                if (ts.Player.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Player.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Player.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackBool(c.InputIsAcknowledged);
                        p.PackSInt32(c.UserId);
                    }
                }
                stats.Player += p.BitCount;
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
                stats.Avatar = -p.BitCount;
                if (ts.Avatar.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Avatar.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Avatar.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackSInt32(c.OwnerUserId);
                    }
                }
                stats.Avatar += p.BitCount;
                stats.Player = -p.BitCount;
                if (ts.Player.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Player.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Player.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackBool(c.InputIsAcknowledged);
                        p.PackSInt32(c.UserId);
                    }
                }
                stats.Player += p.BitCount;
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
                    ts.Avatar.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Avatar.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Avatar.SetAtIndex(i, id);
                        c.OwnerUserId = p.UnpackSInt32();
                    }
                }
                if (p.UnpackByte(1) == 0)
                {
                    ts.Player.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Player.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Player.SetAtIndex(i, id);
                        c.InputIsAcknowledged = p.UnpackBool();
                        c.UserId = p.UnpackSInt32();
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
                        c.Position = p.UnpackVector3();
                    }
                }
                ts.TransformPredicted.Clear();
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
                stats.Avatar = -p.BitCount;
                PackDiffAvatar(ts1, ts2, p);
                stats.Avatar += p.BitCount;
                stats.Player = -p.BitCount;
                PackDiffPlayer(ts1, ts2, p);
                stats.Player += p.BitCount;
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
                stats.Avatar = -p.BitCount;
                PackDiffAvatar(ts1, ts2, p);
                stats.Avatar += p.BitCount;
                stats.Player = -p.BitCount;
                PackDiffPlayer(ts1, ts2, p);
                stats.Player += p.BitCount;
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
                UnpackDiffAvatar(ts1, ts2, p);
                UnpackDiffPlayer(ts1, ts2, p);
                UnpackDiffTransform(ts1, ts2, p);
                ts2.TransformPredicted.Clear();
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
            private void PackAvatar(TableSet ts, Avatar c, BitPacker p)
            {
                p.PackSInt32(c.OwnerUserId);
            }
            private void PackPlayer(TableSet ts, Player c, BitPacker p)
            {
                p.PackBool(c.InputIsAcknowledged);
                p.PackSInt32(c.UserId);
            }
            private void PackTransform(TableSet ts, Transform c, BitPacker p)
            {
                p.PackVector3(c.Position);
            }
            private void PackDiffAvatar(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Avatar.Count;
                var count2 = ts2.Avatar.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Avatar.At(idx1);
                        var kv2 = ts2.Avatar.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.Avatar.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.Avatar.IdAt(idx2));
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
                var ts2Count = ts2.Avatar.Count;
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
                        var kv1 = ts1.Avatar.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Avatar.CmpAt(idx2);
                            PackAvatar(ts2, cur, p);
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
                                var cur = ts2.Avatar.CmpAt(idx2);
                                PackAvatar(ts2, cur, p);
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
                        var cur = ts2.Avatar.CmpAt(idx2);
                        PackAvatar(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void PackDiffPlayer(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Player.Count;
                var count2 = ts2.Player.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Player.At(idx1);
                        var kv2 = ts2.Player.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.Player.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.Player.IdAt(idx2));
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
                var ts2Count = ts2.Player.Count;
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
                        var kv1 = ts1.Player.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Player.CmpAt(idx2);
                            PackPlayer(ts2, cur, p);
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
                                var cur = ts2.Player.CmpAt(idx2);
                                PackPlayer(ts2, cur, p);
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
                        var cur = ts2.Player.CmpAt(idx2);
                        PackPlayer(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
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
                            if (Common.World.Transform.DifferForPack(kv1.Value, kv2.Value))
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
            private void UnpackAvatar(TableSet ts, Avatar c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.OwnerUserId = p.UnpackSInt32();
            }
            private void UnpackPlayer(TableSet ts, Player c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.InputIsAcknowledged = p.UnpackBool();
                c.UserId = p.UnpackSInt32();
            }
            private void UnpackTransform(TableSet ts, Transform c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Position = p.UnpackVector3();
            }
            private void UnpackDiffAvatar(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyAvatar(ts1);
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
                int table2count = ts1.Avatar.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Avatar.Clear();
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
                ts2.Avatar.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Avatar.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Avatar.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Avatar.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackAvatar(ts2, c, p);
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
                            var c = ts2.Avatar.SetAtIndex(idx2++, kv1.Key);
                            UnpackAvatar(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Avatar.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyAvatar(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Avatar.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackAvatar(ts2, c, p);
                }
            }
            private void UnpackDiffPlayer(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyPlayer(ts1);
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
                int table2count = ts1.Player.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Player.Clear();
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
                ts2.Player.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Player.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Player.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Player.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackPlayer(ts2, c, p);
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
                            var c = ts2.Player.SetAtIndex(idx2++, kv1.Key);
                            UnpackPlayer(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Player.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyPlayer(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Player.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackPlayer(ts2, c, p);
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
        public Table<Avatar> Avatar;
        public Table<Player> Player;
        public Table<Transform> Transform;
        public Table<Transform> TransformPredicted;
        public int EntityCount
        {
            get { return _entityCount; }
        }
        public TableSet(Pools pools)
        {
            _pools = pools;
            Avatar = new Table<Avatar>(_pools.Avatar);
            Player = new Table<Player>(_pools.Player);
            Transform = new Table<Transform>(_pools.Transform);
            TransformPredicted = new Table<Transform>(_pools.Transform);
        }
        public void CopyTransformPredicted(Transform c1, Transform c2)
        {
            c1.Position = c2.Position;
        }
        public void CopyAvatar(TableSet ts2)
        {
            Avatar.CopyIds(ts2.Avatar);
            var count = Avatar.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyAvatar(Avatar.CmpAt(i), ts2.Avatar.CmpAt(i));
            }
        }
        public void CopyPlayer(TableSet ts2)
        {
            Player.CopyIds(ts2.Player);
            var count = Player.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyPlayer(Player.CmpAt(i), ts2.Player.CmpAt(i));
            }
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
        public void CopyTransformPredicted(TableSet ts2)
        {
            TransformPredicted.CopyIds(ts2.TransformPredicted);
            var count = TransformPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyTransformPredicted(TransformPredicted.CmpAt(i), ts2.TransformPredicted.CmpAt(i));
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
            CopyAvatar(ts2);
            CopyPlayer(ts2);
            CopyTransform(ts2);
            CopyTransformPredicted(ts2);
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
            CopyAvatar(ts2);
            CopyPlayer(ts2);
            CopyTransform(ts2);
            ApplyTransformPredicted();
        }
        public void DeleteEmptyEntities()
        {
            if (_entityCount > _pools.EntityUseCount.Length) _pools.EntityUseCount = new uint[_entityCount + 64];
            else Array.Clear(_pools.EntityUseCount, 0, _entityCount);
            var count = _pools.EntityUseCount;
            var avatarCount = Avatar.Count;
            for (int i = 0; i < avatarCount; i++)
            {
                var id = Avatar.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var playerCount = Player.Count;
            for (int i = 0; i < playerCount; i++)
            {
                var id = Player.IdAt(i);
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
            var transformPredictedCount = TransformPredicted.Count;
            for (int i = 0; i < transformPredictedCount; i++)
            {
                var id = TransformPredicted.IdAt(i);
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
            Avatar.Clear();
            Player.Clear();
            Transform.Clear();
            TransformPredicted.Clear();
            for (var i = 0; i < _entityCount; i++)
            {
                _pools.Entity.Release(_entityData[i]);
            }
            _entityCount = 0;
        }
        public void CopyEntity(Entity source, Entity destination)
        {
            if(source.Avatar != null)
            {
                var newComponent = destination.AddAvatar();
                CopyAvatar(newComponent, source.Avatar);
            }
            else
            {
                destination.DelAvatar();
            }
            if(source.Player != null)
            {
                var newComponent = destination.AddPlayer();
                CopyPlayer(newComponent, source.Player);
            }
            else
            {
                destination.DelPlayer();
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
            if(source.TransformPredicted != null)
            {
                var newComponent = destination.AddTransformPredicted();
                CopyTransformPredicted(newComponent, source.TransformPredicted);
            }
            else
            {
                destination.DelTransformPredicted();
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
        public void RepackAvatar()
        {
            var count = Avatar.Count;
            for (int i = 0; i < count; ++i)
            {
                Avatar.CmpAt(i).Repack();
            }
        }
        public void RepackPlayer()
        {
            var count = Player.Count;
            for (int i = 0; i < count; ++i)
            {
                Player.CmpAt(i).Repack();
            }
        }
        public void RepackTransform()
        {
            var count = Transform.Count;
            for (int i = 0; i < count; ++i)
            {
                Transform.CmpAt(i).Repack();
            }
        }
        public void RepackTransformPredicted()
        {
            var count = TransformPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                TransformPredicted.CmpAt(i).Repack();
            }
        }
        public void Repack()
        {
            RepackAvatar();
            RepackPlayer();
            RepackTransform();
        }
        public void InterpolateBase1(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts1._entityCount);
            for (var i = 0; i < ts1._entityCount; i++) _entityData[i].Id = ts1._entityIds[i];
            Buffer.BlockCopy(ts1._entityIds, 0, _entityIds, 0, ts1._entityCount * sizeof(uint));
            Avatar.CopyIds(ts1.Avatar);
            int avatarCount = Avatar.Count;
            for (int i = 0; i < avatarCount; ++i)
            {
                var c = Avatar.CmpAt(i);
                var c1 = ts1.Avatar.CmpAt(i);
                c.OwnerUserId = c1.OwnerUserId;
            }
            Player.CopyIds(ts1.Player);
            int playerCount = Player.Count;
            for (int i = 0; i < playerCount; ++i)
            {
                var c = Player.CmpAt(i);
                var c1 = ts1.Player.CmpAt(i);
                c.InputIsAcknowledged = c1.InputIsAcknowledged;
                c.UserId = c1.UserId;
            }
            Transform.CopyIds(ts1.Transform);
            int transformCount = Transform.Count;
            for (int i = 0; i < transformCount; ++i)
            {
                var c = Transform.CmpAt(i);
                var c1 = ts1.Transform.CmpAt(i);
                var cId = Transform.IdAt(i);
                var c2 = ts2.Transform[cId];
                if (c2 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c1.Position;
            }
            TransformPredicted.CopyIds(ts1.TransformPredicted);
            int transformPredictedCount = TransformPredicted.Count;
            for (int i = 0; i < transformPredictedCount; ++i)
            {
                var c = TransformPredicted.CmpAt(i);
                var c1 = ts1.TransformPredicted.CmpAt(i);
                var cId = TransformPredicted.IdAt(i);
                var c2 = ts2.TransformPredicted[cId];
                if (c2 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c1.Position;
            }
        }
        public void InterpolateBase2(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            Avatar.CopyIds(ts2.Avatar);
            int avatarCount = Avatar.Count;
            for (int i = 0; i < avatarCount; ++i)
            {
                var c = Avatar.CmpAt(i);
                var c2 = ts2.Avatar.CmpAt(i);
                c.OwnerUserId = c2.OwnerUserId;
            }
            Player.CopyIds(ts2.Player);
            int playerCount = Player.Count;
            for (int i = 0; i < playerCount; ++i)
            {
                var c = Player.CmpAt(i);
                var c2 = ts2.Player.CmpAt(i);
                c.InputIsAcknowledged = c2.InputIsAcknowledged;
                c.UserId = c2.UserId;
            }
            Transform.CopyIds(ts2.Transform);
            int transformCount = Transform.Count;
            for (int i = 0; i < transformCount; ++i)
            {
                var c = Transform.CmpAt(i);
                var c2 = ts2.Transform.CmpAt(i);
                var cId = Transform.IdAt(i);
                var c1 = ts1.Transform[cId];
                if (c1 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c2.Position;
            }
            TransformPredicted.CopyIds(ts2.TransformPredicted);
            int transformPredictedCount = TransformPredicted.Count;
            for (int i = 0; i < transformPredictedCount; ++i)
            {
                var c = TransformPredicted.CmpAt(i);
                var c2 = ts2.TransformPredicted.CmpAt(i);
                var cId = TransformPredicted.IdAt(i);
                var c1 = ts1.TransformPredicted[cId];
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
        private void CopyAvatar(Avatar c1, Avatar c2)
        {
            c1.OwnerUserId = c2.OwnerUserId;
        }
        private void CopyPlayer(Player c1, Player c2)
        {
            c1.InputIsAcknowledged = c2.InputIsAcknowledged;
            c1.UserId = c2.UserId;
        }
        private void CopyTransform(Transform c1, Transform c2)
        {
            c1.Position = c2.Position;
        }
        private void ApplyTransformPredicted()
        {
            var count = TransformPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                var id = TransformPredicted.IdAt(i);
                var dst = Transform[id];
                if (dst == null) continue;
                var src = TransformPredicted.CmpAt(i);
                CopyTransform(dst, src);
            }
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
        public Avatar Avatar
        {
            get { return TableSet.Avatar[Id]; }
        }
        public Player Player
        {
            get { return TableSet.Player[Id]; }
        }
        public Transform Transform
        {
            get { return TableSet.Transform[Id]; }
        }
        public Transform TransformPredicted
        {
            get { return TableSet.TransformPredicted[Id]; }
        }
        public Avatar AddAvatar()
        {
            return TableSet.Avatar.Insert(Id);
        }
        public void DelAvatar()
        {
            TableSet.Avatar.Delete(Id);
        }
        public Player AddPlayer()
        {
            return TableSet.Player.Insert(Id);
        }
        public void DelPlayer()
        {
            TableSet.Player.Delete(Id);
        }
        public Transform AddTransform()
        {
            return TableSet.Transform.Insert(Id);
        }
        public void DelTransform()
        {
            TableSet.Transform.Delete(Id);
        }
        public Transform AddTransformPredicted()
        {
            return TableSet.TransformPredicted.Insert(Id);
        }
        public void DelTransformPredicted()
        {
            TableSet.TransformPredicted.Delete(Id);
        }
        public void DeleteAll()
        {
            DelAvatar();
            DelPlayer();
            DelTransform();
            DelTransformPredicted();
        }
    }
}
#endregion Generated Code