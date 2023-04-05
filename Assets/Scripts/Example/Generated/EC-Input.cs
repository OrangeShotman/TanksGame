// THIS IS A GENERATED FILE, DO NOT EDIT
// any changes you make here will be overwritten with no mercy
#pragma warning disable 0168

#region Generated Code
using System;
using System.Collections.Generic;
using OrangeShotStudio.Packer;
using UnityEngine;

namespace Common.Input
{
    // DO NOT EDIT - generated from Generator/EC/Input/PlayerInput.cs
    public sealed class PlayerInput : IComponent
    {
        public Vector2 Movement;
        public bool Shot;
        public void Reset()
        {
            Movement = default(Vector2);
            Shot = default(bool);
        }
        public static bool DifferForPack(PlayerInput c1, PlayerInput c2)
        {
            bool null1, null2;
            if (c1.Movement.x != c2.Movement.x || c1.Movement.y != c2.Movement.y) return true;
            if (c1.Shot != c2.Shot) return true;
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
            return obj is PlayerInput && (PlayerInput) obj == this;
        }
        public static void CopyPlayerInput(TableSet from, TableSet to, uint id)
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
            var fromPlayerInput2 = fromEntity.PlayerInput;
            if (fromPlayerInput2 == null)
            {
                to[id].DelPlayerInput();
                return;
            }
            var toPlayerInput1 = toEntity.PlayerInput;
            if (toPlayerInput1 == null)
            {
                toPlayerInput1 = to[id].AddPlayerInput();
            }
            toPlayerInput1.Movement = fromPlayerInput2.Movement;
            toPlayerInput1.Shot = fromPlayerInput2.Shot;
        }
        public static void CopyPlayerInputPassive(TableSet from, TableSet to, uint id)
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
            var fromPlayerInput2 = fromEntity.PlayerInput;
            if (fromPlayerInput2 == null)
            {
                return;
            }
            var toPlayerInput1 = toEntity.PlayerInput;
            if (toPlayerInput1 == null)
            {
                return;
            }
            toPlayerInput1.Movement = fromPlayerInput2.Movement;
            toPlayerInput1.Shot = fromPlayerInput2.Shot;
        }
        public static bool operator ==(PlayerInput a, PlayerInput b)
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
            if (a.Shot != b.Shot)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(PlayerInput a, PlayerInput b)
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
            public Pool<PlayerInput> PlayerInput = new Pool<PlayerInput>();
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
                public int PlayerInput;
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
                stats.PlayerInput = -p.BitCount;
                if (ts.PlayerInput.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.PlayerInput.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.PlayerInput.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Movement);
                        p.PackBool(c.Shot);
                    }
                }
                stats.PlayerInput += p.BitCount;
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
                stats.PlayerInput = -p.BitCount;
                if (ts.PlayerInput.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.PlayerInput.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.PlayerInput.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector2(c.Movement);
                        p.PackBool(c.Shot);
                    }
                }
                stats.PlayerInput += p.BitCount;
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
                    ts.PlayerInput.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.PlayerInput.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.PlayerInput.SetAtIndex(i, id);
                        c.Movement = p.UnpackVector2();
                        c.Shot = p.UnpackBool();
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
                stats.PlayerInput = -p.BitCount;
                PackDiffPlayerInput(ts1, ts2, p);
                stats.PlayerInput += p.BitCount;
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
                stats.PlayerInput = -p.BitCount;
                PackDiffPlayerInput(ts1, ts2, p);
                stats.PlayerInput += p.BitCount;
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
                UnpackDiffPlayerInput(ts1, ts2, p);
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
            private void PackPlayerInput(TableSet ts, PlayerInput c, BitPacker p)
            {
                p.PackVector2(c.Movement);
                p.PackBool(c.Shot);
            }
            private void PackDiffPlayerInput(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.PlayerInput.Count;
                var count2 = ts2.PlayerInput.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.PlayerInput.At(idx1);
                        var kv2 = ts2.PlayerInput.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.Input.PlayerInput.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.PlayerInput.IdAt(idx2));
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
                var ts2Count = ts2.PlayerInput.Count;
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
                        var kv1 = ts1.PlayerInput.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.PlayerInput.CmpAt(idx2);
                            PackPlayerInput(ts2, cur, p);
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
                                var cur = ts2.PlayerInput.CmpAt(idx2);
                                PackPlayerInput(ts2, cur, p);
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
                        var cur = ts2.PlayerInput.CmpAt(idx2);
                        PackPlayerInput(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void UnpackPlayerInput(TableSet ts, PlayerInput c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Movement = p.UnpackVector2();
                c.Shot = p.UnpackBool();
            }
            private void UnpackDiffPlayerInput(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyPlayerInput(ts1);
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
                int table2count = ts1.PlayerInput.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.PlayerInput.Clear();
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
                ts2.PlayerInput.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.PlayerInput.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.PlayerInput.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.PlayerInput.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackPlayerInput(ts2, c, p);
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
                            var c = ts2.PlayerInput.SetAtIndex(idx2++, kv1.Key);
                            UnpackPlayerInput(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.PlayerInput.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyPlayerInput(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.PlayerInput.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackPlayerInput(ts2, c, p);
                }
            }
        }
        public uint NextId = 2;
        public Table<PlayerInput> PlayerInput;
        public int EntityCount
        {
            get { return _entityCount; }
        }
        public TableSet(Pools pools)
        {
            _pools = pools;
            PlayerInput = new Table<PlayerInput>(_pools.PlayerInput);
        }
        public void CopyPlayerInput(TableSet ts2)
        {
            PlayerInput.CopyIds(ts2.PlayerInput);
            var count = PlayerInput.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyPlayerInput(PlayerInput.CmpAt(i), ts2.PlayerInput.CmpAt(i));
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
            CopyPlayerInput(ts2);
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
            CopyPlayerInput(ts2);
        }
        public void DeleteEmptyEntities()
        {
            if (_entityCount > _pools.EntityUseCount.Length) _pools.EntityUseCount = new uint[_entityCount + 64];
            else Array.Clear(_pools.EntityUseCount, 0, _entityCount);
            var count = _pools.EntityUseCount;
            var playerInputCount = PlayerInput.Count;
            for (int i = 0; i < playerInputCount; i++)
            {
                var id = PlayerInput.IdAt(i);
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
            PlayerInput.Clear();
            for (var i = 0; i < _entityCount; i++)
            {
                _pools.Entity.Release(_entityData[i]);
            }
            _entityCount = 0;
        }
        public void CopyEntity(Entity source, Entity destination)
        {
            if(source.PlayerInput != null)
            {
                var newComponent = destination.AddPlayerInput();
                CopyPlayerInput(newComponent, source.PlayerInput);
            }
            else
            {
                destination.DelPlayerInput();
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
        public void RepackPlayerInput()
        {
            var count = PlayerInput.Count;
            for (int i = 0; i < count; ++i)
            {
                PlayerInput.CmpAt(i).Repack();
            }
        }
        public void Repack()
        {
            RepackPlayerInput();
        }
        public void InterpolateBase1(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts1._entityCount);
            for (var i = 0; i < ts1._entityCount; i++) _entityData[i].Id = ts1._entityIds[i];
            Buffer.BlockCopy(ts1._entityIds, 0, _entityIds, 0, ts1._entityCount * sizeof(uint));
            PlayerInput.CopyIds(ts1.PlayerInput);
            int playerInputCount = PlayerInput.Count;
            for (int i = 0; i < playerInputCount; ++i)
            {
                var c = PlayerInput.CmpAt(i);
                var c1 = ts1.PlayerInput.CmpAt(i);
                c.Movement = c1.Movement;
                c.Shot = c1.Shot;
            }
        }
        public void InterpolateBase2(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            PlayerInput.CopyIds(ts2.PlayerInput);
            int playerInputCount = PlayerInput.Count;
            for (int i = 0; i < playerInputCount; ++i)
            {
                var c = PlayerInput.CmpAt(i);
                var c2 = ts2.PlayerInput.CmpAt(i);
                c.Movement = c2.Movement;
                c.Shot = c2.Shot;
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
        private void CopyPlayerInput(PlayerInput c1, PlayerInput c2)
        {
            c1.Movement = c2.Movement;
            c1.Shot = c2.Shot;
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
        public PlayerInput PlayerInput
        {
            get { return TableSet.PlayerInput[Id]; }
        }
        public PlayerInput AddPlayerInput()
        {
            return TableSet.PlayerInput.Insert(Id);
        }
        public void DelPlayerInput()
        {
            TableSet.PlayerInput.Delete(Id);
        }
        public void DeleteAll()
        {
            DelPlayerInput();
        }
    }
}
#endregion Generated Code
