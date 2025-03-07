using Supercell.Laser.Logic.Util;

namespace Supercell.Laser.Logic.Data
{
    public class SkillData : LogicData
    {
        public SkillData(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }
        public bool IsPositionalTargeted()
        {
            if (BehaviorType == "Charge") return GamePlayUtil.IsJumpCharge(ChargeType);
            if (Projectile == null) return false;
            ProjectileData projectileData = DataTables.GetProjectileByName(Projectile);
            return projectileData.TravelType == 6 || projectileData.Indirect;
        }
        public string Name { get; set; }

        public string BehaviorType { get; set; }

        public bool CanMoveAtSameTime { get; set; }

        public bool Targeted { get; set; }

        public bool CanAutoShoot { get; set; }

        public bool MovementBasedAutoshoot { get; set; }

        public int Cooldown { get; set; }

        public int ActiveTime { get; set; }

        public int CastingTime { get; set; }

        public int CastingRange { get; set; }

        public int RangeVisual { get; set; }

        public int RangeInputScale { get; set; }

        public int MaxCastingRange { get; set; }

        public bool AllowAimOutsideMap;

        public int ForceValidTile { get; set; }

        public int RechargeTime { get; set; }

        public int MaxCharge { get; set; }

        public int Damage { get; set; }

        public int PercentDamage { get; set; }

        public int MsBetweenAttacks { get; set; }

        public int Spread { get; set; }

        public int AttackPattern { get; set; }

        public int NumBulletsInOneAttack { get; set; }

        public bool TwoGuns { get; set; }

        public bool ExecuteFirstAttackImmediately { get; set; }

        public int ChargePushback { get; set; }

        public int ChargeSpeed { get; set; }

        public int ChargeType { get; set; }

        public int NumSpawns { get; set; }

        public int MaxSpawns { get; set; }

        public bool BreakInvisibilityOnAttack { get; set; }

        public int SeeInvisibilityDistance { get; set; }

        public bool AlwaysCastAtMaxRange { get; set; }

        public string Projectile { get; set; }

        public string SummonedCharacter { get; set; }

        public string AreaEffectObject { get; set; }

        public string AreaEffectObject2 { get; set; }

        public string SpawnedItem { get; set; }

        //public string IconSWF { get; set; }

        //public string IconExportName { get; set; }

        //public string LargeIconSWF { get; set; }

        //public string LargeIconExportName { get; set; }

        //public string ButtonSWF { get; set; }

        //public string ButtonExportName { get; set; }

        public string AttackEffect { get; set; }

        public string UseEffect { get; set; }

        public string EndEffect { get; set; }

        public string LoopEffect { get; set; }

        public string LoopEffect2 { get; set; }

        public string ChargeMoveSound { get; set; }

        public bool MultiShot { get; set; }

        public int SkillChangeType { get; set; }

        public string SecondarySkill { get; set; }

        public string SecondarySkill2 { get; set; }

        public string SecondarySkill3 { get; set; }

        public string SecondarySkill4 { get; set; }

        public bool ShowTimerBar { get; set; }

        public string SecondaryProjectile { get; set; }

        public int ChargedShotCount { get; set; }

        public int DamageModifier { get; set; }

        public bool HoldToShoot { get; set; }

    }
}
