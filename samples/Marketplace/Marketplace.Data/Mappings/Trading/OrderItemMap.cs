// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Marketplace.Domain.Models.Trading;

namespace Marketplace.Data.Mappings.Trading
{
    internal sealed class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("OrderItems");

            #region Main

            HasKey(i => i.Id);

            Property(i => i.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(i => i.Active)
                .HasColumnName("Active");

            #endregion

            #region Fields

            Property(i => i.Quantity)
                .HasColumnName("Quantity");

            Property(i => i.Amount)
                .HasColumnName("Amount");

            Property(i => i.OrderId)
                .HasColumnName("OrderId");

            Property(i => i.ProductId)
                .HasColumnName("ProductId");

            #endregion

            #region Relationships

            HasRequired(i => i.Order)
                .WithMany(m => m.Items)
                .HasForeignKey(c => c.OrderId);

            HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId);

            #endregion
        }
    }
}
