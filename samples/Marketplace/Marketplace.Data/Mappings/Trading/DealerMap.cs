// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marketplace.Domain.Models.Trading;

namespace Marketplace.Data.Mappings.Trading
{
    internal sealed class DealerMap : EntityTypeConfiguration<Dealer>
    {
        public DealerMap()
        {
            ToTable("Dealers");

            #region Main

            HasKey(i => i.Id);

            Property(i => i.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(i => i.Active)
                .HasColumnName("Active");

            #endregion

            #region Fields

            Property(i => i.Name)
                .HasColumnName("Name");

            Property(i => i.PhoneNumber)
                .HasColumnName("PhoneNumber");

            Property(i => i.Address)
                .HasColumnName("Address");

            Property(i => i.City)
                .HasColumnName("City");

            Property(i => i.ZipCode)
                .HasColumnName("ZipCode");

            Property(i => i.ProvinceId)
                .HasColumnName("ProvinceId");

            Property(i => i.CountryId)
                .HasColumnName("CountryId");

            Property(i => i.UserId)
                .HasColumnName("UserId");

            #endregion

            #region Relationships

            HasRequired(i => i.Province)
                .WithMany()
                .HasForeignKey(c => c.ProvinceId);

            HasRequired(i => i.Country)
                .WithMany()
                .HasForeignKey(c => c.CountryId);

            HasRequired(i => i.User)
                .WithMany()
                .HasForeignKey(c => c.UserId);

            #endregion
        }
    }
}
