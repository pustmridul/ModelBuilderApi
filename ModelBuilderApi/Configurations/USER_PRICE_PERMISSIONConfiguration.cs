﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ModelBuilderApi.Entity;

namespace ModelBuilderApi.Configurations;

public class USER_PRICE_PERMISSIONConfiguration : IEntityTypeConfiguration<USER_PRICE_PERMISSION>
{
    public void Configure(EntityTypeBuilder<USER_PRICE_PERMISSION> builder)
    {
        builder.ToTable("USER_PRICE_PERMISSION");
        builder.HasNoKey();
    }
}
