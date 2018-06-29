namespace SimpleUpload.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        public virtual DbSet<base1> base1 { get; set; }
        public virtual DbSet<cbd_detail> cbd_detail { get; set; }
        public virtual DbSet<cbd_tooling> cbd_tooling { get; set; }
        public virtual DbSet<cbd_UploadHP_Stat> cbd_UploadHP_Stat { get; set; }
        public virtual DbSet<comp_cnt> comp_cnt { get; set; }
        public virtual DbSet<manuf_excell_detail> manuf_excell_detail { get; set; }
        public virtual DbSet<cbd_maintain> cbd_maintain { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<base1>()
                .Property(e => e.factory)
                .IsUnicode(false);

            modelBuilder.Entity<base1>()
                .Property(e => e.cal_size)
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.kind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.part)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.partna)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.addition)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.supp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.material)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.mat_thickness)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.uom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.cif)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.mat_yield)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.mat_yield_eff)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.loss_perc)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.calc_size_perc)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.gross_yield)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.mat_fob_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.fob_bypair_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.inusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_detail>()
                .Property(e => e.upusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.bottomid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.upperid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.max_month)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.tool_kind)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.tool_number)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.tool_subnumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.moldtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.details)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.tool_create_seas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.stat_size_group)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.own_fact)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.mold_shop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.pr_byday)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.unit_price_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.qty)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.tot_mold_cost_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.amort_paid)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.comp_mm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.comp_bv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.da_cost_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.comment)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.inusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_tooling>()
                .Property(e => e.upusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_UploadHP_Stat>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_UploadHP_Stat>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_UploadHP_Stat>()
                .Property(e => e.up_hp_stat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.cp_lea)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.cp_nonlea)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.stitch_piec)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.st)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.second_ass)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.treatment)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.bottom_piec)
                .HasPrecision(10, 4);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.inusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<comp_cnt>()
                .Property(e => e.upusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.tech)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.descr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.levl)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.cost_bypairs_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.inusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<manuf_excell_detail>()
                .Property(e => e.upusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.art)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.pri_stage)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.pbtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.mwtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.sam_size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.cal_size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.upper_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.sockliner_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.insole_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.bottom_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.sundries_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.packaging_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.da_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.fob_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.labor_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.oh_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.surcharge)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.reduction_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.upperid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.bottomid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.vol_adj_usd)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.tier)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.labor_rate)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.labor_ratio)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.overhead_rate)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.overhead_ratio)
                .HasPrecision(12, 6);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.inusr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cbd_maintain>()
                .Property(e => e.upusr)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
