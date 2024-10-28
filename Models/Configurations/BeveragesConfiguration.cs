﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EdenWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EdenWebAPI.Models.Configurations
{
    public partial class BeveragesConfiguration : IEntityTypeConfiguration<Beverages>
    {
        public void Configure(EntityTypeBuilder<Beverages> entity)
        {
            entity.HasKey(e => e.DrinkId)
                .HasName("PK__Beverage__C094D3C8FD7C9826");

            entity.Property(e => e.DrinkId)
                .ValueGeneratedNever()
                .HasColumnName("DrinkID");

            entity.Property(e => e.Drink)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Price).HasColumnType("money");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Beverages> entity);
    }
}