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
        public bool Destroyed;
        public int OwnerUserId;
        public void Reset()
        {
            Destroyed = default(bool);
            OwnerUserId = default(int);
        }
        public static bool DifferForPack(Avatar c1, Avatar c2)
        {
            bool null1, null2;
            if (c1.Destroyed != c2.Destroyed) return true;
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
            toAvatar1.Destroyed = fromAvatar2.Destroyed;
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
            toAvatar1.Destroyed = fromAvatar2.Destroyed;
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
            if (a.Destroyed != b.Destroyed)
            {
                return false;
            }
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
    // DO NOT EDIT - generated from Generator/EC/World/AvatarRespawn.cs
    public sealed class AvatarRespawn : IComponent
    {
        public int RespawnTick;
        public void Reset()
        {
            RespawnTick = default(int);
        }
        public static bool DifferForPack(AvatarRespawn c1, AvatarRespawn c2)
        {
            bool null1, null2;
            if (c1.RespawnTick != c2.RespawnTick) return true;
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
            return obj is AvatarRespawn && (AvatarRespawn) obj == this;
        }
        public static void CopyAvatarRespawn(TableSet from, TableSet to, uint id)
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
            var fromAvatarRespawn2 = fromEntity.AvatarRespawn;
            if (fromAvatarRespawn2 == null)
            {
                to[id].DelAvatarRespawn();
                return;
            }
            var toAvatarRespawn1 = toEntity.AvatarRespawn;
            if (toAvatarRespawn1 == null)
            {
                toAvatarRespawn1 = to[id].AddAvatarRespawn();
            }
            toAvatarRespawn1.RespawnTick = fromAvatarRespawn2.RespawnTick;
        }
        public static void CopyAvatarRespawnPassive(TableSet from, TableSet to, uint id)
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
            var fromAvatarRespawn2 = fromEntity.AvatarRespawn;
            if (fromAvatarRespawn2 == null)
            {
                return;
            }
            var toAvatarRespawn1 = toEntity.AvatarRespawn;
            if (toAvatarRespawn1 == null)
            {
                return;
            }
            toAvatarRespawn1.RespawnTick = fromAvatarRespawn2.RespawnTick;
        }
        public static bool operator ==(AvatarRespawn a, AvatarRespawn b)
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
            if (a.RespawnTick != b.RespawnTick)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(AvatarRespawn a, AvatarRespawn b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/Damage.cs
    public sealed class Damage : IComponent
    {
        public float Value;
        public void Reset()
        {
            Value = default(float);
        }
        public static bool DifferForPack(Damage c1, Damage c2)
        {
            bool null1, null2;
            if (c1.Value != c2.Value) return true;
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
            return obj is Damage && (Damage) obj == this;
        }
        public static void CopyDamage(TableSet from, TableSet to, uint id)
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
            var fromDamage2 = fromEntity.Damage;
            if (fromDamage2 == null)
            {
                to[id].DelDamage();
                return;
            }
            var toDamage1 = toEntity.Damage;
            if (toDamage1 == null)
            {
                toDamage1 = to[id].AddDamage();
            }
            toDamage1.Value = fromDamage2.Value;
        }
        public static void CopyDamagePassive(TableSet from, TableSet to, uint id)
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
            var fromDamage2 = fromEntity.Damage;
            if (fromDamage2 == null)
            {
                return;
            }
            var toDamage1 = toEntity.Damage;
            if (toDamage1 == null)
            {
                return;
            }
            toDamage1.Value = fromDamage2.Value;
        }
        public static bool operator ==(Damage a, Damage b)
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
            if (Math.Abs(a.Value - b.Value) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Damage a, Damage b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/Gun.cs
    public sealed class Gun : IComponent
    {
        public int CooldownDuration;
        public int NextShotTick;
        public float PositionOffset;
        public int ShotCount;
        public int ShotTick;
        public bool Use;
        public void Reset()
        {
            CooldownDuration = default(int);
            NextShotTick = default(int);
            PositionOffset = default(float);
            ShotCount = default(int);
            ShotTick = default(int);
            Use = default(bool);
        }
        public static bool DifferForPack(Gun c1, Gun c2)
        {
            bool null1, null2;
            if (c1.CooldownDuration != c2.CooldownDuration) return true;
            if (c1.NextShotTick != c2.NextShotTick) return true;
            if (c1.PositionOffset != c2.PositionOffset) return true;
            if (c1.ShotCount != c2.ShotCount) return true;
            if (c1.ShotTick != c2.ShotTick) return true;
            if (c1.Use != c2.Use) return true;
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
            return obj is Gun && (Gun) obj == this;
        }
        public static void CopyGun(TableSet from, TableSet to, uint id)
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
            var fromGun2 = fromEntity.Gun;
            if (fromGun2 == null)
            {
                to[id].DelGun();
                return;
            }
            var toGun1 = toEntity.Gun;
            if (toGun1 == null)
            {
                toGun1 = to[id].AddGun();
            }
            toGun1.CooldownDuration = fromGun2.CooldownDuration;
            toGun1.NextShotTick = fromGun2.NextShotTick;
            toGun1.PositionOffset = fromGun2.PositionOffset;
            toGun1.ShotCount = fromGun2.ShotCount;
            toGun1.ShotTick = fromGun2.ShotTick;
            toGun1.Use = fromGun2.Use;
        }
        public static void CopyGunPassive(TableSet from, TableSet to, uint id)
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
            var fromGun2 = fromEntity.Gun;
            if (fromGun2 == null)
            {
                return;
            }
            var toGun1 = toEntity.Gun;
            if (toGun1 == null)
            {
                return;
            }
            toGun1.CooldownDuration = fromGun2.CooldownDuration;
            toGun1.NextShotTick = fromGun2.NextShotTick;
            toGun1.PositionOffset = fromGun2.PositionOffset;
            toGun1.ShotCount = fromGun2.ShotCount;
            toGun1.ShotTick = fromGun2.ShotTick;
            toGun1.Use = fromGun2.Use;
        }
        public static bool operator ==(Gun a, Gun b)
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
            if (a.CooldownDuration != b.CooldownDuration)
            {
                return false;
            }
            if (a.NextShotTick != b.NextShotTick)
            {
                return false;
            }
            if (Math.Abs(a.PositionOffset - b.PositionOffset) > 0.01f)
            {
                return false;
            }
            if (a.ShotCount != b.ShotCount)
            {
                return false;
            }
            if (a.ShotTick != b.ShotTick)
            {
                return false;
            }
            if (a.Use != b.Use)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Gun a, Gun b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/Health.cs
    public sealed class Health : IComponent
    {
        public float CurrentHealth;
        public float MaxHealth;
        public void Reset()
        {
            CurrentHealth = default(float);
            MaxHealth = default(float);
        }
        public static bool DifferForPack(Health c1, Health c2)
        {
            bool null1, null2;
            if (c1.CurrentHealth != c2.CurrentHealth) return true;
            if (c1.MaxHealth != c2.MaxHealth) return true;
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
            return obj is Health && (Health) obj == this;
        }
        public static void CopyHealth(TableSet from, TableSet to, uint id)
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
            var fromHealth2 = fromEntity.Health;
            if (fromHealth2 == null)
            {
                to[id].DelHealth();
                return;
            }
            var toHealth1 = toEntity.Health;
            if (toHealth1 == null)
            {
                toHealth1 = to[id].AddHealth();
            }
            toHealth1.CurrentHealth = fromHealth2.CurrentHealth;
            toHealth1.MaxHealth = fromHealth2.MaxHealth;
        }
        public static void CopyHealthPassive(TableSet from, TableSet to, uint id)
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
            var fromHealth2 = fromEntity.Health;
            if (fromHealth2 == null)
            {
                return;
            }
            var toHealth1 = toEntity.Health;
            if (toHealth1 == null)
            {
                return;
            }
            toHealth1.CurrentHealth = fromHealth2.CurrentHealth;
            toHealth1.MaxHealth = fromHealth2.MaxHealth;
        }
        public static bool operator ==(Health a, Health b)
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
            if (Math.Abs(a.CurrentHealth - b.CurrentHealth) > 0.01f)
            {
                return false;
            }
            if (Math.Abs(a.MaxHealth - b.MaxHealth) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Health a, Health b)
        {
            return !(a == b);
        }
    }
    // DO NOT EDIT - generated from Generator/EC/World/MovementComponent.cs
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
    // DO NOT EDIT - generated from Generator/EC/World/PhysicsObject.cs
    public sealed class PhysicsObject : IComponent
    {
        public PhysicsBodyType BodyType;
        public Vector3 Size;
        public void Reset()
        {
            BodyType = default(PhysicsBodyType);
            Size = default(Vector3);
        }
        public static bool DifferForPack(PhysicsObject c1, PhysicsObject c2)
        {
            bool null1, null2;
            if (c1.BodyType != c2.BodyType) return true;
            if (c1.Size.x != c2.Size.x || c1.Size.y != c2.Size.y || c1.Size.z != c2.Size.z) return true;
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
            return obj is PhysicsObject && (PhysicsObject) obj == this;
        }
        public static void CopyPhysicsObject(TableSet from, TableSet to, uint id)
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
            var fromPhysicsObject2 = fromEntity.PhysicsObject;
            if (fromPhysicsObject2 == null)
            {
                to[id].DelPhysicsObject();
                return;
            }
            var toPhysicsObject1 = toEntity.PhysicsObject;
            if (toPhysicsObject1 == null)
            {
                toPhysicsObject1 = to[id].AddPhysicsObject();
            }
            toPhysicsObject1.BodyType = fromPhysicsObject2.BodyType;
            toPhysicsObject1.Size = fromPhysicsObject2.Size;
        }
        public static void CopyPhysicsObjectPassive(TableSet from, TableSet to, uint id)
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
            var fromPhysicsObject2 = fromEntity.PhysicsObject;
            if (fromPhysicsObject2 == null)
            {
                return;
            }
            var toPhysicsObject1 = toEntity.PhysicsObject;
            if (toPhysicsObject1 == null)
            {
                return;
            }
            toPhysicsObject1.BodyType = fromPhysicsObject2.BodyType;
            toPhysicsObject1.Size = fromPhysicsObject2.Size;
        }
        public static bool operator ==(PhysicsObject a, PhysicsObject b)
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
            if (a.BodyType != b.BodyType)
            {
                return false;
            }
            if (Math.Abs(a.Size.x - b.Size.x) > 0.01f || Math.Abs(a.Size.y - b.Size.y) > 0.01f || Math.Abs(a.Size.z - b.Size.z) > 0.01f)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(PhysicsObject a, PhysicsObject b)
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
            public Pool<Avatar> Avatar = new Pool<Avatar>();
            public Pool<AvatarRespawn> AvatarRespawn = new Pool<AvatarRespawn>();
            public Pool<Damage> Damage = new Pool<Damage>();
            public Pool<Gun> Gun = new Pool<Gun>();
            public Pool<Health> Health = new Pool<Health>();
            public Pool<MovementComponent> MovementComponent = new Pool<MovementComponent>();
            public Pool<PhysicsObject> PhysicsObject = new Pool<PhysicsObject>();
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
                public int Gun;
                public int Health;
                public int PhysicsObject;
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
                        p.PackBool(c.Destroyed);
                        p.PackSInt32(c.OwnerUserId);
                    }
                }
                stats.Avatar += p.BitCount;
                stats.Gun = -p.BitCount;
                if (ts.Gun.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Gun.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Gun.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackSInt32(c.CooldownDuration);
                        p.PackSInt32(c.NextShotTick);
                        p.PackFloat(c.PositionOffset);
                        p.PackSInt32(c.ShotCount);
                        p.PackSInt32(c.ShotTick);
                        p.PackBool(c.Use);
                    }
                }
                stats.Gun += p.BitCount;
                stats.Health = -p.BitCount;
                if (ts.Health.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Health.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Health.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackFloat(c.CurrentHealth);
                        p.PackFloat(c.MaxHealth);
                    }
                }
                stats.Health += p.BitCount;
                stats.PhysicsObject = -p.BitCount;
                if (ts.PhysicsObject.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.PhysicsObject.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.PhysicsObject.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackUInt32((uint)c.BodyType, 1);
                        p.PackVector3(c.Size);
                    }
                }
                stats.PhysicsObject += p.BitCount;
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
                        p.PackBool(c.Destroyed);
                        p.PackSInt32(c.OwnerUserId);
                    }
                }
                stats.Avatar += p.BitCount;
                stats.Gun = -p.BitCount;
                if (ts.Gun.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Gun.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Gun.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackSInt32(c.CooldownDuration);
                        p.PackSInt32(c.NextShotTick);
                        p.PackFloat(c.PositionOffset);
                        p.PackSInt32(c.ShotCount);
                        p.PackSInt32(c.ShotTick);
                        p.PackBool(c.Use);
                    }
                }
                stats.Gun += p.BitCount;
                stats.Health = -p.BitCount;
                if (ts.Health.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.Health.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.Health.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackFloat(c.CurrentHealth);
                        p.PackFloat(c.MaxHealth);
                    }
                }
                stats.Health += p.BitCount;
                stats.PhysicsObject = -p.BitCount;
                if (ts.PhysicsObject.Count == 0)
                {
                    p.PackByte(0, 1);
                }
                else
                {
                    p.PackByte(1, 1);
                    var tableCount = ts.PhysicsObject.Count;
                    p.PackUInt32((uint)tableCount, entityIndexBits);
                    for (var i = 0; i < tableCount; i++)
                    {
                        var kv = ts.PhysicsObject.At(i);
                        p.PackUInt32((uint)ts._entityIds.BinarySearch(ts._entityCount, kv.Key), entityIndexBits);
                        var c = kv.Value;
                        p.PackUInt32((uint)c.BodyType, 1);
                        p.PackVector3(c.Size);
                    }
                }
                stats.PhysicsObject += p.BitCount;
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
                        c.Destroyed = p.UnpackBool();
                        c.OwnerUserId = p.UnpackSInt32();
                    }
                }
                ts.AvatarRespawn.Clear();
                ts.Damage.Clear();
                if (p.UnpackByte(1) == 0)
                {
                    ts.Gun.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Gun.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Gun.SetAtIndex(i, id);
                        c.CooldownDuration = p.UnpackSInt32();
                        c.NextShotTick = p.UnpackSInt32();
                        c.PositionOffset = p.UnpackFloat();
                        c.ShotCount = p.UnpackSInt32();
                        c.ShotTick = p.UnpackSInt32();
                        c.Use = p.UnpackBool();
                    }
                }
                ts.GunPredicted.Clear();
                if (p.UnpackByte(1) == 0)
                {
                    ts.Health.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.Health.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.Health.SetAtIndex(i, id);
                        c.CurrentHealth = p.UnpackFloat();
                        c.MaxHealth = p.UnpackFloat();
                    }
                }
                ts.Movement.Clear();
                if (p.UnpackByte(1) == 0)
                {
                    ts.PhysicsObject.Clear();
                }
                else
                {
                    count = (int)p.UnpackUInt32(entityIndexBits);
                    ts.PhysicsObject.DestructiveResize(count);
                    for (int i = 0; i < count; i++)
                    {
                        uint id = ts._entityIds[p.UnpackUInt32(entityIndexBits)];
                        int id2index;
                        bool isDefault;
                        var c = ts.PhysicsObject.SetAtIndex(i, id);
                        c.BodyType = (PhysicsBodyType)p.UnpackUInt32(1);
                        c.Size = p.UnpackVector3();
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
                        c.Forward = p.UnpackVector2();
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
                stats.Gun = -p.BitCount;
                PackDiffGun(ts1, ts2, p);
                stats.Gun += p.BitCount;
                stats.Health = -p.BitCount;
                PackDiffHealth(ts1, ts2, p);
                stats.Health += p.BitCount;
                stats.PhysicsObject = -p.BitCount;
                PackDiffPhysicsObject(ts1, ts2, p);
                stats.PhysicsObject += p.BitCount;
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
                stats.Gun = -p.BitCount;
                PackDiffGun(ts1, ts2, p);
                stats.Gun += p.BitCount;
                stats.Health = -p.BitCount;
                PackDiffHealth(ts1, ts2, p);
                stats.Health += p.BitCount;
                stats.PhysicsObject = -p.BitCount;
                PackDiffPhysicsObject(ts1, ts2, p);
                stats.PhysicsObject += p.BitCount;
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
                ts2.AvatarRespawn.Clear();
                ts2.Damage.Clear();
                UnpackDiffGun(ts1, ts2, p);
                ts2.GunPredicted.Clear();
                UnpackDiffHealth(ts1, ts2, p);
                ts2.Movement.Clear();
                UnpackDiffPhysicsObject(ts1, ts2, p);
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
                p.PackBool(c.Destroyed);
                p.PackSInt32(c.OwnerUserId);
            }
            private void PackGun(TableSet ts, Gun c, BitPacker p)
            {
                p.PackSInt32(c.CooldownDuration);
                p.PackSInt32(c.NextShotTick);
                p.PackFloat(c.PositionOffset);
                p.PackSInt32(c.ShotCount);
                p.PackSInt32(c.ShotTick);
                p.PackBool(c.Use);
            }
            private void PackHealth(TableSet ts, Health c, BitPacker p)
            {
                p.PackFloat(c.CurrentHealth);
                p.PackFloat(c.MaxHealth);
            }
            private void PackPhysicsObject(TableSet ts, PhysicsObject c, BitPacker p)
            {
                p.PackUInt32((uint)c.BodyType, 1);
                p.PackVector3(c.Size);
            }
            private void PackPlayer(TableSet ts, Player c, BitPacker p)
            {
                p.PackBool(c.InputIsAcknowledged);
                p.PackSInt32(c.UserId);
            }
            private void PackTransform(TableSet ts, Transform c, BitPacker p)
            {
                p.PackVector2(c.Forward);
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
            private void PackDiffGun(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Gun.Count;
                var count2 = ts2.Gun.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Gun.At(idx1);
                        var kv2 = ts2.Gun.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.Gun.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.Gun.IdAt(idx2));
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
                var ts2Count = ts2.Gun.Count;
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
                        var kv1 = ts1.Gun.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Gun.CmpAt(idx2);
                            PackGun(ts2, cur, p);
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
                                var cur = ts2.Gun.CmpAt(idx2);
                                PackGun(ts2, cur, p);
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
                        var cur = ts2.Gun.CmpAt(idx2);
                        PackGun(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void PackDiffHealth(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.Health.Count;
                var count2 = ts2.Health.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.Health.At(idx1);
                        var kv2 = ts2.Health.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.Health.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.Health.IdAt(idx2));
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
                var ts2Count = ts2.Health.Count;
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
                        var kv1 = ts1.Health.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.Health.CmpAt(idx2);
                            PackHealth(ts2, cur, p);
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
                                var cur = ts2.Health.CmpAt(idx2);
                                PackHealth(ts2, cur, p);
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
                        var cur = ts2.Health.CmpAt(idx2);
                        PackHealth(ts2, cur, p);
                        idx2++;
                        iadd++;
                    }
                }
            }
            private void PackDiffPhysicsObject(TableSet ts1, TableSet ts2, BitPacker p)
            {
                _addIds.Clear();
                _delIndices.Clear();
                _updIndices.Clear();
                var count1 = ts1.PhysicsObject.Count;
                var count2 = ts2.PhysicsObject.Count;
                {
                    var idx1 = 0;
                    var idx2 = 0;
                    var t1end = count1 == 0;
                    var t2end = count2 == 0;
                    while (!t1end && !t2end)
                    {
                        var kv1 = ts1.PhysicsObject.At(idx1);
                        var kv2 = ts2.PhysicsObject.At(idx2);
                        if (kv1.Key == kv2.Key)
                        {
                            if (Common.World.PhysicsObject.DifferForPack(kv1.Value, kv2.Value))
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
                        _addIds.Add(ts2.PhysicsObject.IdAt(idx2));
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
                var ts2Count = ts2.PhysicsObject.Count;
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
                        var kv1 = ts1.PhysicsObject.At(i);
                        while (iadd < _addIds.Count && _addIds[iadd] < kv1.Key)
                        {
                            var cur = ts2.PhysicsObject.CmpAt(idx2);
                            PackPhysicsObject(ts2, cur, p);
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
                                var cur = ts2.PhysicsObject.CmpAt(idx2);
                                PackPhysicsObject(ts2, cur, p);
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
                        var cur = ts2.PhysicsObject.CmpAt(idx2);
                        PackPhysicsObject(ts2, cur, p);
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
                c.Destroyed = p.UnpackBool();
                c.OwnerUserId = p.UnpackSInt32();
            }
            private void UnpackGun(TableSet ts, Gun c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.CooldownDuration = p.UnpackSInt32();
                c.NextShotTick = p.UnpackSInt32();
                c.PositionOffset = p.UnpackFloat();
                c.ShotCount = p.UnpackSInt32();
                c.ShotTick = p.UnpackSInt32();
                c.Use = p.UnpackBool();
            }
            private void UnpackHealth(TableSet ts, Health c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.CurrentHealth = p.UnpackFloat();
                c.MaxHealth = p.UnpackFloat();
            }
            private void UnpackPhysicsObject(TableSet ts, PhysicsObject c, BitUnpacker p)
            {
                int id2index;
                bool isDefault;
                c.BodyType = (PhysicsBodyType)p.UnpackUInt32(1);
                c.Size = p.UnpackVector3();
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
                c.Forward = p.UnpackVector2();
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
            private void UnpackDiffGun(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyGun(ts1);
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
                int table2count = ts1.Gun.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Gun.Clear();
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
                ts2.Gun.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Gun.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Gun.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Gun.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackGun(ts2, c, p);
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
                            var c = ts2.Gun.SetAtIndex(idx2++, kv1.Key);
                            UnpackGun(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Gun.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyGun(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Gun.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackGun(ts2, c, p);
                }
            }
            private void UnpackDiffHealth(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyHealth(ts1);
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
                int table2count = ts1.Health.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.Health.Clear();
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
                ts2.Health.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.Health.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.Health.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.Health.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackHealth(ts2, c, p);
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
                            var c = ts2.Health.SetAtIndex(idx2++, kv1.Key);
                            UnpackHealth(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.Health.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyHealth(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.Health.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackHealth(ts2, c, p);
                }
            }
            private void UnpackDiffPhysicsObject(TableSet ts1, TableSet ts2, BitUnpacker p)
            {
                if (p.UnpackByte(1) == 0)
                {
                    ts2.CopyPhysicsObject(ts1);
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
                int table2count = ts1.PhysicsObject.Count + addCount - delCount;
                if (table2count == 0)
                {
                    ts2.PhysicsObject.Clear();
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
                ts2.PhysicsObject.DestructiveResize(table2count);
                int iadd = 0, idel = 0, iupd = 0;
                int idx1 = 0, idx2 = 0;
                var count1 = ts1.PhysicsObject.Count;
                for (var i = 0; i < count1; i++)
                {
                    var kv1 = ts1.PhysicsObject.At(i);
                    while (iadd < addCount && _addIds[iadd] < kv1.Key)
                    {
                        var c = ts2.PhysicsObject.SetAtIndex(idx2++, _addIds[iadd++]);
                        UnpackPhysicsObject(ts2, c, p);
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
                            var c = ts2.PhysicsObject.SetAtIndex(idx2++, kv1.Key);
                            UnpackPhysicsObject(ts2, c, p);
                            iupd++;
                            idx1++;
                            continue;
                        }
                    }
                    {
                        var c = ts2.PhysicsObject.SetAtIndex(idx2++, kv1.Key);
                        ts2.CopyPhysicsObject(c, kv1.Value);
                    }
                    idx1++;
                }
                while (iadd < addCount)
                {
                    var c = ts2.PhysicsObject.SetAtIndex(idx2++, _addIds[iadd++]);
                    UnpackPhysicsObject(ts2, c, p);
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
        public Table<AvatarRespawn> AvatarRespawn;
        public Table<Damage> Damage;
        public Table<Gun> Gun;
        public Table<Gun> GunPredicted;
        public Table<Health> Health;
        public Table<MovementComponent> Movement;
        public Table<PhysicsObject> PhysicsObject;
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
            AvatarRespawn = new Table<AvatarRespawn>(_pools.AvatarRespawn);
            Damage = new Table<Damage>(_pools.Damage);
            Gun = new Table<Gun>(_pools.Gun);
            GunPredicted = new Table<Gun>(_pools.Gun);
            Health = new Table<Health>(_pools.Health);
            Movement = new Table<MovementComponent>(_pools.MovementComponent);
            PhysicsObject = new Table<PhysicsObject>(_pools.PhysicsObject);
            Player = new Table<Player>(_pools.Player);
            Transform = new Table<Transform>(_pools.Transform);
            TransformPredicted = new Table<Transform>(_pools.Transform);
        }
        public void CopyGunPredicted(Gun c1, Gun c2)
        {
            c1.CooldownDuration = c2.CooldownDuration;
            c1.NextShotTick = c2.NextShotTick;
            c1.PositionOffset = c2.PositionOffset;
            c1.ShotCount = c2.ShotCount;
            c1.ShotTick = c2.ShotTick;
            c1.Use = c2.Use;
        }
        public void CopyTransformPredicted(Transform c1, Transform c2)
        {
            c1.Forward = c2.Forward;
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
        public void CopyAvatarRespawn(TableSet ts2)
        {
            AvatarRespawn.CopyIds(ts2.AvatarRespawn);
            var count = AvatarRespawn.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyAvatarRespawn(AvatarRespawn.CmpAt(i), ts2.AvatarRespawn.CmpAt(i));
            }
        }
        public void CopyDamage(TableSet ts2)
        {
            Damage.CopyIds(ts2.Damage);
            var count = Damage.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyDamage(Damage.CmpAt(i), ts2.Damage.CmpAt(i));
            }
        }
        public void CopyGun(TableSet ts2)
        {
            Gun.CopyIds(ts2.Gun);
            var count = Gun.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyGun(Gun.CmpAt(i), ts2.Gun.CmpAt(i));
            }
        }
        public void CopyGunPredicted(TableSet ts2)
        {
            GunPredicted.CopyIds(ts2.GunPredicted);
            var count = GunPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyGunPredicted(GunPredicted.CmpAt(i), ts2.GunPredicted.CmpAt(i));
            }
        }
        public void CopyHealth(TableSet ts2)
        {
            Health.CopyIds(ts2.Health);
            var count = Health.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyHealth(Health.CmpAt(i), ts2.Health.CmpAt(i));
            }
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
        public void CopyPhysicsObject(TableSet ts2)
        {
            PhysicsObject.CopyIds(ts2.PhysicsObject);
            var count = PhysicsObject.Count;
            for (int i = 0; i < count; ++i)
            {
                CopyPhysicsObject(PhysicsObject.CmpAt(i), ts2.PhysicsObject.CmpAt(i));
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
            CopyAvatarRespawn(ts2);
            CopyDamage(ts2);
            CopyGun(ts2);
            CopyGunPredicted(ts2);
            CopyHealth(ts2);
            CopyMovement(ts2);
            CopyPhysicsObject(ts2);
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
            CopyAvatarRespawn(ts2);
            CopyDamage(ts2);
            CopyGun(ts2);
            ApplyGunPredicted();
            CopyHealth(ts2);
            CopyMovement(ts2);
            CopyPhysicsObject(ts2);
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
            var avatarRespawnCount = AvatarRespawn.Count;
            for (int i = 0; i < avatarRespawnCount; i++)
            {
                var id = AvatarRespawn.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var damageCount = Damage.Count;
            for (int i = 0; i < damageCount; i++)
            {
                var id = Damage.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var gunCount = Gun.Count;
            for (int i = 0; i < gunCount; i++)
            {
                var id = Gun.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var gunPredictedCount = GunPredicted.Count;
            for (int i = 0; i < gunPredictedCount; i++)
            {
                var id = GunPredicted.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var healthCount = Health.Count;
            for (int i = 0; i < healthCount; i++)
            {
                var id = Health.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var movementCount = Movement.Count;
            for (int i = 0; i < movementCount; i++)
            {
                var id = Movement.IdAt(i);
                var idx = _entityIds.BinarySearch(_entityCount, id);
                count[idx]++;
            }
            var physicsObjectCount = PhysicsObject.Count;
            for (int i = 0; i < physicsObjectCount; i++)
            {
                var id = PhysicsObject.IdAt(i);
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
            AvatarRespawn.Clear();
            Damage.Clear();
            Gun.Clear();
            GunPredicted.Clear();
            Health.Clear();
            Movement.Clear();
            PhysicsObject.Clear();
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
            if(source.AvatarRespawn != null)
            {
                var newComponent = destination.AddAvatarRespawn();
                CopyAvatarRespawn(newComponent, source.AvatarRespawn);
            }
            else
            {
                destination.DelAvatarRespawn();
            }
            if(source.Damage != null)
            {
                var newComponent = destination.AddDamage();
                CopyDamage(newComponent, source.Damage);
            }
            else
            {
                destination.DelDamage();
            }
            if(source.Gun != null)
            {
                var newComponent = destination.AddGun();
                CopyGun(newComponent, source.Gun);
            }
            else
            {
                destination.DelGun();
            }
            if(source.GunPredicted != null)
            {
                var newComponent = destination.AddGunPredicted();
                CopyGunPredicted(newComponent, source.GunPredicted);
            }
            else
            {
                destination.DelGunPredicted();
            }
            if(source.Health != null)
            {
                var newComponent = destination.AddHealth();
                CopyHealth(newComponent, source.Health);
            }
            else
            {
                destination.DelHealth();
            }
            if(source.Movement != null)
            {
                var newComponent = destination.AddMovement();
                CopyMovement(newComponent, source.Movement);
            }
            else
            {
                destination.DelMovement();
            }
            if(source.PhysicsObject != null)
            {
                var newComponent = destination.AddPhysicsObject();
                CopyPhysicsObject(newComponent, source.PhysicsObject);
            }
            else
            {
                destination.DelPhysicsObject();
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
        public void RepackAvatarRespawn()
        {
            var count = AvatarRespawn.Count;
            for (int i = 0; i < count; ++i)
            {
                AvatarRespawn.CmpAt(i).Repack();
            }
        }
        public void RepackDamage()
        {
            var count = Damage.Count;
            for (int i = 0; i < count; ++i)
            {
                Damage.CmpAt(i).Repack();
            }
        }
        public void RepackGun()
        {
            var count = Gun.Count;
            for (int i = 0; i < count; ++i)
            {
                Gun.CmpAt(i).Repack();
            }
        }
        public void RepackGunPredicted()
        {
            var count = GunPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                GunPredicted.CmpAt(i).Repack();
            }
        }
        public void RepackHealth()
        {
            var count = Health.Count;
            for (int i = 0; i < count; ++i)
            {
                Health.CmpAt(i).Repack();
            }
        }
        public void RepackMovement()
        {
            var count = Movement.Count;
            for (int i = 0; i < count; ++i)
            {
                Movement.CmpAt(i).Repack();
            }
        }
        public void RepackPhysicsObject()
        {
            var count = PhysicsObject.Count;
            for (int i = 0; i < count; ++i)
            {
                PhysicsObject.CmpAt(i).Repack();
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
            RepackGun();
            RepackHealth();
            RepackPhysicsObject();
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
                c.Destroyed = c1.Destroyed;
                c.OwnerUserId = c1.OwnerUserId;
            }
            AvatarRespawn.CopyIds(ts1.AvatarRespawn);
            int avatarRespawnCount = AvatarRespawn.Count;
            for (int i = 0; i < avatarRespawnCount; ++i)
            {
                var c = AvatarRespawn.CmpAt(i);
                var c1 = ts1.AvatarRespawn.CmpAt(i);
                c.RespawnTick = c1.RespawnTick;
            }
            Damage.CopyIds(ts1.Damage);
            int damageCount = Damage.Count;
            for (int i = 0; i < damageCount; ++i)
            {
                var c = Damage.CmpAt(i);
                var c1 = ts1.Damage.CmpAt(i);
                c.Value = c1.Value;
            }
            Gun.CopyIds(ts1.Gun);
            int gunCount = Gun.Count;
            for (int i = 0; i < gunCount; ++i)
            {
                var c = Gun.CmpAt(i);
                var c1 = ts1.Gun.CmpAt(i);
                c.CooldownDuration = c1.CooldownDuration;
                c.NextShotTick = c1.NextShotTick;
                c.PositionOffset = c1.PositionOffset;
                c.ShotCount = c1.ShotCount;
                c.ShotTick = c1.ShotTick;
                c.Use = c1.Use;
            }
            GunPredicted.CopyIds(ts1.GunPredicted);
            int gunPredictedCount = GunPredicted.Count;
            for (int i = 0; i < gunPredictedCount; ++i)
            {
                var c = GunPredicted.CmpAt(i);
                var c1 = ts1.GunPredicted.CmpAt(i);
                c.CooldownDuration = c1.CooldownDuration;
                c.NextShotTick = c1.NextShotTick;
                c.PositionOffset = c1.PositionOffset;
                c.ShotCount = c1.ShotCount;
                c.ShotTick = c1.ShotTick;
                c.Use = c1.Use;
            }
            Health.CopyIds(ts1.Health);
            int healthCount = Health.Count;
            for (int i = 0; i < healthCount; ++i)
            {
                var c = Health.CmpAt(i);
                var c1 = ts1.Health.CmpAt(i);
                c.CurrentHealth = c1.CurrentHealth;
                c.MaxHealth = c1.MaxHealth;
            }
            Movement.CopyIds(ts1.Movement);
            int movementCount = Movement.Count;
            for (int i = 0; i < movementCount; ++i)
            {
                var c = Movement.CmpAt(i);
                var c1 = ts1.Movement.CmpAt(i);
                c.Movement = c1.Movement;
            }
            PhysicsObject.CopyIds(ts1.PhysicsObject);
            int physicsObjectCount = PhysicsObject.Count;
            for (int i = 0; i < physicsObjectCount; ++i)
            {
                var c = PhysicsObject.CmpAt(i);
                var c1 = ts1.PhysicsObject.CmpAt(i);
                c.BodyType = c1.BodyType;
                c.Size = c1.Size;
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
                if (c2 != null) c.Forward = Vector2.LerpUnclamped(c1.Forward, c2.Forward, normalizedTime);
                else c.Forward = c1.Forward;
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
            Avatar.CopyIds(ts2.Avatar);
            int avatarCount = Avatar.Count;
            for (int i = 0; i < avatarCount; ++i)
            {
                var c = Avatar.CmpAt(i);
                var c2 = ts2.Avatar.CmpAt(i);
                c.Destroyed = c2.Destroyed;
                c.OwnerUserId = c2.OwnerUserId;
            }
            AvatarRespawn.CopyIds(ts2.AvatarRespawn);
            int avatarRespawnCount = AvatarRespawn.Count;
            for (int i = 0; i < avatarRespawnCount; ++i)
            {
                var c = AvatarRespawn.CmpAt(i);
                var c2 = ts2.AvatarRespawn.CmpAt(i);
                c.RespawnTick = c2.RespawnTick;
            }
            Damage.CopyIds(ts2.Damage);
            int damageCount = Damage.Count;
            for (int i = 0; i < damageCount; ++i)
            {
                var c = Damage.CmpAt(i);
                var c2 = ts2.Damage.CmpAt(i);
                c.Value = c2.Value;
            }
            Gun.CopyIds(ts2.Gun);
            int gunCount = Gun.Count;
            for (int i = 0; i < gunCount; ++i)
            {
                var c = Gun.CmpAt(i);
                var c2 = ts2.Gun.CmpAt(i);
                c.CooldownDuration = c2.CooldownDuration;
                c.NextShotTick = c2.NextShotTick;
                c.PositionOffset = c2.PositionOffset;
                c.ShotCount = c2.ShotCount;
                c.ShotTick = c2.ShotTick;
                c.Use = c2.Use;
            }
            GunPredicted.CopyIds(ts2.GunPredicted);
            int gunPredictedCount = GunPredicted.Count;
            for (int i = 0; i < gunPredictedCount; ++i)
            {
                var c = GunPredicted.CmpAt(i);
                var c2 = ts2.GunPredicted.CmpAt(i);
                c.CooldownDuration = c2.CooldownDuration;
                c.NextShotTick = c2.NextShotTick;
                c.PositionOffset = c2.PositionOffset;
                c.ShotCount = c2.ShotCount;
                c.ShotTick = c2.ShotTick;
                c.Use = c2.Use;
            }
            Health.CopyIds(ts2.Health);
            int healthCount = Health.Count;
            for (int i = 0; i < healthCount; ++i)
            {
                var c = Health.CmpAt(i);
                var c2 = ts2.Health.CmpAt(i);
                c.CurrentHealth = c2.CurrentHealth;
                c.MaxHealth = c2.MaxHealth;
            }
            Movement.CopyIds(ts2.Movement);
            int movementCount = Movement.Count;
            for (int i = 0; i < movementCount; ++i)
            {
                var c = Movement.CmpAt(i);
                var c2 = ts2.Movement.CmpAt(i);
                c.Movement = c2.Movement;
            }
            PhysicsObject.CopyIds(ts2.PhysicsObject);
            int physicsObjectCount = PhysicsObject.Count;
            for (int i = 0; i < physicsObjectCount; ++i)
            {
                var c = PhysicsObject.CmpAt(i);
                var c2 = ts2.PhysicsObject.CmpAt(i);
                c.BodyType = c2.BodyType;
                c.Size = c2.Size;
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
                if (c1 != null) c.Forward = Vector2.LerpUnclamped(c1.Forward, c2.Forward, normalizedTime);
                else c.Forward = c2.Forward;
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
        private void CopyAvatar(Avatar c1, Avatar c2)
        {
            c1.Destroyed = c2.Destroyed;
            c1.OwnerUserId = c2.OwnerUserId;
        }
        private void CopyAvatarRespawn(AvatarRespawn c1, AvatarRespawn c2)
        {
            c1.RespawnTick = c2.RespawnTick;
        }
        private void CopyDamage(Damage c1, Damage c2)
        {
            c1.Value = c2.Value;
        }
        private void CopyGun(Gun c1, Gun c2)
        {
            c1.CooldownDuration = c2.CooldownDuration;
            c1.NextShotTick = c2.NextShotTick;
            c1.PositionOffset = c2.PositionOffset;
            c1.ShotCount = c2.ShotCount;
            c1.ShotTick = c2.ShotTick;
            c1.Use = c2.Use;
        }
        private void CopyHealth(Health c1, Health c2)
        {
            c1.CurrentHealth = c2.CurrentHealth;
            c1.MaxHealth = c2.MaxHealth;
        }
        private void CopyMovement(MovementComponent c1, MovementComponent c2)
        {
            c1.Movement = c2.Movement;
        }
        private void CopyPhysicsObject(PhysicsObject c1, PhysicsObject c2)
        {
            c1.BodyType = c2.BodyType;
            c1.Size = c2.Size;
        }
        private void CopyPlayer(Player c1, Player c2)
        {
            c1.InputIsAcknowledged = c2.InputIsAcknowledged;
            c1.UserId = c2.UserId;
        }
        private void CopyTransform(Transform c1, Transform c2)
        {
            c1.Forward = c2.Forward;
            c1.Position = c2.Position;
        }
        private void ApplyGunPredicted()
        {
            var count = GunPredicted.Count;
            for (int i = 0; i < count; ++i)
            {
                var id = GunPredicted.IdAt(i);
                var dst = Gun[id];
                if (dst == null) continue;
                var src = GunPredicted.CmpAt(i);
                CopyGun(dst, src);
            }
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
        public AvatarRespawn AvatarRespawn
        {
            get { return TableSet.AvatarRespawn[Id]; }
        }
        public Damage Damage
        {
            get { return TableSet.Damage[Id]; }
        }
        public Gun Gun
        {
            get { return TableSet.Gun[Id]; }
        }
        public Gun GunPredicted
        {
            get { return TableSet.GunPredicted[Id]; }
        }
        public Health Health
        {
            get { return TableSet.Health[Id]; }
        }
        public MovementComponent Movement
        {
            get { return TableSet.Movement[Id]; }
        }
        public PhysicsObject PhysicsObject
        {
            get { return TableSet.PhysicsObject[Id]; }
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
        public AvatarRespawn AddAvatarRespawn()
        {
            return TableSet.AvatarRespawn.Insert(Id);
        }
        public void DelAvatarRespawn()
        {
            TableSet.AvatarRespawn.Delete(Id);
        }
        public Damage AddDamage()
        {
            return TableSet.Damage.Insert(Id);
        }
        public void DelDamage()
        {
            TableSet.Damage.Delete(Id);
        }
        public Gun AddGun()
        {
            return TableSet.Gun.Insert(Id);
        }
        public void DelGun()
        {
            TableSet.Gun.Delete(Id);
        }
        public Gun AddGunPredicted()
        {
            return TableSet.GunPredicted.Insert(Id);
        }
        public void DelGunPredicted()
        {
            TableSet.GunPredicted.Delete(Id);
        }
        public Health AddHealth()
        {
            return TableSet.Health.Insert(Id);
        }
        public void DelHealth()
        {
            TableSet.Health.Delete(Id);
        }
        public MovementComponent AddMovement()
        {
            return TableSet.Movement.Insert(Id);
        }
        public void DelMovement()
        {
            TableSet.Movement.Delete(Id);
        }
        public PhysicsObject AddPhysicsObject()
        {
            return TableSet.PhysicsObject.Insert(Id);
        }
        public void DelPhysicsObject()
        {
            TableSet.PhysicsObject.Delete(Id);
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
            DelAvatarRespawn();
            DelDamage();
            DelGun();
            DelGunPredicted();
            DelHealth();
            DelMovement();
            DelPhysicsObject();
            DelPlayer();
            DelTransform();
            DelTransformPredicted();
        }
    }
}
#endregion Generated Code
