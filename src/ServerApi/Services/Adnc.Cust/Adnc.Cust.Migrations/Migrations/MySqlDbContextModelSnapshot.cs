﻿// <auto-generated />
using System;
using Adnc.Infra.Repository.EfCore.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Adnc.Cust.Migrations.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    partial class MySqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4 ");

            modelBuilder.Entity("Adnc.Cust.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1)
                        .HasComment("");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("account")
                        .HasComment("");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint")
                        .HasColumnName("createby")
                        .HasComment("创建人");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createtime")
                        .HasComment("创建时间/注册时间");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint")
                        .HasColumnName("modifyby")
                        .HasComment("最后更新人");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modifytime")
                        .HasComment("最后更新时间");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("nickname")
                        .HasComment("");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)")
                        .HasColumnName("password")
                        .HasComment("");

                    b.Property<string>("Realname")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("realname")
                        .HasComment("");

                    b.HasKey("Id")
                        .HasName("pk_customer");

                    b.ToTable("customer", (string)null);

                    b.HasComment("客户表");
                });

            modelBuilder.Entity("Adnc.Cust.Entities.CustomerFinance", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1)
                        .HasComment("");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("account")
                        .HasComment("");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("balance")
                        .HasComment("");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint")
                        .HasColumnName("createby")
                        .HasComment("创建人");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createtime")
                        .HasComment("创建时间/注册时间");

                    b.Property<long?>("ModifyBy")
                        .HasColumnType("bigint")
                        .HasColumnName("modifyby")
                        .HasComment("最后更新人");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modifytime")
                        .HasComment("最后更新时间");

                    b.Property<DateTime>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)")
                        .HasColumnName("rowversion")
                        .HasComment("");

                    b.HasKey("Id")
                        .HasName("pk_customerfinance");

                    b.ToTable("customerfinance", (string)null);

                    b.HasComment("客户财务表");
                });

            modelBuilder.Entity("Adnc.Cust.Entities.CustomerTransactionLog", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1)
                        .HasComment("");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("account")
                        .HasComment("");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("amount")
                        .HasComment("");

                    b.Property<decimal>("ChangedAmount")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("changedamount")
                        .HasComment("");

                    b.Property<decimal>("ChangingAmount")
                        .HasColumnType("decimal(18,4)")
                        .HasColumnName("changingamount")
                        .HasComment("");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint")
                        .HasColumnName("createby")
                        .HasComment("创建人");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createtime")
                        .HasComment("创建时间/注册时间");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint")
                        .HasColumnName("customerid")
                        .HasComment("");

                    b.Property<int>("ExchageStatus")
                        .HasColumnType("int")
                        .HasColumnName("exchagestatus")
                        .HasComment("");

                    b.Property<int>("ExchangeType")
                        .HasColumnType("int")
                        .HasColumnName("exchangetype")
                        .HasComment("");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("remark")
                        .HasComment("");

                    b.HasKey("Id")
                        .HasName("pk_customertransactionlog");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_customertransactionlog_customerid");

                    b.ToTable("customertransactionlog", (string)null);

                    b.HasComment("客户财务变动记录");
                });

            modelBuilder.Entity("Adnc.Shared.Repository.EfEntities.EventTracker", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasColumnOrder(1)
                        .HasComment("");

                    b.Property<long>("CreateBy")
                        .HasColumnType("bigint")
                        .HasColumnName("createby")
                        .HasComment("创建人");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("createtime")
                        .HasComment("创建时间/注册时间");

                    b.Property<long>("EventId")
                        .HasColumnType("bigint")
                        .HasColumnName("eventid")
                        .HasComment("");

                    b.Property<string>("TrackerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("trackername")
                        .HasComment("");

                    b.HasKey("Id")
                        .HasName("pk_eventtracker");

                    b.HasIndex(new[] { "EventId", "TrackerName" }, "uk_eventid_trackername")
                        .IsUnique()
                        .HasDatabaseName("ix_eventtracker_eventid_trackername");

                    b.ToTable("eventtracker", (string)null);

                    b.HasComment("事件跟踪/处理信息");
                });

            modelBuilder.Entity("Adnc.Cust.Entities.CustomerFinance", b =>
                {
                    b.HasOne("Adnc.Cust.Entities.Customer", "Customer")
                        .WithOne("FinanceInfo")
                        .HasForeignKey("Adnc.Cust.Entities.CustomerFinance", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customerfinance_customer_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Adnc.Cust.Entities.CustomerTransactionLog", b =>
                {
                    b.HasOne("Adnc.Cust.Entities.Customer", null)
                        .WithMany("TransactionLogs")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customertransactionlog_customer_customerid");
                });

            modelBuilder.Entity("Adnc.Cust.Entities.Customer", b =>
                {
                    b.Navigation("FinanceInfo")
                        .IsRequired();

                    b.Navigation("TransactionLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
