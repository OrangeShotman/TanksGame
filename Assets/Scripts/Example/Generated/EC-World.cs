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
    // DO NOT EDIT - generated from Generator/EC/World/TestObject.cs
    public sealed class TestObject : IComponent
    {
        public Vector3 Position;
        public void Reset()
        {
            Position = default(Vector3);
        }
        public static bool DifferForPack(TestObject c1, TestObject c2)
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
            return obj is TestObject && (TestObject) obj == this;
        }
        public static void CopyTestObject(TableSet from, TableSet to, uint id)
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
            var fromTestObject2 = fromEntity.TestObject;
            if (fromTestObject2 == null)
            {
                to[id].DelTestObject();
                return;
            }
            var toTestObject1 = toEntity.TestObject;
            if (toTestObject1 == null)
            {
                toTestObject1 = to[id].AddTestObject();
            }
            toTestObject1.Position = fromTestObject2.Position;
        }
        public static void CopyTestObjectPassive(TableSet from, TableSet to, uint id)
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
            var fromTestObject2 = fromEntity.TestObject;
            if (fromTestObject2 == null)
            {
                return;
            }
            var toTestObject1 = toEntity.TestObject;
            if (toTestObject1 == null)
            {
                return;
            }
            toTestObject1.Position = fromTestObject2.Position;
        }
        public static bool operator ==(TestObject a, TestObject b)
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
        public static bool operator !=(TestObject a, TestObject b)
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
            public Pool<Player> Player = new Pool<Player>();
            public Pool<TestObject> TestObject = new Pool<TestObject>();
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
                public int Player;
                public int TestObject;
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
                stats.TestObject = -p.BitCount;
                if (ts.TestObject.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.TestObject.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.TestObject.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector3(c.Position);
                    }
                }
                stats.TestObject += p.BitCount;
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
                stats.TestObject = -p.BitCount;
                if (ts.TestObject.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.TestObject.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.TestObject.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackVector3(c.Position);
                    }
                }
                stats.TestObject += p.BitCount;
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
                    ts.TestObject.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.TestObject.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.TestObject.SetAtIndex(i, id);
                        c.Position = p.UnpackVector3();
                    }
                }
                ts.TestObjectPredicted.Clear();
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
                stats.Player = -p.BitCount;
                PackDiffPlayer(ts1, ts2, p);
                stats.Player += p.BitCount;
                stats.TestObject = -p.BitCount;
                PackDiffTestObject(ts1, ts2, p);
                stats.TestObject += p.BitCount;
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
                stats.Player = -p.BitCount;
                PackDiffPlayer(ts1, ts2, p);
                stats.Player += p.BitCount;
                stats.TestObject = -p.BitCount;
                PackDiffTestObject(ts1, ts2, p);
                stats.TestObject += p.BitCount;
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
                UnpackDiffPlayer(ts1, ts2, p);
                UnpackDiffTestObject(ts1, ts2, p);
                ts2.TestObjectPredicted.Clear();
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
            private void PackPlayer(TableSet ts, Player c, BitPacker p)
            {
                p.PackBool(c.InputIsAcknowledged);
                p.PackSInt32(c.UserId);
            }
            private void PackTestObject(TableSet ts, TestObject c, BitPacker p)
            {
                p.PackVector3(c.Position);
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
            private void PackDiffTestObject(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.TestObject.Count;
                var count2 = ts2.TestObject.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.TestObject.At(idx1);
                        var kv2 = ts2.TestObject.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.TestObject.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.TestObject.IdAt(idx2));
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
                var ts2Count = ts2.TestObject.Count;
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
                        var kv1 = ts1.TestObject.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.TestObject.CmpAt(idx2);
                            PackTestObject(ts2, cur, p);
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
                                var cur = ts2.TestObject.CmpAt(idx2);
                                PackTestObject(ts2, cur, p);
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
                        var cur = ts2.TestObject.CmpAt(idx2);
                        PackTestObject(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void UnpackPlayer(TableSet ts, Player c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.InputIsAcknowledged = p.UnpackBool();
                c.UserId = p.UnpackSInt32();
            }
            private void UnpackTestObject(TableSet ts, TestObject c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.Position = p.UnpackVector3();
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
            private void UnpackDiffTestObject(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyTestObject(ts1);
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
                int table2count = ts1.TestObject.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.TestObject.Clear();
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
                ts2.TestObject.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.TestObject.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.TestObject.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.TestObject.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackTestObject(ts2, c, p);
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
                            var c = ts2.TestObject.SetAtIndex(idx2++, kv1.Key);
                            UnpackTestObject(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.TestObject.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyTestObject(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.TestObject.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackTestObject(ts2, c, p);
                }
            }
        }
        public uint NextId = 2;
        public Table<Player> Player;
        public Table<TestObject> TestObject;
        public Table<TestObject> TestObjectPredicted;
        public int EntityCount
        {
            get { return _entityCount; }
        }
        public TableSet(Pools pools)
        {
            _pools = pools;
            Player = new Table<Player>(_pools.Player);
            TestObject = new Table<TestObject>(_pools.TestObject);
            TestObjectPredicted = new Table<TestObject>(_pools.TestObject);
        }
        public void CopyTestObjectPredicted(TestObject c1, TestObject c2)
        {
            c1.Position = c2.Position;
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
        public void CopyTestObject(TableSet ts2)
        {
            TestObject.CopyIds(ts2.TestObject);
            var count = TestObject.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyTestObject(TestObject.CmpAt(i), ts2.TestObject.CmpAt(i));
            }
        }
        public void CopyTestObjectPredicted(TableSet ts2)
        {
            TestObjectPredicted.CopyIds(ts2.TestObjectPredicted);
            var count = TestObjectPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyTestObjectPredicted(TestObjectPredicted.CmpAt(i), ts2.TestObjectPredicted.CmpAt(i));
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
            CopyPlayer(ts2);
            CopyTestObject(ts2);
            CopyTestObjectPredicted(ts2);
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
            CopyPlayer(ts2);
            CopyTestObject(ts2);
            ApplyTestObjectPredicted();
        }
        public void DeleteEmptyEntities()
        {
            if (_entityCount > _pools.EntityUseCount.Length) _pools.EntityUseCount = new uint[_entityCount + 64];
            else Array.Clear(_pools.EntityUseCount, 0, _entityCount);
            var count = _pools.EntityUseCount;
            var playerCount = Player.Count;
            for (int i = 0; i < playerCount; i++)
            {
                var id = Player.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var testObjectCount = TestObject.Count;
            for (int i = 0; i < testObjectCount; i++)
            {
                var id = TestObject.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var testObjectPredictedCount = TestObjectPredicted.Count;
            for (int i = 0; i < testObjectPredictedCount; i++)
            {
                var id = TestObjectPredicted.IdAt(i);
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
            Player.Clear();
            TestObject.Clear();
            TestObjectPredicted.Clear();
            for (var i = 0; i < _entityCount; i++)
            {
                _pools.Entity.Release(_entityData[i]);
            }
            _entityCount = 0;
        }
        public void CopyEntity(Entity source, Entity destination)
        {
            if(source.Player != null)
            {
                var newComponent = destination.AddPlayer();
                CopyPlayer(newComponent, source.Player);
            }
            else
            {
                destination.DelPlayer();
            }
            if(source.TestObject != null)
            {
                var newComponent = destination.AddTestObject();
                CopyTestObject(newComponent, source.TestObject);
            }
            else
            {
                destination.DelTestObject();
            }
            if(source.TestObjectPredicted != null)
            {
                var newComponent = destination.AddTestObjectPredicted();
                CopyTestObjectPredicted(newComponent, source.TestObjectPredicted);
            }
            else
            {
                destination.DelTestObjectPredicted();
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
        public void RepackPlayer()
        {
            var count = Player.Count;
            for (int i = 0; i < count; ++i)
            {
                Player.CmpAt(i).Repack();
            }
        }
        public void RepackTestObject()
        {
            var count = TestObject.Count;
            for (int i = 0; i < count; ++i)
            {
                TestObject.CmpAt(i).Repack();
            }
        }
        public void RepackTestObjectPredicted()
        {
            var count = TestObjectPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                TestObjectPredicted.CmpAt(i).Repack();
            }
        }
        public void Repack()
        {
            RepackPlayer();
            RepackTestObject();
        }
        public void InterpolateBase1(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts1._entityCount);
            for (var i = 0; i < ts1._entityCount; i++) _entityData[i].Id = ts1._entityIds[i];
            Buffer.BlockCopy(ts1._entityIds, 0, _entityIds, 0, ts1._entityCount * sizeof(uint));
            Player.CopyIds(ts1.Player);
            int playerCount = Player.Count;
            for (int i = 0; i < playerCount; ++i)
            {
                var c = Player.CmpAt(i);
                var c1 = ts1.Player.CmpAt(i);
                c.InputIsAcknowledged = c1.InputIsAcknowledged;
                c.UserId = c1.UserId;
            }
            TestObject.CopyIds(ts1.TestObject);
            int testObjectCount = TestObject.Count;
            for (int i = 0; i < testObjectCount; ++i)
            {
                var c = TestObject.CmpAt(i);
                var c1 = ts1.TestObject.CmpAt(i);
                var cId = TestObject.IdAt(i);
                var c2 = ts2.TestObject[cId];
                if (c2 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c1.Position;
            }
            TestObjectPredicted.CopyIds(ts1.TestObjectPredicted);
            int testObjectPredictedCount = TestObjectPredicted.Count;
            for (int i = 0; i < testObjectPredictedCount; ++i)
            {
                var c = TestObjectPredicted.CmpAt(i);
                var c1 = ts1.TestObjectPredicted.CmpAt(i);
                var cId = TestObjectPredicted.IdAt(i);
                var c2 = ts2.TestObjectPredicted[cId];
                if (c2 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c1.Position;
            }
        }
        public void InterpolateBase2(TableSet ts1, TableSet ts2, float normalizedTime)
        {
            DiscardAndResizeEntities(ts2._entityCount);
            for (var i = 0; i < ts2._entityCount; i++) _entityData[i].Id = ts2._entityIds[i];
            Buffer.BlockCopy(ts2._entityIds, 0, _entityIds, 0, ts2._entityCount * sizeof(uint));
            Player.CopyIds(ts2.Player);
            int playerCount = Player.Count;
            for (int i = 0; i < playerCount; ++i)
            {
                var c = Player.CmpAt(i);
                var c2 = ts2.Player.CmpAt(i);
                c.InputIsAcknowledged = c2.InputIsAcknowledged;
                c.UserId = c2.UserId;
            }
            TestObject.CopyIds(ts2.TestObject);
            int testObjectCount = TestObject.Count;
            for (int i = 0; i < testObjectCount; ++i)
            {
                var c = TestObject.CmpAt(i);
                var c2 = ts2.TestObject.CmpAt(i);
                var cId = TestObject.IdAt(i);
                var c1 = ts1.TestObject[cId];
                if (c1 != null) c.Position = Vector3.LerpUnclamped(c1.Position, c2.Position, normalizedTime);
                else c.Position = c2.Position;
            }
            TestObjectPredicted.CopyIds(ts2.TestObjectPredicted);
            int testObjectPredictedCount = TestObjectPredicted.Count;
            for (int i = 0; i < testObjectPredictedCount; ++i)
            {
                var c = TestObjectPredicted.CmpAt(i);
                var c2 = ts2.TestObjectPredicted.CmpAt(i);
                var cId = TestObjectPredicted.IdAt(i);
                var c1 = ts1.TestObjectPredicted[cId];
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
        private void CopyPlayer(Player c1, Player c2)
        {
            c1.InputIsAcknowledged = c2.InputIsAcknowledged;
            c1.UserId = c2.UserId;
        }
        private void CopyTestObject(TestObject c1, TestObject c2)
        {
            c1.Position = c2.Position;
        }
        private void ApplyTestObjectPredicted()
        {
            var count = TestObjectPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                var id = TestObjectPredicted.IdAt(i);
                var dst = TestObject[id];
                if (dst == null) continue;
                var src = TestObjectPredicted.CmpAt(i);
                CopyTestObject(dst, src);
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
        public Player Player
        {
            get { return TableSet.Player[Id]; }
        }
        public TestObject TestObject
        {
            get { return TableSet.TestObject[Id]; }
        }
        public TestObject TestObjectPredicted
        {
            get { return TableSet.TestObjectPredicted[Id]; }
        }
        public Player AddPlayer()
        {
            return TableSet.Player.Insert(Id);
        }
        public void DelPlayer()
        {
            TableSet.Player.Delete(Id);
        }
        public TestObject AddTestObject()
        {
            return TableSet.TestObject.Insert(Id);
        }
        public void DelTestObject()
        {
            TableSet.TestObject.Delete(Id);
        }
        public TestObject AddTestObjectPredicted()
        {
            return TableSet.TestObjectPredicted.Insert(Id);
        }
        public void DelTestObjectPredicted()
        {
            TableSet.TestObjectPredicted.Delete(Id);
        }
        public void DeleteAll()
        {
            DelPlayer();
            DelTestObject();
            DelTestObjectPredicted();
        }
    }
}
#endregion Generated Code
