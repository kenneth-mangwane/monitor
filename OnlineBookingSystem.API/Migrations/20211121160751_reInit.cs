using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations
{
    public partial class reInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) { }
        protected override void Down(MigrationBuilder migrationBuilder) { }


        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.EnsureSchema(
        //        name: "obs");

        //    migrationBuilder.CreateTable(
        //        name: "Addresses",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Addresses", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AdminOveridePins",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AdminPin = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AdminOveridePins", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ApartmentTypes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
        //            OracleTypeCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ApartmentTypes", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ApplicationConfigurations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ValidationExpression = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsPassword = table.Column<bool>(type: "bit", nullable: false),
        //            Group = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ApplicationConfigurations", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ApplicationStatusses",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ApplicationStatusses", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ArchiveBlacklist",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            IDPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsActive = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BlackListType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            User = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ArchiveBlacklist", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "aspnet_Roles",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            RoleName = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
        //            LoweredRoleName = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
        //            Description = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_aspnet_Roles", x => x.RoleId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "aspnet_Users",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            UserName = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
        //            LoweredUserName = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: false),
        //            MobileAlias = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: true),
        //            IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
        //            LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_aspnet_Users", x => x.UserId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditHeaders",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Action = table.Column<int>(type: "int", nullable: false),
        //            ActionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Entity = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ApplicationUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditHeaders", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BillingPeriods",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BillingPeriods", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Blacklist",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IDPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsActive = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BlackListType = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Blacklist", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BursarFeeType",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BursarFeeType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BursarPricing",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CityID = table.Column<int>(type: "int", nullable: false),
        //            BursarID = table.Column<int>(type: "int", nullable: false),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BursarPricing", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Bursars",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CelbuxEnabled = table.Column<bool>(type: "bit", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Bursars", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BursarValidationEntries",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IdPassport = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
        //            BursarId = table.Column<int>(type: "int", nullable: false),
        //            Year = table.Column<int>(type: "int", nullable: false),
        //            Sharing = table.Column<bool>(type: "bit", nullable: false),
        //            Validated = table.Column<bool>(type: "bit", nullable: false),
        //            Notes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            UserCreated = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
        //            Type = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BursarValidationEntries", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BursarValidations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarID = table.Column<int>(type: "int", nullable: false),
        //            Year = table.Column<int>(type: "int", nullable: false),
        //            Validated = table.Column<bool>(type: "bit", nullable: false),
        //            Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarName = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BursarValidations", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Cities",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ContactPersonInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Cities", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Countries",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            GeonameID = table.Column<int>(type: "int", nullable: true),
        //            CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Countries", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomMessageDataExtracts",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseNum = table.Column<int>(type: "int", nullable: false),
        //            LeaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OrganizationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BankAccountNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            M65Ref = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomMessageDataExtracts", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomSentMessages",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            CustomerID = table.Column<int>(type: "int", nullable: false),
        //            ReferenceID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Bursar = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomSentMessages", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DocumentTypes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DocumentTypes", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FrequencyCalculationRules",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false),
        //            DivideBy = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FrequencyCalculationRules", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FrequencyTypes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OracleFrequencyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FrequencyTypes", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "GraduationQuestions",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_GraduationQuestions", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "HeadLeases",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BursarCustomerId = table.Column<int>(type: "int", nullable: false),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            OracleLeaseId = table.Column<int>(type: "int", nullable: false),
        //            OracleLeaseNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            LeaseType = table.Column<int>(type: "int", nullable: false),
        //            LeaseCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_HeadLeases", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Institutions",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Institutions", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LeasesExports",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HousholdEarnings = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentHomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentWorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HerdFromWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarID = table.Column<int>(type: "int", nullable: true),
        //            AcceptedTermsAndContions = table.Column<bool>(type: "bit", nullable: false),
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FinalLease = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCancelled = table.Column<bool>(type: "bit", nullable: false),
        //            SMSConversationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseRefNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_LeasesExports", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LookupTypes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LookupTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_LookupTypes", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MailMessages",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            To = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            From = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            AdditionalData = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MailMessages", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MaintenanceMessagesViews",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            FromName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Problem = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ToEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CategoryID = table.Column<int>(type: "int", nullable: false),
        //            Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusID = table.Column<int>(type: "int", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MaintenanceMessagesViews", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Maps",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            MapImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MapURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Maps", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OracleErrorCodes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OracleErrorCodes", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Organizations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BankCustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Bank = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Organizations", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OtpSent",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            idNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            otpSent = table.Column<bool>(type: "bit", nullable: false),
        //            validUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            otpExpired = table.Column<bool>(type: "bit", nullable: false),
        //            dateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            successful = table.Column<bool>(type: "bit", nullable: false),
        //            active = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OtpSent", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PendingBiometrics",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
        //            LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
        //            IdPassport = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
        //            AccountNumber = table.Column<int>(type: "int", nullable: false),
        //            LeaseId = table.Column<int>(type: "int", nullable: false),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            TryCount = table.Column<int>(type: "int", nullable: false),
        //            AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            BuildingId = table.Column<int>(type: "int", nullable: false),
        //            ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PendingBiometrics", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "QuoteAudits",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Bursar = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            Deposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            Registration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            FirstMonthRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            MonthlyRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_QuoteAudits", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ReasonsNotReturnings",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ReasonsNotReturnings", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RefundAttachmentType",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AttachmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RefundAttachmentType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RefundStatus",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RefundStatus", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialBursarCustomers",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BursarId = table.Column<int>(type: "int", nullable: false),
        //            BursarLeaseId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            IdPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialBursarCustomers", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RoomTypeDTO",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MaxOccupants = table.Column<int>(type: "int", nullable: false),
        //            MaxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            ReocuringCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            LeaseId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RoomVacationView",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IDNumberPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DueToVacateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReturningNextYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ReasonNotReturning = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserWantsDeposit = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            WasFoundBySearching = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            VacateBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountUpToDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InspectionScheduled = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RefundDue = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            KeyReturned = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsDuplicateBed = table.Column<bool>(type: "bit", nullable: true),
        //            IsDuplicateBedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Damages = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            LeaseBedBuildingID = table.Column<int>(type: "int", nullable: true),
        //            DateExported = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsDuplicateCustomer = table.Column<bool>(type: "bit", nullable: true),
        //            DamagesKeys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DamagesOther = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            TotalDamages = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RoomVacationView", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SbuxMerchant",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            MerchantID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ORG_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsActive = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SbuxMerchant", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SleepoverType",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsActive = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SleepoverType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "sysdiagrams",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            principal_id = table.Column<int>(type: "int", nullable: false),
        //            diagram_id = table.Column<int>(type: "int", nullable: false),
        //            version = table.Column<int>(type: "int", nullable: true),
        //            definition = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionType",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsActive = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "WifiPricings",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            PricingID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Price = table.Column<short>(type: "smallint", nullable: false),
        //            AllocationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            MonthlyDefault = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_WifiPricings", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Employers",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AddressId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Employers", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Employers_Addresses_AddressId",
        //                column: x => x.AddressId,
        //                principalSchema: "obs",
        //                principalTable: "Addresses",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "People",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AddressId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_People", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_People_Addresses_AddressId",
        //                column: x => x.AddressId,
        //                principalSchema: "obs",
        //                principalTable: "Addresses",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VacateInspectionLists",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
        //            ApartmentTypeId = table.Column<int>(type: "int", nullable: true),
        //            MinimumDamageCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            MaximumDamageCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            DamageCostPreFix = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
        //            DamageCostPostFix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
        //            DamageComment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VacateInspectionLists", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_VacateInspectionLists_ApartmentTypes_ApartmentTypeId",
        //                column: x => x.ApartmentTypeId,
        //                principalSchema: "obs",
        //                principalTable: "ApartmentTypes",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "aspnet_Membership",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            Password = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
        //            PasswordFormat = table.Column<int>(type: "int", nullable: false),
        //            PasswordSalt = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
        //            MobilePIN = table.Column<string>(type: "NVARCHAR(16)", maxLength: 16, nullable: true),
        //            Email = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: true),
        //            LoweredEmail = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: true),
        //            PasswordQuestion = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: true),
        //            PasswordAnswer = table.Column<string>(type: "NVARCHAR(256)", maxLength: 256, nullable: true),
        //            IsApproved = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
        //            CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            LastPasswordChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            LastLockoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            FailedPasswordAttemptCount = table.Column<int>(type: "int", nullable: false),
        //            FailedPasswordAttemptWindowStart = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            FailedPasswordAnswerAttemptCount = table.Column<int>(type: "int", nullable: false),
        //            FailedPasswordAnswerAttemptWindowStart = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Comment = table.Column<string>(type: "NVARCHAR", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_aspnet_Membership", x => x.UserId);
        //            table.ForeignKey(
        //                name: "FK_aspnet_Membership_aspnet_Users_UserId",
        //                column: x => x.UserId,
        //                principalSchema: "obs",
        //                principalTable: "aspnet_Users",
        //                principalColumn: "UserId",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "aspnet_Users_UserDetails",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            Firstname = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
        //            Lastname = table.Column<string>(type: "NVARCHAR(128)", maxLength: 128, nullable: false),
        //            Domain = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: true),
        //            MobileNumber = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_aspnet_Users_UserDetails", x => x.UserId);
        //            table.ForeignKey(
        //                name: "FK_aspnet_Users_UserDetails_aspnet_Users_UserId",
        //                column: x => x.UserId,
        //                principalSchema: "obs",
        //                principalTable: "aspnet_Users",
        //                principalColumn: "UserId",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "aspnet_UsersInRoles",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_aspnet_UsersInRoles", x => new { x.RoleId, x.UserId });
        //            table.ForeignKey(
        //                name: "FK_aspnet_UsersInRoles_aspnet_Roles_RoleId",
        //                column: x => x.RoleId,
        //                principalSchema: "obs",
        //                principalTable: "aspnet_Roles",
        //                principalColumn: "RoleId",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_aspnet_UsersInRoles_aspnet_Users_UserId",
        //                column: x => x.UserId,
        //                principalSchema: "obs",
        //                principalTable: "aspnet_Users",
        //                principalColumn: "UserId",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditeHeaderDetails",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AuditHeaderID = table.Column<long>(type: "bigint", nullable: false),
        //            Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            OldValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            NewValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditeHeaderDetails", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_AuditeHeaderDetails_AuditHeaders_AuditHeaderID",
        //                column: x => x.AuditHeaderID,
        //                principalSchema: "obs",
        //                principalTable: "AuditHeaders",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BursarPricingItem",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BursarPricingID = table.Column<int>(type: "int", nullable: false),
        //            FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BursarFeeTypeID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BursarPricingItem", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_BursarPricingItem_BursarFeeType_BursarFeeTypeID",
        //                column: x => x.BursarFeeTypeID,
        //                principalSchema: "obs",
        //                principalTable: "BursarFeeType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_BursarPricingItem_BursarPricing_BursarPricingID",
        //                column: x => x.BursarPricingID,
        //                principalSchema: "obs",
        //                principalTable: "BursarPricing",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Provinces",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            GeonameId = table.Column<int>(type: "int", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CountryID = table.Column<int>(type: "int", nullable: false),
        //            DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Provinces", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Provinces_Countries_CountryID",
        //                column: x => x.CountryID,
        //                principalSchema: "obs",
        //                principalTable: "Countries",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Documents",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ServerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Size = table.Column<long>(type: "bigint", nullable: false),
        //            DocumentTypeId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Documents", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Documents_DocumentTypes_DocumentTypeId",
        //                column: x => x.DocumentTypeId,
        //                principalSchema: "obs",
        //                principalTable: "DocumentTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FeeTypes",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FrequencyId = table.Column<int>(type: "int", nullable: false),
        //            Refundable = table.Column<bool>(type: "bit", nullable: false),
        //            VariableNoTenants = table.Column<bool>(type: "bit", nullable: false),
        //            BillingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FeeTypes", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_FeeTypes_FrequencyTypes_FrequencyId",
        //                column: x => x.FrequencyId,
        //                principalSchema: "obs",
        //                principalTable: "FrequencyTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CityInstitutions",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CityID = table.Column<int>(type: "int", nullable: false),
        //            Institution_ID = table.Column<int>(type: "int", nullable: false),
        //            InstitutionID = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CityInstitutions", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_CityInstitutions_Cities_CityID",
        //                column: x => x.CityID,
        //                principalSchema: "obs",
        //                principalTable: "Cities",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_CityInstitutions_Institutions_InstitutionID",
        //                column: x => x.InstitutionID,
        //                principalSchema: "obs",
        //                principalTable: "Institutions",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Lookups",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LookupTypeID = table.Column<int>(type: "int", nullable: false),
        //            LookupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Lookups", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Lookups_LookupTypes_LookupTypeID",
        //                column: x => x.LookupTypeID,
        //                principalSchema: "obs",
        //                principalTable: "LookupTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Buildings",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false),
        //            BuildingType = table.Column<int>(type: "int", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SpaceAvailable = table.Column<bool>(type: "bit", nullable: false),
        //            MapID = table.Column<int>(type: "int", nullable: false),
        //            CityID = table.Column<int>(type: "int", nullable: false),
        //            BuildingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OrganizationID = table.Column<int>(type: "int", nullable: false),
        //            MaintenanceEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InfoHTML = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Buildings", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Buildings_Cities_CityID",
        //                column: x => x.CityID,
        //                principalSchema: "obs",
        //                principalTable: "Cities",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Buildings_Maps_MapID",
        //                column: x => x.MapID,
        //                principalSchema: "obs",
        //                principalTable: "Maps",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Buildings_Organizations_OrganizationID",
        //                column: x => x.OrganizationID,
        //                principalSchema: "obs",
        //                principalTable: "Organizations",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RefundRequest",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RefundStatusID = table.Column<int>(type: "int", nullable: false),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Vacated = table.Column<bool>(type: "bit", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RefundRequest", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_RefundRequest_RefundStatus_RefundStatusID",
        //                column: x => x.RefundStatusID,
        //                principalSchema: "obs",
        //                principalTable: "RefundStatus",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Sleepover",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IDPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SleepoverTypeId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Sleepover", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Sleepover_SleepoverType_SleepoverTypeId",
        //                column: x => x.SleepoverTypeId,
        //                principalSchema: "obs",
        //                principalTable: "SleepoverType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Transaction",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            TID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Created = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            State = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TransactionTypeId = table.Column<int>(type: "int", nullable: false),
        //            SbuxMerchantId = table.Column<int>(type: "int", nullable: true),
        //            Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OracleAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MatchedRecon = table.Column<bool>(type: "bit", nullable: false),
        //            MatchedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MatchedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Transaction", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Transaction_SbuxMerchant_SbuxMerchantId",
        //                column: x => x.SbuxMerchantId,
        //                principalSchema: "obs",
        //                principalTable: "SbuxMerchant",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Transaction_TransactionType_TransactionTypeId",
        //                column: x => x.TransactionTypeId,
        //                principalSchema: "obs",
        //                principalTable: "TransactionType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "WifiAllocations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            PricingID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PersonIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RefAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UniquePin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DataAllocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Bed = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            CellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PartyID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateAllocated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateActivated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateNotified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateRedeemed = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            AllocationPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AllocatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SendCount = table.Column<int>(type: "int", nullable: false),
        //            WifiPricingID = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_WifiAllocations", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_WifiAllocations_WifiPricings_WifiPricingID",
        //                column: x => x.WifiPricingID,
        //                principalSchema: "obs",
        //                principalTable: "WifiPricings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "WifiBuildingPriceMaps",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BuildingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PricingID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            WifiPricingID = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_WifiBuildingPriceMaps", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_WifiBuildingPriceMaps_WifiPricings_WifiPricingID",
        //                column: x => x.WifiPricingID,
        //                principalSchema: "obs",
        //                principalTable: "WifiPricings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialCustomers",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            MonthlyExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            AddressId = table.Column<int>(type: "int", nullable: false),
        //            EmployerId = table.Column<int>(type: "int", nullable: false),
        //            NextOfKinId = table.Column<int>(type: "int", nullable: false),
        //            Parking = table.Column<bool>(type: "bit", nullable: false),
        //            ApartmentTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            NumberOfOccupants = table.Column<int>(type: "int", nullable: false),
        //            NumberOfBays = table.Column<int>(type: "int", nullable: false),
        //            PlannedOccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ApplicationStatusId = table.Column<int>(type: "int", nullable: false),
        //            AmountAppliedFor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            ApprovedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            ReviewedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ApplyingForSameRoom = table.Column<bool>(type: "bit", nullable: false),
        //            AddingTenant = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            IdPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialCustomers", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomers_Addresses_AddressId",
        //                column: x => x.AddressId,
        //                principalSchema: "obs",
        //                principalTable: "Addresses",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomers_ApplicationStatusses_ApplicationStatusId",
        //                column: x => x.ApplicationStatusId,
        //                principalSchema: "obs",
        //                principalTable: "ApplicationStatusses",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomers_Employers_EmployerId",
        //                column: x => x.EmployerId,
        //                principalSchema: "obs",
        //                principalTable: "Employers",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomers_People_NextOfKinId",
        //                column: x => x.NextOfKinId,
        //                principalSchema: "obs",
        //                principalTable: "People",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Towns",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            GeonameId = table.Column<int>(type: "int", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ProvinceID = table.Column<int>(type: "int", nullable: false),
        //            Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            Logitude = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Towns", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Towns_Provinces_ProvinceID",
        //                column: x => x.ProvinceID,
        //                principalSchema: "obs",
        //                principalTable: "Provinces",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ArchivedRoomVacations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IDNumberPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DueToVacateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReturningNextYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            NotReturningReasonID = table.Column<int>(type: "int", nullable: true),
        //            OtherReasonNotReturning = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserWantsDeposit = table.Column<bool>(type: "bit", nullable: false),
        //            Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            WasFoundBySearching = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseBedBuildingID = table.Column<int>(type: "int", nullable: true),
        //            LeaseBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            VacateBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountUpToDate = table.Column<bool>(type: "bit", nullable: false),
        //            InspectionScheduled = table.Column<bool>(type: "bit", nullable: false),
        //            RefundDue = table.Column<bool>(type: "bit", nullable: false),
        //            KeyReturned = table.Column<bool>(type: "bit", nullable: false),
        //            BursarAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Damages = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DateExported = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PreBooked = table.Column<bool>(type: "bit", nullable: false),
        //            DamagesKeys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DamagesOther = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            ArchiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ReasonsNotReturningID = table.Column<int>(type: "int", nullable: true),
        //            AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomInspected = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseNum = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ArchivedRoomVacations", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ArchivedRoomVacations_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ArchivedRoomVacations_ReasonsNotReturnings_ReasonsNotReturningID",
        //                column: x => x.ReasonsNotReturningID,
        //                principalSchema: "obs",
        //                principalTable: "ReasonsNotReturnings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BuildingInstitutionRankings",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            InstitutionID = table.Column<int>(type: "int", nullable: false),
        //            Rank = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.ForeignKey(
        //                name: "FK_BuildingInstitutionRankings_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_BuildingInstitutionRankings_Institutions_InstitutionID",
        //                column: x => x.InstitutionID,
        //                principalSchema: "obs",
        //                principalTable: "Institutions",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BuildingUserRole",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            BuildingsId = table.Column<int>(type: "int", nullable: false),
        //            BuildingUserRolesRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            BuildingUserRolesUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BuildingUserRole", x => new { x.BuildingsId, x.BuildingUserRolesRoleId, x.BuildingUserRolesUserId });
        //            table.ForeignKey(
        //                name: "FK_BuildingUserRole_aspnet_UsersInRoles_BuildingUserRolesRoleId_BuildingUserRolesUserId",
        //                columns: x => new { x.BuildingUserRolesRoleId, x.BuildingUserRolesUserId },
        //                principalSchema: "obs",
        //                principalTable: "aspnet_UsersInRoles",
        //                principalColumns: new[] { "RoleId", "UserId" },
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_BuildingUserRole_Buildings_BuildingsId",
        //                column: x => x.BuildingsId,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CancelReservations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            BursarAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Bed = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OrgID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCancelled = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ExistsAsCustomer = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CancelReservations", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_CancelReservations_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FeeTypeBuildingBillingTypeTemplates",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BuildingId = table.Column<int>(type: "int", nullable: false),
        //            FeeTypeId = table.Column<int>(type: "int", nullable: false),
        //            BillingTemplateId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FeeTypeBuildingBillingTypeTemplates", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_FeeTypeBuildingBillingTypeTemplates_Buildings_BuildingId",
        //                column: x => x.BuildingId,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_FeeTypeBuildingBillingTypeTemplates_FeeTypes_FeeTypeId",
        //                column: x => x.FeeTypeId,
        //                principalSchema: "obs",
        //                principalTable: "FeeTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "HeadLeaseLocations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LocationId = table.Column<int>(type: "int", nullable: false),
        //            LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ApartmentTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MaxOccupancy = table.Column<int>(type: "int", nullable: false),
        //            RoomASharing = table.Column<bool>(type: "bit", nullable: false),
        //            RoomCSharing = table.Column<bool>(type: "bit", nullable: false),
        //            HeadLeaseId = table.Column<int>(type: "int", nullable: false),
        //            OracleTenancyId = table.Column<int>(type: "int", nullable: true),
        //            BuildingId = table.Column<int>(type: "int", nullable: false),
        //            IsParking = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_HeadLeaseLocations", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_HeadLeaseLocations_Buildings_BuildingId",
        //                column: x => x.BuildingId,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_HeadLeaseLocations_HeadLeases_HeadLeaseId",
        //                column: x => x.HeadLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "HeadLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LeaseHistories",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Lease_ID = table.Column<int>(type: "int", nullable: false),
        //            Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HousholdEarnings = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentHomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentWorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HerdFromWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarID = table.Column<int>(type: "int", nullable: true),
        //            AcceptedTermsAndContions = table.Column<bool>(type: "bit", nullable: false),
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FinalLease = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCancelled = table.Column<bool>(type: "bit", nullable: false),
        //            SMSConversationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseRefNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_LEASE_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            PaymentDateExtendedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentDateExtended = table.Column<bool>(type: "bit", nullable: false),
        //            PaymentDateExtendedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReminderSMSSent = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_LeaseHistories", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_LeaseHistories_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Leases",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HousholdEarnings = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentHomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentWorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HeardFromWhereQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HerdFromWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarID = table.Column<int>(type: "int", nullable: true),
        //            AcceptedTermsAndContions = table.Column<bool>(type: "bit", nullable: false),
        //            AcceptedHouseRules = table.Column<bool>(type: "bit", nullable: false),
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FinalLease = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCancelled = table.Column<bool>(type: "bit", nullable: false),
        //            SMSConversationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseRefNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_LEASE_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion1Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion3Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion4Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion5Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion6Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion7Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingBrandAmbassadorNameDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingBrandAmbassadorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion8Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion9Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion10Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion11Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion12Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion13Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PaymentDateExtendedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentDateExtended = table.Column<bool>(type: "bit", nullable: false),
        //            PaymentDateExtendedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReminderSMSSent = table.Column<bool>(type: "bit", nullable: false),
        //            PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Leases", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Leases_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LockedBeds",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LockedTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BuildingID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.ForeignKey(
        //                name: "FK_LockedBeds_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MaintenanceMessages",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            From = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Problem = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Roomnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ToEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FromMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CategoryID = table.Column<int>(type: "int", nullable: false),
        //            StatusID = table.Column<int>(type: "int", nullable: false),
        //            AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LookupID = table.Column<int>(type: "int", nullable: true),
        //            Lookup1ID = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MaintenanceMessages", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_MaintenanceMessages_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_MaintenanceMessages_Lookups_Lookup1ID",
        //                column: x => x.Lookup1ID,
        //                principalSchema: "obs",
        //                principalTable: "Lookups",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_MaintenanceMessages_Lookups_LookupID",
        //                column: x => x.LookupID,
        //                principalSchema: "obs",
        //                principalTable: "Lookups",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialPrices",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BuildingId = table.Column<int>(type: "int", nullable: false),
        //            ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BillingPeriodId = table.Column<int>(type: "int", nullable: false),
        //            FeeTypeId = table.Column<int>(type: "int", nullable: false),
        //            NumberOfOccupants = table.Column<int>(type: "int", nullable: false),
        //            Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialPrices", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ResidentialPrices_BillingPeriods_BillingPeriodId",
        //                column: x => x.BillingPeriodId,
        //                principalSchema: "obs",
        //                principalTable: "BillingPeriods",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialPrices_Buildings_BuildingId",
        //                column: x => x.BuildingId,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialPrices_FeeTypes_FeeTypeId",
        //                column: x => x.FeeTypeId,
        //                principalSchema: "obs",
        //                principalTable: "FeeTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RoomVacations",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IDNumberPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DueToVacateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Account = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReturningNextYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            NotReturningReasonID = table.Column<int>(type: "int", nullable: true),
        //            OtherReasonNotReturning = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserWantsDeposit = table.Column<bool>(type: "bit", nullable: false),
        //            Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            WasFoundBySearching = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseBedBuildingID = table.Column<int>(type: "int", nullable: true),
        //            LeaseBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            VacateBedLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountUpToDate = table.Column<bool>(type: "bit", nullable: false),
        //            InspectionScheduled = table.Column<bool>(type: "bit", nullable: false),
        //            RefundDue = table.Column<bool>(type: "bit", nullable: false),
        //            KeyReturned = table.Column<bool>(type: "bit", nullable: false),
        //            Damages = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DateExported = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            BursarAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PreBooked = table.Column<bool>(type: "bit", nullable: false),
        //            DamagesKeys = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            DamagesOther = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            LeaseNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReasonsNotReturningID = table.Column<int>(type: "int", nullable: true),
        //            AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomInspected = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RoomVacations", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_RoomVacations_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalSchema: "obs",
        //                principalTable: "Buildings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_RoomVacations_ReasonsNotReturnings_ReasonsNotReturningID",
        //                column: x => x.ReasonsNotReturningID,
        //                principalSchema: "obs",
        //                principalTable: "ReasonsNotReturnings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RefundMessage",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MessageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RefundRequestID = table.Column<int>(type: "int", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            RefundStatusesID = table.Column<int>(type: "int", nullable: false),
        //            RefundStatusId = table.Column<int>(type: "int", nullable: true),
        //            MessageSender = table.Column<int>(type: "int", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            RequiredDocuments = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SentBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RefundMessage", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_RefundMessage_RefundRequest_RefundRequestID",
        //                column: x => x.RefundRequestID,
        //                principalSchema: "obs",
        //                principalTable: "RefundRequest",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_RefundMessage_RefundStatus_RefundStatusId",
        //                column: x => x.RefundStatusId,
        //                principalSchema: "obs",
        //                principalTable: "RefundStatus",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialCustomerDocuments",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ResidentialCustomerId = table.Column<int>(type: "int", nullable: false),
        //            DocumentId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialCustomerDocuments", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomerDocuments_Documents_DocumentId",
        //                column: x => x.DocumentId,
        //                principalSchema: "obs",
        //                principalTable: "Documents",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomerDocuments_ResidentialCustomers_ResidentialCustomerId",
        //                column: x => x.ResidentialCustomerId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialCustomers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialCustomerSubOccupants",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IdPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResidentialCustomerId = table.Column<int>(type: "int", nullable: false),
        //            HasParking = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialCustomerSubOccupants", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ResidentialCustomerSubOccupants_ResidentialCustomers_ResidentialCustomerId",
        //                column: x => x.ResidentialCustomerId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialCustomers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialLeases",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ApartmentTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RoomLocationId = table.Column<int>(type: "int", nullable: true),
        //            LeaseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseRefNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            FinalLease = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseCancelled = table.Column<bool>(type: "bit", nullable: false),
        //            ResidentialCustomerId = table.Column<int>(type: "int", nullable: true),
        //            ResidentialBursarCustomerId = table.Column<int>(type: "int", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            PaymentDateExtendedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentDateExtended = table.Column<bool>(type: "bit", nullable: false),
        //            PaymentDateExtendedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReminderSMSSent = table.Column<bool>(type: "bit", nullable: false),
        //            AcceptHouseRules = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialLeases", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ResidentialLeases_ResidentialBursarCustomers_ResidentialBursarCustomerId",
        //                column: x => x.ResidentialBursarCustomerId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialBursarCustomers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_ResidentialLeases_ResidentialCustomers_ResidentialCustomerId",
        //                column: x => x.ResidentialCustomerId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialCustomers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AutoCancelledLeases",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StudentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ID_Passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Initials = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HousholdEarnings = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentHomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentWorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ParentPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HerdFromWhere = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HeardFromWhereQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            SecurityPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarID = table.Column<int>(type: "int", nullable: true),
        //            AcceptedTermsAndContions = table.Column<bool>(type: "bit", nullable: false),
        //            BedID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FinalLease = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseCancelled = table.Column<bool>(type: "bit", nullable: false),
        //            SMSConversationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseRefNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_CUST_ACCOUNT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Ora_LEASE_NUM = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion1Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MarketingQuestion3Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            PaymentDateExtendedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            PaymentDateExtended = table.Column<bool>(type: "bit", nullable: false),
        //            PaymentDateExtendedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReminderSMSSent = table.Column<bool>(type: "bit", nullable: false),
        //            DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseKey = table.Column<int>(type: "int", nullable: true),
        //            LeaseID1 = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AutoCancelledLeases", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_AutoCancelledLeases_Leases_LeaseID1",
        //                column: x => x.LeaseID1,
        //                principalSchema: "obs",
        //                principalTable: "Leases",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MonthlyPayments",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            LeaseID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MonthlyPayments", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_MonthlyPayments_Leases_LeaseID",
        //                column: x => x.LeaseID,
        //                principalSchema: "obs",
        //                principalTable: "Leases",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OnceOffPayments",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LeaseID = table.Column<int>(type: "int", nullable: false),
        //            Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OnceOffPayments", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_OnceOffPayments_Leases_LeaseID",
        //                column: x => x.LeaseID,
        //                principalSchema: "obs",
        //                principalTable: "Leases",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RefundAttachment",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RefundMessageID = table.Column<int>(type: "int", nullable: false),
        //            AttachmentTypeID = table.Column<int>(type: "int", nullable: false),
        //            AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RefundAttachment", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_RefundAttachment_RefundAttachmentType_AttachmentTypeID",
        //                column: x => x.AttachmentTypeID,
        //                principalSchema: "obs",
        //                principalTable: "RefundAttachmentType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_RefundAttachment_RefundMessage_RefundMessageID",
        //                column: x => x.RefundMessageID,
        //                principalSchema: "obs",
        //                principalTable: "RefundMessage",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Parkings",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResidentialLeaseId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Parkings", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Parkings_ResidentialLeases_ResidentialLeaseId",
        //                column: x => x.ResidentialLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialCancelledLeases",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OrgID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PartyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PersonIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BursarType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TenAttribute1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseYear = table.Column<int>(type: "int", nullable: false),
        //            ResidentialLeaseId = table.Column<int>(type: "int", nullable: false),
        //            CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.ForeignKey(
        //                name: "FK_ResidentialCancelledLeases_ResidentialLeases_ResidentialLeaseId",
        //                column: x => x.ResidentialLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ResidentialLeasePricing",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            NoOccupants = table.Column<int>(type: "int", nullable: false),
        //            Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            Refundable = table.Column<bool>(type: "bit", nullable: false),
        //            VariableNoTenants = table.Column<bool>(type: "bit", nullable: false),
        //            FeeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BillingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResidentialLeaseId = table.Column<int>(type: "int", nullable: false),
        //            TermTemplateId = table.Column<int>(type: "int", nullable: false),
        //            BillingTypeId = table.Column<int>(type: "int", nullable: false),
        //            FrequencyTypeId = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ResidentialLeasePricing", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ResidentialLeasePricing_FeeTypes_BillingTypeId",
        //                column: x => x.BillingTypeId,
        //                principalSchema: "obs",
        //                principalTable: "FeeTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialLeasePricing_FrequencyTypes_FrequencyTypeId",
        //                column: x => x.FrequencyTypeId,
        //                principalSchema: "obs",
        //                principalTable: "FrequencyTypes",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ResidentialLeasePricing_ResidentialLeases_ResidentialLeaseId",
        //                column: x => x.ResidentialLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SentEmails",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LeaseID = table.Column<int>(type: "int", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResidentialLeaseId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SentEmails", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_SentEmails_Leases_LeaseID",
        //                column: x => x.LeaseID,
        //                principalSchema: "obs",
        //                principalTable: "Leases",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_SentEmails_ResidentialLeases_ResidentialLeaseId",
        //                column: x => x.ResidentialLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SentSMS",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LeaseID = table.Column<int>(type: "int", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResidentialLeaseId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SentSMS", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_SentSMS_Leases_LeaseID",
        //                column: x => x.LeaseID,
        //                principalSchema: "obs",
        //                principalTable: "Leases",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_SentSMS_ResidentialLeases_ResidentialLeaseId",
        //                column: x => x.ResidentialLeaseId,
        //                principalSchema: "obs",
        //                principalTable: "ResidentialLeases",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RoomExpirationNotifications",
        //        schema: "obs",
        //        columns: table => new
        //        {
        //            Id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            LeaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            MobileNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
        //            Comment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
        //            SmsId = table.Column<int>(type: "int", nullable: true),
        //            EmailId = table.Column<int>(type: "int", nullable: true),
        //            ReminderPeriod = table.Column<int>(type: "int", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RoomExpirationNotifications", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_RoomExpirationNotifications_SentEmails_EmailId",
        //                column: x => x.EmailId,
        //                principalSchema: "obs",
        //                principalTable: "SentEmails",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_RoomExpirationNotifications_SentSMS_SmsId",
        //                column: x => x.SmsId,
        //                principalSchema: "obs",
        //                principalTable: "SentSMS",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ArchivedRoomVacations_BuildingID",
        //        schema: "obs",
        //        table: "ArchivedRoomVacations",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ArchivedRoomVacations_ReasonsNotReturningID",
        //        schema: "obs",
        //        table: "ArchivedRoomVacations",
        //        column: "ReasonsNotReturningID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_aspnet_UsersInRoles_UserId",
        //        schema: "obs",
        //        table: "aspnet_UsersInRoles",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditeHeaderDetails_AuditHeaderID",
        //        schema: "obs",
        //        table: "AuditeHeaderDetails",
        //        column: "AuditHeaderID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AutoCancelledLeases_LeaseID1",
        //        schema: "obs",
        //        table: "AutoCancelledLeases",
        //        column: "LeaseID1");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_BuildingInstitutionRankings_BuildingID",
        //        schema: "obs",
        //        table: "BuildingInstitutionRankings",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_BuildingInstitutionRankings_InstitutionID",
        //        schema: "obs",
        //        table: "BuildingInstitutionRankings",
        //        column: "InstitutionID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Buildings_CityID",
        //        schema: "obs",
        //        table: "Buildings",
        //        column: "CityID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Buildings_MapID",
        //        schema: "obs",
        //        table: "Buildings",
        //        column: "MapID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Buildings_OrganizationID",
        //        schema: "obs",
        //        table: "Buildings",
        //        column: "OrganizationID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_BuildingUserRole_BuildingUserRolesRoleId_BuildingUserRolesUserId",
        //        schema: "obs",
        //        table: "BuildingUserRole",
        //        columns: new[] { "BuildingUserRolesRoleId", "BuildingUserRolesUserId" });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_BursarPricingItem_BursarFeeTypeID",
        //        schema: "obs",
        //        table: "BursarPricingItem",
        //        column: "BursarFeeTypeID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_BursarPricingItem_BursarPricingID",
        //        schema: "obs",
        //        table: "BursarPricingItem",
        //        column: "BursarPricingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CancelReservations_BuildingID",
        //        schema: "obs",
        //        table: "CancelReservations",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CityInstitutions_CityID",
        //        schema: "obs",
        //        table: "CityInstitutions",
        //        column: "CityID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CityInstitutions_InstitutionID",
        //        schema: "obs",
        //        table: "CityInstitutions",
        //        column: "InstitutionID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Documents_DocumentTypeId",
        //        schema: "obs",
        //        table: "Documents",
        //        column: "DocumentTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Employers_AddressId",
        //        schema: "obs",
        //        table: "Employers",
        //        column: "AddressId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_FeeTypeBuildingBillingTypeTemplates_BuildingId",
        //        schema: "obs",
        //        table: "FeeTypeBuildingBillingTypeTemplates",
        //        column: "BuildingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_FeeTypeBuildingBillingTypeTemplates_FeeTypeId",
        //        schema: "obs",
        //        table: "FeeTypeBuildingBillingTypeTemplates",
        //        column: "FeeTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_FeeTypes_FrequencyId",
        //        schema: "obs",
        //        table: "FeeTypes",
        //        column: "FrequencyId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_HeadLeaseLocations_BuildingId",
        //        schema: "obs",
        //        table: "HeadLeaseLocations",
        //        column: "BuildingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_HeadLeaseLocations_HeadLeaseId",
        //        schema: "obs",
        //        table: "HeadLeaseLocations",
        //        column: "HeadLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_LeaseHistories_BuildingID",
        //        schema: "obs",
        //        table: "LeaseHistories",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Leases_BuildingID",
        //        schema: "obs",
        //        table: "Leases",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_LockedBeds_BuildingID",
        //        schema: "obs",
        //        table: "LockedBeds",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Lookups_LookupTypeID",
        //        schema: "obs",
        //        table: "Lookups",
        //        column: "LookupTypeID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_MaintenanceMessages_BuildingID",
        //        schema: "obs",
        //        table: "MaintenanceMessages",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_MaintenanceMessages_Lookup1ID",
        //        schema: "obs",
        //        table: "MaintenanceMessages",
        //        column: "Lookup1ID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_MaintenanceMessages_LookupID",
        //        schema: "obs",
        //        table: "MaintenanceMessages",
        //        column: "LookupID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_MonthlyPayments_LeaseID",
        //        schema: "obs",
        //        table: "MonthlyPayments",
        //        column: "LeaseID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnceOffPayments_LeaseID",
        //        schema: "obs",
        //        table: "OnceOffPayments",
        //        column: "LeaseID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Parkings_ResidentialLeaseId",
        //        schema: "obs",
        //        table: "Parkings",
        //        column: "ResidentialLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_People_AddressId",
        //        schema: "obs",
        //        table: "People",
        //        column: "AddressId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Provinces_CountryID",
        //        schema: "obs",
        //        table: "Provinces",
        //        column: "CountryID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RefundAttachment_AttachmentTypeID",
        //        schema: "obs",
        //        table: "RefundAttachment",
        //        column: "AttachmentTypeID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RefundAttachment_RefundMessageID",
        //        schema: "obs",
        //        table: "RefundAttachment",
        //        column: "RefundMessageID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RefundMessage_RefundRequestID",
        //        schema: "obs",
        //        table: "RefundMessage",
        //        column: "RefundRequestID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RefundMessage_RefundStatusId",
        //        schema: "obs",
        //        table: "RefundMessage",
        //        column: "RefundStatusId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RefundRequest_RefundStatusID",
        //        schema: "obs",
        //        table: "RefundRequest",
        //        column: "RefundStatusID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCancelledLeases_ResidentialLeaseId",
        //        schema: "obs",
        //        table: "ResidentialCancelledLeases",
        //        column: "ResidentialLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomerDocuments_DocumentId",
        //        schema: "obs",
        //        table: "ResidentialCustomerDocuments",
        //        column: "DocumentId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomerDocuments_ResidentialCustomerId",
        //        schema: "obs",
        //        table: "ResidentialCustomerDocuments",
        //        column: "ResidentialCustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomers_AddressId",
        //        schema: "obs",
        //        table: "ResidentialCustomers",
        //        column: "AddressId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomers_ApplicationStatusId",
        //        schema: "obs",
        //        table: "ResidentialCustomers",
        //        column: "ApplicationStatusId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomers_EmployerId",
        //        schema: "obs",
        //        table: "ResidentialCustomers",
        //        column: "EmployerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomers_NextOfKinId",
        //        schema: "obs",
        //        table: "ResidentialCustomers",
        //        column: "NextOfKinId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialCustomerSubOccupants_ResidentialCustomerId",
        //        schema: "obs",
        //        table: "ResidentialCustomerSubOccupants",
        //        column: "ResidentialCustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialLeasePricing_BillingTypeId",
        //        schema: "obs",
        //        table: "ResidentialLeasePricing",
        //        column: "BillingTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialLeasePricing_FrequencyTypeId",
        //        schema: "obs",
        //        table: "ResidentialLeasePricing",
        //        column: "FrequencyTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialLeasePricing_ResidentialLeaseId",
        //        schema: "obs",
        //        table: "ResidentialLeasePricing",
        //        column: "ResidentialLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialLeases_ResidentialBursarCustomerId",
        //        schema: "obs",
        //        table: "ResidentialLeases",
        //        column: "ResidentialBursarCustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialLeases_ResidentialCustomerId",
        //        schema: "obs",
        //        table: "ResidentialLeases",
        //        column: "ResidentialCustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialPrices_BillingPeriodId",
        //        schema: "obs",
        //        table: "ResidentialPrices",
        //        column: "BillingPeriodId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialPrices_BuildingId",
        //        schema: "obs",
        //        table: "ResidentialPrices",
        //        column: "BuildingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ResidentialPrices_FeeTypeId",
        //        schema: "obs",
        //        table: "ResidentialPrices",
        //        column: "FeeTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RoomExpirationNotifications_EmailId",
        //        schema: "obs",
        //        table: "RoomExpirationNotifications",
        //        column: "EmailId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RoomExpirationNotifications_SmsId",
        //        schema: "obs",
        //        table: "RoomExpirationNotifications",
        //        column: "SmsId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RoomVacations_BuildingID",
        //        schema: "obs",
        //        table: "RoomVacations",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_RoomVacations_ReasonsNotReturningID",
        //        schema: "obs",
        //        table: "RoomVacations",
        //        column: "ReasonsNotReturningID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SentEmails_LeaseID",
        //        schema: "obs",
        //        table: "SentEmails",
        //        column: "LeaseID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SentEmails_ResidentialLeaseId",
        //        schema: "obs",
        //        table: "SentEmails",
        //        column: "ResidentialLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SentSMS_LeaseID",
        //        schema: "obs",
        //        table: "SentSMS",
        //        column: "LeaseID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SentSMS_ResidentialLeaseId",
        //        schema: "obs",
        //        table: "SentSMS",
        //        column: "ResidentialLeaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Sleepover_SleepoverTypeId",
        //        schema: "obs",
        //        table: "Sleepover",
        //        column: "SleepoverTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Towns_ProvinceID",
        //        schema: "obs",
        //        table: "Towns",
        //        column: "ProvinceID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transaction_SbuxMerchantId",
        //        schema: "obs",
        //        table: "Transaction",
        //        column: "SbuxMerchantId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transaction_TransactionTypeId",
        //        schema: "obs",
        //        table: "Transaction",
        //        column: "TransactionTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_VacateInspectionLists_ApartmentTypeId",
        //        schema: "obs",
        //        table: "VacateInspectionLists",
        //        column: "ApartmentTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_WifiAllocations_WifiPricingID",
        //        schema: "obs",
        //        table: "WifiAllocations",
        //        column: "WifiPricingID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_WifiBuildingPriceMaps_WifiPricingID",
        //        schema: "obs",
        //        table: "WifiBuildingPriceMaps",
        //        column: "WifiPricingID");
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "AdminOveridePins",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ApplicationConfigurations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ArchiveBlacklist",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ArchivedRoomVacations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "aspnet_Membership",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "aspnet_Users_UserDetails",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "AuditeHeaderDetails",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "AutoCancelledLeases",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Blacklist",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BuildingInstitutionRankings",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BuildingUserRole",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BursarPricingItem",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Bursars",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BursarValidationEntries",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BursarValidations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "CancelReservations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "CityInstitutions",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "CustomMessageDataExtracts",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "CustomSentMessages",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "FeeTypeBuildingBillingTypeTemplates",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "FrequencyCalculationRules",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "GraduationQuestions",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "HeadLeaseLocations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "LeaseHistories",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "LeasesExports",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "LockedBeds",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "MailMessages",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "MaintenanceMessages",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "MaintenanceMessagesViews",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "MonthlyPayments",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "OnceOffPayments",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "OracleErrorCodes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "OtpSent",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Parkings",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "PendingBiometrics",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "QuoteAudits",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RefundAttachment",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialCancelledLeases",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialCustomerDocuments",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialCustomerSubOccupants",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialLeasePricing",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialPrices",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RoomExpirationNotifications",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RoomTypeDTO",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RoomVacations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RoomVacationView",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Sleepover",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "sysdiagrams",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Towns",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Transaction",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "VacateInspectionLists",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "WifiAllocations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "WifiBuildingPriceMaps",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "AuditHeaders",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "aspnet_UsersInRoles",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BursarFeeType",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BursarPricing",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Institutions",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "HeadLeases",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Lookups",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RefundAttachmentType",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RefundMessage",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Documents",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "BillingPeriods",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "FeeTypes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "SentEmails",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "SentSMS",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ReasonsNotReturnings",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "SleepoverType",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Provinces",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "SbuxMerchant",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "TransactionType",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ApartmentTypes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "WifiPricings",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "aspnet_Roles",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "aspnet_Users",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "LookupTypes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RefundRequest",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "DocumentTypes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "FrequencyTypes",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Leases",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialLeases",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Countries",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "RefundStatus",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Buildings",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialBursarCustomers",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ResidentialCustomers",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Cities",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Maps",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Organizations",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "ApplicationStatusses",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Employers",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "People",
        //        schema: "obs");

        //    migrationBuilder.DropTable(
        //        name: "Addresses",
        //        schema: "obs");
        //}
    }
}
