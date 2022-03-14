using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS.API.Migrations.SouthPointDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) { }
        protected override void Down(MigrationBuilder migrationBuilder) { }

        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.CreateTable(
        //        name: "APICustomField",
        //        columns: table => new
        //        {
        //            APICustomFieldId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            cf_desired_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_id_passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_customer_id = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            cf_customer_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_lease_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_lease_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_region = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_za_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_building = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_room = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APICustomField", x => x.APICustomFieldId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ApiOutcomes",
        //        columns: table => new
        //        {
        //            outcome_id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            description = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ApiOutcomes", x => x.outcome_id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "APITasks",
        //        columns: table => new
        //        {
        //            id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            targetable_id = table.Column<long>(type: "bigint", nullable: false),
        //            targetable_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            task_type_id = table.Column<long>(type: "bigint", nullable: true),
        //            owner_id = table.Column<long>(type: "bigint", nullable: true),
        //            completed_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            creater_id = table.Column<long>(type: "bigint", nullable: false),
        //            status = table.Column<int>(type: "int", nullable: false),
        //            created_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            updated_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            updater_id = table.Column<long>(type: "bigint", nullable: true),
        //            outcome_id = table.Column<long>(type: "bigint", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APITasks", x => x.id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "APIUsers",
        //        columns: table => new
        //        {
        //            id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            display_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            is_active = table.Column<bool>(type: "bit", nullable: false),
        //            work_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            auth_key = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APIUsers", x => x.id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Apps",
        //        columns: table => new
        //        {
        //            AppID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AppGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            AppName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AppPackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AppOS = table.Column<int>(type: "int", nullable: false),
        //            AppVersionNameCurrent = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AppBuildNumberCurrent = table.Column<int>(type: "int", nullable: false),
        //            AppVersionNameMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AppBuildNumberMin = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Apps", x => x.AppID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AppVersions",
        //        columns: table => new
        //        {
        //            AppVersionID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            AppID = table.Column<int>(type: "int", nullable: false),
        //            AppVersionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AppBuildNumber = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AppVersions", x => x.AppVersionID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetRoles",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "VARCHAR(512)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsRestricted = table.Column<bool>(type: "bit", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetRoles", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditHistory",
        //        columns: table => new
        //        {
        //            AuditHistoryID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserID = table.Column<int>(type: "int", nullable: false),
        //            EntityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            EntityID = table.Column<int>(type: "int", nullable: false),
        //            CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EventData = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SPDevice = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SPSource = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditHistory", x => x.AuditHistoryID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Categories",
        //        columns: table => new
        //        {
        //            CategoryId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Categories", x => x.CategoryId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChecklistLocations",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
        //            Answer = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            Order = table.Column<int>(type: "int", nullable: false),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ChecklistLocations", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChecklistQuestions",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
        //            ChecklistTemplateId = table.Column<int>(type: "int", nullable: false),
        //            Question = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            Description = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            Order = table.Column<int>(type: "int", nullable: false),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ChecklistQuestions", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChecklistStates",
        //        columns: table => new
        //        {
        //            ChecklistStateId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Priority = table.Column<int>(type: "int", nullable: false),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ChecklistStates", x => x.ChecklistStateId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChecklistTemplates",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
        //            Name = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ChecklistTemplates", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Comments",
        //        columns: table => new
        //        {
        //            CommentID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CommentOwner = table.Column<int>(type: "int", nullable: false),
        //            CommentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            RequestID = table.Column<int>(type: "int", nullable: false),
        //            ChecklistID = table.Column<int>(type: "int", nullable: true),
        //            Private = table.Column<bool>(type: "bit", nullable: false),
        //            ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Comments", x => x.CommentID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Disciplines",
        //        columns: table => new
        //        {
        //            DisciplineId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Disciplines", x => x.DisciplineId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DSPage",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastAccessed = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DSPage", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DSPermissionTypes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsPageSpecific = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DSPermissionTypes", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "EmployeeBuildings",
        //        columns: table => new
        //        {
        //            EmployeeBuildingId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            EmployeeId = table.Column<int>(type: "int", nullable: false),
        //            BuildingId = table.Column<int>(type: "int", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_EmployeeBuildings", x => x.EmployeeBuildingId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FailedJobErrors",
        //        columns: table => new
        //        {
        //            FailedJobErrorId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RecordNumber = table.Column<int>(type: "int", nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Created = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            JobId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FailedJobErrors", x => x.FailedJobErrorId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FailedJobs",
        //        columns: table => new
        //        {
        //            FailedJobID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Locked = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<int>(type: "int", nullable: false),
        //            Finished = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            pos = table.Column<long>(type: "bigint", nullable: false),
        //            TotalRecords = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FailedJobs", x => x.FailedJobID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Floors",
        //        columns: table => new
        //        {
        //            ID = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            OracleFloorId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            BuildingId = table.Column<long>(type: "bigint", nullable: false),
        //            OracleBuildingId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            OracleFloorNumber = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Floors", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FreshData",
        //        columns: table => new
        //        {
        //            id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            key = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            data = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FreshData", x => x.id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ImportJobErrors",
        //        columns: table => new
        //        {
        //            ImportJobErrorId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RecordNumber = table.Column<int>(type: "int", nullable: false),
        //            IdORPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumer = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RawData = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            JobId = table.Column<int>(type: "int", nullable: false),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ImportJobErrors", x => x.ImportJobErrorId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ImportJobs",
        //        columns: table => new
        //        {
        //            ImportJobID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Locked = table.Column<bool>(type: "bit", nullable: false),
        //            Status = table.Column<int>(type: "int", nullable: false),
        //            Finished = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            pos = table.Column<long>(type: "bigint", nullable: false),
        //            DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            AgentIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TotalRecords = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ImportJobs", x => x.ImportJobID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PublicHolidays",
        //        columns: table => new
        //        {
        //            PublicHolidayID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            PublicHolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PublicHolidayDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PublicHolidays", x => x.PublicHolidayID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Queries",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Fullname = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Surname = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Phone = table.Column<string>(type: "VARCHAR(30)", nullable: true),
        //            Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsResolved = table.Column<bool>(type: "bit", nullable: false),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Queries", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Question",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Order = table.Column<int>(type: "int", nullable: false),
        //            Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ResponseRequired = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Question", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Regions",
        //        columns: table => new
        //        {
        //            Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        //            Name = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Regions", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RequestAudits",
        //        columns: table => new
        //        {
        //            RequestAuditID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RequestID = table.Column<int>(type: "int", nullable: false),
        //            UserID = table.Column<int>(type: "int", nullable: false),
        //            Status = table.Column<int>(type: "int", nullable: true),
        //            AssignedToID = table.Column<int>(type: "int", nullable: true),
        //            ReAssignedToID = table.Column<int>(type: "int", nullable: true),
        //            LoggedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RequestAudits", x => x.RequestAuditID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RequestCommentImages",
        //        columns: table => new
        //        {
        //            RequestCommentImageID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CommentID = table.Column<int>(type: "int", nullable: false),
        //            RequestCommentImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsPrivateImage = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RequestCommentImages", x => x.RequestCommentImageID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RequestImages",
        //        columns: table => new
        //        {
        //            RequestImageID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RequestID = table.Column<int>(type: "int", nullable: false),
        //            RequestImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsPrivateImage = table.Column<bool>(type: "bit", nullable: false),
        //            CreatedBy = table.Column<int>(type: "int", nullable: false),
        //            DatedCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RequestImages", x => x.RequestImageID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Requests",
        //        columns: table => new
        //        {
        //            RequestID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            BuildingID = table.Column<int>(type: "int", nullable: false),
        //            FloorID = table.Column<int>(type: "int", nullable: false),
        //            RoomID = table.Column<int>(type: "int", nullable: false),
        //            CommonAreasID = table.Column<int>(type: "int", nullable: false),
        //            CategoryID = table.Column<int>(type: "int", nullable: false),
        //            SubCategoryID = table.Column<int>(type: "int", nullable: false),
        //            RequestDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AssignedEmployee = table.Column<int>(type: "int", nullable: true),
        //            RequestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            State = table.Column<int>(type: "int", nullable: false),
        //            LoggedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ClosedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ArchivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsArchived = table.Column<bool>(type: "bit", nullable: false),
        //            LoggedBy = table.Column<int>(type: "int", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            RequestRatingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            WorkDurationDays = table.Column<int>(type: "int", nullable: false),
        //            Rating = table.Column<int>(type: "int", nullable: false),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RatingComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TenantID = table.Column<int>(type: "int", nullable: true),
        //            SPDevice = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SPSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Queried = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Requests", x => x.RequestID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RoleDefinedStatuses",
        //        columns: table => new
        //        {
        //            AllowedRoleStatesID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RoleID = table.Column<int>(type: "int", nullable: false),
        //            StateID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RoleDefinedStatuses", x => x.AllowedRoleStatesID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Rooms",
        //        columns: table => new
        //        {
        //            ID = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            FloorId = table.Column<long>(type: "bigint", nullable: false),
        //            OracleFloorId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            OracleLocationCode = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            OracleRoomNumber = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Rooms", x => x.ID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Sections",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Sections", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ServiceLevelAgreements",
        //        columns: table => new
        //        {
        //            ServiceLevelAgreementID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Priority = table.Column<int>(type: "int", nullable: false),
        //            Duration = table.Column<double>(type: "float", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ServiceLevelAgreements", x => x.ServiceLevelAgreementID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ShortUrls",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Clicks = table.Column<int>(type: "int", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ShortUrls", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SouthPointHolidays",
        //        columns: table => new
        //        {
        //            SouthPointHolidayID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            HolidayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            StudentCanLogin = table.Column<bool>(type: "bit", nullable: false),
        //            ArtisanCanWork = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SouthPointHolidays", x => x.SouthPointHolidayID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "StateDefinedStatuses",
        //        columns: table => new
        //        {
        //            AllowedNextStatesID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            StatusID = table.Column<int>(type: "int", nullable: false),
        //            NextID = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_StateDefinedStatuses", x => x.AllowedNextStatesID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Statuses",
        //        columns: table => new
        //        {
        //            StatusID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            HexColour = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Statuses", x => x.StatusID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SubCategories",
        //        columns: table => new
        //        {
        //            SubCategoryId = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            CategoryId = table.Column<int>(type: "int", nullable: false),
        //            RequestslaId = table.Column<int>(type: "int", nullable: false),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DefaultTimeToCompletion = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TemplateMessages",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Sent = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TemplateMessages", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Tenants",
        //        columns: table => new
        //        {
        //            TenantID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IDNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PartyType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Institution = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PartyID = table.Column<long>(type: "bigint", nullable: false),
        //            Attribute1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IdentityType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<long>(type: "bigint", nullable: false),
        //            LeaseNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupancyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseID = table.Column<long>(type: "bigint", nullable: false),
        //            BuildingID = table.Column<long>(type: "bigint", nullable: false),
        //            SPRefenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            City = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Tenants", x => x.TenantID);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "APILeads",
        //        columns: table => new
        //        {
        //            id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            campaign_id = table.Column<long>(type: "bigint", nullable: true),
        //            deal_product_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            address = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            email = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            city = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            lead_source_id = table.Column<long>(type: "bigint", nullable: false),
        //            medium = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            work = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            country = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            lead_stage_id = table.Column<long>(type: "bigint", nullable: true),
        //            owner_id = table.Column<long>(type: "bigint", nullable: true),
        //            custom_fieldAPICustomFieldId = table.Column<int>(type: "int", nullable: true),
        //            Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            is_evaluated = table.Column<bool>(type: "bit", nullable: true),
        //            cf_id_passport = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_room_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_lease_num = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_comencement_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_termination_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_account_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_institution_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_tenn_bursar_flex_account_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_tenn_bursar_flex_account_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_tenn_bursar_flex_party_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_balance_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_run_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_marketing_q1_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_marketing_q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_marketing_amb_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_location_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_spms_balance = table.Column<double>(type: "float", nullable: true),
        //            cf_sasp_balance = table.Column<double>(type: "float", nullable: true),
        //            cf_student_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_account_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_customer_id = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            cf_book_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_parent_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_customer_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_lease_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_lease_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_region = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_za_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_building = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            cf_room = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APILeads", x => x.id);
        //            table.ForeignKey(
        //                name: "FK_APILeads_APICustomField_custom_fieldAPICustomFieldId",
        //                column: x => x.custom_fieldAPICustomFieldId,
        //                principalTable: "APICustomField",
        //                principalColumn: "APICustomFieldId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "APIForeignUsers",
        //        columns: table => new
        //        {
        //            user_id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            APITaskid = table.Column<long>(type: "bigint", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APIForeignUsers", x => x.user_id);
        //            table.ForeignKey(
        //                name: "FK_APIForeignUsers_APITasks_APITaskid",
        //                column: x => x.APITaskid,
        //                principalTable: "APITasks",
        //                principalColumn: "id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DSPageRolePermissions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            RoleId = table.Column<int>(type: "int", nullable: false),
        //            DSPageId = table.Column<int>(type: "int", nullable: false),
        //            DSPermissionTypeId = table.Column<int>(type: "int", nullable: false),
        //            Active = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DSPageRolePermissions", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_DSPageRolePermissions_AspNetRoles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_DSPageRolePermissions_DSPage_DSPageId",
        //                column: x => x.DSPageId,
        //                principalTable: "DSPage",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_DSPageRolePermissions_DSPermissionTypes_DSPermissionTypeId",
        //                column: x => x.DSPermissionTypeId,
        //                principalTable: "DSPermissionTypes",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CommonAreas",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            FloorID = table.Column<long>(type: "bigint", nullable: false),
        //            BuildingID = table.Column<long>(type: "bigint", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CommonAreas", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_CommonAreas_Floors_FloorID",
        //                column: x => x.FloorID,
        //                principalTable: "Floors",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Buildings",
        //        columns: table => new
        //        {
        //            ID = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            OracleBuildingId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            OracleLocationCode = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            OracleBuildingName = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            OracleTotalNumberOfFloors = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            AllowUserRegistration = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Buildings", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Buildings_Regions_RegionId",
        //                column: x => x.RegionId,
        //                principalTable: "Regions",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Locations",
        //        columns: table => new
        //        {
        //            LocationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        //            LocationAlias = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            LocationCode = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            LocationTypeLookupCode = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Office = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            ParentLocationID = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            ParentLocation = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Name = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
        //            OldBuildingId = table.Column<int>(type: "int", nullable: true),
        //            Floor = table.Column<int>(type: "int", nullable: true),
        //            ActiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ActiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Locations", x => x.LocationId);
        //            table.ForeignKey(
        //                name: "FK_Locations_Regions_RegionId",
        //                column: x => x.RegionId,
        //                principalTable: "Regions",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SectionQustions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            SectionId = table.Column<int>(type: "int", nullable: false),
        //            QuestionId = table.Column<int>(type: "int", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SectionQustions", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_SectionQustions_Question_QuestionId",
        //                column: x => x.QuestionId,
        //                principalTable: "Question",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_SectionQustions_Sections_SectionId",
        //                column: x => x.SectionId,
        //                principalTable: "Sections",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "APIDeal",
        //        columns: table => new
        //        {
        //            id = table.Column<long>(type: "bigint", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            name = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            base_currency_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
        //            deal_pipeline_id = table.Column<long>(type: "bigint", nullable: true),
        //            deal_stage_id = table.Column<long>(type: "bigint", nullable: true),
        //            deal_type_id = table.Column<long>(type: "bigint", nullable: true),
        //            owner_id = table.Column<long>(type: "bigint", nullable: true),
        //            expected_close = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            closed_date = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            lead_source_id = table.Column<long>(type: "bigint", nullable: true),
        //            APIContactid = table.Column<long>(type: "bigint", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_APIDeal", x => x.id);
        //            table.ForeignKey(
        //                name: "FK_APIDeal_APILeads_APIContactid",
        //                column: x => x.APIContactid,
        //                principalTable: "APILeads",
        //                principalColumn: "id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUsers",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AltMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            AltEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SPRefenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
        //            BalanceFetchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            BalanceIsUpToDate = table.Column<bool>(type: "bit", nullable: true),
        //            MobileNumber = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            MobileNumberConfirmed = table.Column<int>(type: "int", nullable: false),
        //            LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            EmailTempCode = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            EmailTempCodeExpired = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            SmsTempCode = table.Column<int>(type: "int", nullable: true),
        //            SmsTempCodeExpired = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ResetPending = table.Column<bool>(type: "bit", nullable: false),
        //            ResetPasswordFailCount = table.Column<int>(type: "int", nullable: false),
        //            ResetPasswordStep = table.Column<int>(type: "int", nullable: false),
        //            ApplicationUserTypeId = table.Column<int>(type: "int", nullable: false),
        //            ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Identifier = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            OracleCustomerId = table.Column<string>(type: "VARCHAR(50)", nullable: true),
        //            ActiveOracleLeaseId = table.Column<long>(type: "bigint", nullable: true),
        //            ActiveOracleLeaseNum = table.Column<string>(type: "VARCHAR(50)", nullable: true),
        //            LocationCode = table.Column<string>(type: "VARCHAR(50)", nullable: true),
        //            Firstname = table.Column<string>(type: "VARCHAR(256)", nullable: true),
        //            Lastname = table.Column<string>(type: "VARCHAR(256)", nullable: true),
        //            OracleBuildingLocationId = table.Column<int>(type: "int", nullable: true),
        //            AccountBalance = table.Column<float>(type: "real", nullable: false),
        //            AccountNumber = table.Column<long>(type: "bigint", nullable: false),
        //            ResetCode = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            ResetCodeExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            NotificationToken = table.Column<string>(type: "VARCHAR(8000)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            TenantID = table.Column<int>(type: "int", nullable: true),
        //            CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PlayerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            BuildingID = table.Column<long>(type: "bigint", nullable: true),
        //            FloorID = table.Column<long>(type: "bigint", nullable: true),
        //            RoomID = table.Column<long>(type: "bigint", nullable: true),
        //            CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Institution = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            WifiToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MiFiUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            CustomerID = table.Column<long>(type: "bigint", nullable: false),
        //            KeyOTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PackageOTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OccupationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
        //            EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
        //            TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
        //            LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
        //            LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
        //            AccessFailedCount = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUsers", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AspNetUsers_Buildings_BuildingID",
        //                column: x => x.BuildingID,
        //                principalTable: "Buildings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OnboardingSegments",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Segment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
        //            BuildingId = table.Column<long>(type: "bigint", nullable: true),
        //            FloorId = table.Column<long>(type: "bigint", nullable: true),
        //            LeaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            PreOnboardingDays = table.Column<int>(type: "int", nullable: false),
        //            OnboardingStart = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            OnboardingEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OnboardingSegments", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_OnboardingSegments_Buildings_BuildingId",
        //                column: x => x.BuildingId,
        //                principalTable: "Buildings",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_OnboardingSegments_Floors_FloorId",
        //                column: x => x.FloorId,
        //                principalTable: "Floors",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_OnboardingSegments_Regions_RegionId",
        //                column: x => x.RegionId,
        //                principalTable: "Regions",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AppSync",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            LastSync = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AppSync", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AppSync_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetRoleClaims",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ApplicationRoleId = table.Column<int>(type: "int", nullable: true),
        //            ApplicationUserId = table.Column<int>(type: "int", nullable: true),
        //            RoleId = table.Column<int>(type: "int", nullable: false),
        //            ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AspNetRoleClaims_AspNetRoles_ApplicationRoleId",
        //                column: x => x.ApplicationRoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_AspNetRoleClaims_AspNetUsers_ApplicationUserId",
        //                column: x => x.ApplicationUserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserClaims",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserLogins",
        //        columns: table => new
        //        {
        //            LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
        //            ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
        //            ApplicationUserId = table.Column<int>(type: "int", nullable: true),
        //            ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserId = table.Column<int>(type: "int", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserLogins_AspNetUsers_ApplicationUserId",
        //                column: x => x.ApplicationUserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserRoles",
        //        columns: table => new
        //        {
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            RoleId = table.Column<int>(type: "int", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ApplicationRoleId = table.Column<int>(type: "int", nullable: true),
        //            ApplicationUserId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetRoles_ApplicationRoleId",
        //                column: x => x.ApplicationRoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
        //                column: x => x.ApplicationUserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserTokens",
        //        columns: table => new
        //        {
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
        //            Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
        //            Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CommercialQueries",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Region = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Building = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Floor = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Shop = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Company = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Fullname = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            MobileNumber = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Email = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            RequestType = table.Column<string>(type: "VARCHAR(250)", nullable: true),
        //            Category = table.Column<int>(type: "int", nullable: true),
        //            IsResolved = table.Column<bool>(type: "bit", nullable: false),
        //            Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TenantID = table.Column<int>(type: "int", nullable: true),
        //            RequestID = table.Column<int>(type: "int", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CommercialQueries", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_CommercialQueries_AspNetUsers_TenantID",
        //                column: x => x.TenantID,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Employees",
        //        columns: table => new
        //        {
        //            EmployeeId = table.Column<int>(type: "int", nullable: false),
        //            SupervisorId = table.Column<int>(type: "int", nullable: true),
        //            DisciplineId = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            LastSyncDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            RegionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Employees", x => x.EmployeeId);
        //            table.ForeignKey(
        //                name: "FK_Employees_AspNetUsers_EmployeeId",
        //                column: x => x.EmployeeId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Employees_Disciplines_DisciplineId",
        //                column: x => x.DisciplineId,
        //                principalTable: "Disciplines",
        //                principalColumn: "DisciplineId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Employees_Employees_SupervisorId",
        //                column: x => x.SupervisorId,
        //                principalTable: "Employees",
        //                principalColumn: "EmployeeId",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Onboardings",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            KeyIssued = table.Column<bool>(type: "bit", nullable: false),
        //            ChecklistComplete = table.Column<bool>(type: "bit", nullable: false),
        //            PackageIssued = table.Column<bool>(type: "bit", nullable: false),
        //            ManualCompletion = table.Column<bool>(type: "bit", nullable: false),
        //            NotifiedKey = table.Column<bool>(type: "bit", nullable: false),
        //            NotifiedPackage = table.Column<bool>(type: "bit", nullable: false),
        //            WifiTokenIssued = table.Column<bool>(type: "bit", nullable: false),
        //            WifiTokenNotified = table.Column<bool>(type: "bit", nullable: false),
        //            IsComplete = table.Column<bool>(type: "bit", nullable: false),
        //            LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            LaundryCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsSpecialCase = table.Column<bool>(type: "bit", nullable: false),
        //            LeaseId = table.Column<long>(type: "bigint", nullable: true),
        //            KeyCode = table.Column<string>(type: "VARCHAR(300)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Onboardings", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Onboardings_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Segments",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IsNational = table.Column<bool>(type: "bit", nullable: false),
        //            Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Building = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Players = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            TemplateMessageId = table.Column<int>(type: "int", nullable: true),
        //            Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Segments", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Segments_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Segments_TemplateMessages_TemplateMessageId",
        //                column: x => x.TemplateMessageId,
        //                principalTable: "TemplateMessages",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TenantKeys",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            TenantId = table.Column<int>(type: "int", nullable: false),
        //            RoomId = table.Column<long>(type: "bigint", nullable: false),
        //            KeyLost = table.Column<bool>(type: "bit", nullable: false),
        //            KeyReturned = table.Column<bool>(type: "bit", nullable: false),
        //            Period = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ReplacementKeyId = table.Column<int>(type: "int", nullable: true),
        //            KeyCode = table.Column<string>(type: "VARCHAR(300)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TenantKeys", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_TenantKeys_AspNetUsers_TenantId",
        //                column: x => x.TenantId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_TenantKeys_Rooms_RoomId",
        //                column: x => x.RoomId,
        //                principalTable: "Rooms",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_TenantKeys_TenantKeys_ReplacementKeyId",
        //                column: x => x.ReplacementKeyId,
        //                principalTable: "TenantKeys",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "UserResponses",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            QuestionId = table.Column<int>(type: "int", nullable: false),
        //            DescriptorNumber = table.Column<int>(type: "int", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_UserResponses", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_UserResponses_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_UserResponses_Question_QuestionId",
        //                column: x => x.QuestionId,
        //                principalTable: "Question",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "QueryResponses",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            QueryID = table.Column<int>(type: "int", nullable: false),
        //            RespondentID = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_QueryResponses", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_QueryResponses_Employees_RespondentID",
        //                column: x => x.RespondentID,
        //                principalTable: "Employees",
        //                principalColumn: "EmployeeId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_QueryResponses_Queries_QueryID",
        //                column: x => x.QueryID,
        //                principalTable: "Queries",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Checklists",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            TenantId = table.Column<int>(type: "int", nullable: true),
        //            Assigned = table.Column<int>(type: "int", nullable: true),
        //            StateId = table.Column<int>(type: "int", nullable: true),
        //            RoomId = table.Column<long>(type: "bigint", nullable: true),
        //            IsArchived = table.Column<bool>(type: "bit", nullable: false),
        //            ManualCompletion = table.Column<bool>(type: "bit", nullable: false),
        //            OnboardingId = table.Column<int>(type: "int", nullable: true),
        //            ChecklistType = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Checklists", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Checklists_AspNetUsers_Assigned",
        //                column: x => x.Assigned,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Checklists_AspNetUsers_TenantId",
        //                column: x => x.TenantId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Checklists_ChecklistStates_StateId",
        //                column: x => x.StateId,
        //                principalTable: "ChecklistStates",
        //                principalColumn: "ChecklistStateId",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Checklists_Onboardings_OnboardingId",
        //                column: x => x.OnboardingId,
        //                principalTable: "Onboardings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "EmergencyIntake",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            UserId = table.Column<int>(type: "int", nullable: false),
        //            CompletedCleaningQuestionaire = table.Column<bool>(type: "bit", nullable: true),
        //            CompletedScreeningQuestionaire = table.Column<bool>(type: "bit", nullable: true),
        //            AcceptedTermsConditions = table.Column<bool>(type: "bit", nullable: true),
        //            PassedScreening = table.Column<bool>(type: "bit", nullable: true),
        //            ApplicationDenied = table.Column<bool>(type: "bit", nullable: false),
        //            ApplicationDeniedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            AccountCleared = table.Column<bool>(type: "bit", nullable: false),
        //            AccountClearedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            FacilitiesCleared = table.Column<bool>(type: "bit", nullable: false),
        //            HealthCheckCleared = table.Column<bool>(type: "bit", nullable: true),
        //            FacilitiesClearedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ScreeningQuestionaireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ScreeningQuestionaireAcceptedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ScheduledReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ActualReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            POPUploadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            ScreeningApproverId = table.Column<int>(type: "int", nullable: true),
        //            BalanceApproverId = table.Column<int>(type: "int", nullable: true),
        //            ReturnDateSchedularId = table.Column<int>(type: "int", nullable: true),
        //            ReturnOTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            MedicalCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            ProofOfPayment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            InstitutionLetterNA = table.Column<bool>(type: "bit", nullable: false),
        //            BiometricUnsuspended = table.Column<bool>(type: "bit", nullable: false),
        //            ExpirationNotication = table.Column<bool>(type: "bit", nullable: false),
        //            POPDeclined = table.Column<bool>(type: "bit", nullable: false),
        //            MaskIssued = table.Column<bool>(type: "bit", nullable: false),
        //            ReturnLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            SPLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            OnboardingId = table.Column<int>(type: "int", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_EmergencyIntake", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_EmergencyIntake_AspNetUsers_BalanceApproverId",
        //                column: x => x.BalanceApproverId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_EmergencyIntake_AspNetUsers_ReturnDateSchedularId",
        //                column: x => x.ReturnDateSchedularId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_EmergencyIntake_AspNetUsers_ScreeningApproverId",
        //                column: x => x.ScreeningApproverId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_EmergencyIntake_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_EmergencyIntake_Onboardings_OnboardingId",
        //                column: x => x.OnboardingId,
        //                principalTable: "Onboardings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OnboardingNotes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            UserId = table.Column<int>(type: "int", nullable: true),
        //            OnboardingId = table.Column<int>(type: "int", nullable: false),
        //            Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OnboardingNotes", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_OnboardingNotes_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_OnboardingNotes_Onboardings_OnboardingId",
        //                column: x => x.OnboardingId,
        //                principalTable: "Onboardings",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Notifications",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            UserID = table.Column<int>(type: "int", nullable: true),
        //            Priority = table.Column<int>(type: "int", nullable: true),
        //            SourceID = table.Column<int>(type: "int", nullable: true),
        //            Global = table.Column<bool>(type: "bit", nullable: false),
        //            IsSegmented = table.Column<bool>(type: "bit", nullable: false),
        //            SourceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Unread = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            Created = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            SegmentId = table.Column<int>(type: "int", nullable: true),
        //            TemplateMessageId = table.Column<int>(type: "int", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Notifications", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_Notifications_AspNetUsers_UserID",
        //                column: x => x.UserID,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Notifications_Segments_SegmentId",
        //                column: x => x.SegmentId,
        //                principalTable: "Segments",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Notifications_TemplateMessages_TemplateMessageId",
        //                column: x => x.TemplateMessageId,
        //                principalTable: "TemplateMessages",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ChecklistProblems",
        //        columns: table => new
        //        {
        //            ID = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            ChecklistId = table.Column<int>(type: "int", nullable: false),
        //            ChecklistQuestionId = table.Column<int>(type: "int", nullable: false),
        //            ChecklistLocationId = table.Column<int>(type: "int", nullable: false),
        //            RequestId = table.Column<int>(type: "int", nullable: true),
        //            IsChecked = table.Column<bool>(type: "bit", nullable: false),
        //            TenantComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            EmployeeComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            IsDeleted = table.Column<bool>(type: "bit", nullable: false),
        //            IsDeclined = table.Column<bool>(type: "bit", nullable: true),
        //            DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
        //            DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ChecklistProblems", x => x.ID);
        //            table.ForeignKey(
        //                name: "FK_ChecklistProblems_ChecklistLocations_ChecklistLocationId",
        //                column: x => x.ChecklistLocationId,
        //                principalTable: "ChecklistLocations",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ChecklistProblems_ChecklistQuestions_ChecklistQuestionId",
        //                column: x => x.ChecklistQuestionId,
        //                principalTable: "ChecklistQuestions",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_ChecklistProblems_Checklists_ChecklistId",
        //                column: x => x.ChecklistId,
        //                principalTable: "Checklists",
        //                principalColumn: "ID",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_APIDeal_APIContactid",
        //        table: "APIDeal",
        //        column: "APIContactid");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_APIForeignUsers_APITaskid",
        //        table: "APIForeignUsers",
        //        column: "APITaskid");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_APILeads_custom_fieldAPICustomFieldId",
        //        table: "APILeads",
        //        column: "custom_fieldAPICustomFieldId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AppSync_UserId",
        //        table: "AppSync",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_ApplicationRoleId",
        //        table: "AspNetRoleClaims",
        //        column: "ApplicationRoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_ApplicationUserId",
        //        table: "AspNetRoleClaims",
        //        column: "ApplicationUserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_RoleId",
        //        table: "AspNetRoleClaims",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "RoleNameIndex",
        //        table: "AspNetRoles",
        //        column: "NormalizedName",
        //        unique: true,
        //        filter: "[NormalizedName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserClaims_UserId",
        //        table: "AspNetUserClaims",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_ApplicationUserId",
        //        table: "AspNetUserLogins",
        //        column: "ApplicationUserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_UserId",
        //        table: "AspNetUserLogins",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_ApplicationRoleId",
        //        table: "AspNetUserRoles",
        //        column: "ApplicationRoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_ApplicationUserId",
        //        table: "AspNetUserRoles",
        //        column: "ApplicationUserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_RoleId",
        //        table: "AspNetUserRoles",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "EmailIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedEmail");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUsers_BuildingID",
        //        table: "AspNetUsers",
        //        column: "BuildingID");

        //    migrationBuilder.CreateIndex(
        //        name: "UserNameIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedUserName",
        //        unique: true,
        //        filter: "[NormalizedUserName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Buildings_RegionId",
        //        table: "Buildings",
        //        column: "RegionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ChecklistProblems_ChecklistId",
        //        table: "ChecklistProblems",
        //        column: "ChecklistId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ChecklistProblems_ChecklistLocationId",
        //        table: "ChecklistProblems",
        //        column: "ChecklistLocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ChecklistProblems_ChecklistQuestionId",
        //        table: "ChecklistProblems",
        //        column: "ChecklistQuestionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Checklists_Assigned",
        //        table: "Checklists",
        //        column: "Assigned");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Checklists_OnboardingId",
        //        table: "Checklists",
        //        column: "OnboardingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Checklists_StateId",
        //        table: "Checklists",
        //        column: "StateId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Checklists_TenantId",
        //        table: "Checklists",
        //        column: "TenantId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CommercialQueries_TenantID",
        //        table: "CommercialQueries",
        //        column: "TenantID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CommonAreas_FloorID",
        //        table: "CommonAreas",
        //        column: "FloorID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DSPageRolePermissions_DSPageId",
        //        table: "DSPageRolePermissions",
        //        column: "DSPageId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DSPageRolePermissions_DSPermissionTypeId",
        //        table: "DSPageRolePermissions",
        //        column: "DSPermissionTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DSPageRolePermissions_RoleId",
        //        table: "DSPageRolePermissions",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EmergencyIntake_BalanceApproverId",
        //        table: "EmergencyIntake",
        //        column: "BalanceApproverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EmergencyIntake_OnboardingId",
        //        table: "EmergencyIntake",
        //        column: "OnboardingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EmergencyIntake_ReturnDateSchedularId",
        //        table: "EmergencyIntake",
        //        column: "ReturnDateSchedularId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EmergencyIntake_ScreeningApproverId",
        //        table: "EmergencyIntake",
        //        column: "ScreeningApproverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_EmergencyIntake_UserId",
        //        table: "EmergencyIntake",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Employees_DisciplineId",
        //        table: "Employees",
        //        column: "DisciplineId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Employees_SupervisorId",
        //        table: "Employees",
        //        column: "SupervisorId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Locations_RegionId",
        //        table: "Locations",
        //        column: "RegionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Notifications_SegmentId",
        //        table: "Notifications",
        //        column: "SegmentId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Notifications_TemplateMessageId",
        //        table: "Notifications",
        //        column: "TemplateMessageId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Notifications_UserID",
        //        table: "Notifications",
        //        column: "UserID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnboardingNotes_OnboardingId",
        //        table: "OnboardingNotes",
        //        column: "OnboardingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnboardingNotes_UserId",
        //        table: "OnboardingNotes",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Onboardings_UserId",
        //        table: "Onboardings",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnboardingSegments_BuildingId",
        //        table: "OnboardingSegments",
        //        column: "BuildingId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnboardingSegments_FloorId",
        //        table: "OnboardingSegments",
        //        column: "FloorId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_OnboardingSegments_RegionId",
        //        table: "OnboardingSegments",
        //        column: "RegionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_QueryResponses_QueryID",
        //        table: "QueryResponses",
        //        column: "QueryID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_QueryResponses_RespondentID",
        //        table: "QueryResponses",
        //        column: "RespondentID");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SectionQustions_QuestionId",
        //        table: "SectionQustions",
        //        column: "QuestionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SectionQustions_SectionId",
        //        table: "SectionQustions",
        //        column: "SectionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Segments_TemplateMessageId",
        //        table: "Segments",
        //        column: "TemplateMessageId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Segments_UserId",
        //        table: "Segments",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TenantKeys_ReplacementKeyId",
        //        table: "TenantKeys",
        //        column: "ReplacementKeyId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TenantKeys_RoomId",
        //        table: "TenantKeys",
        //        column: "RoomId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TenantKeys_TenantId",
        //        table: "TenantKeys",
        //        column: "TenantId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_UserResponses_QuestionId",
        //        table: "UserResponses",
        //        column: "QuestionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_UserResponses_UserId",
        //        table: "UserResponses",
        //        column: "UserId");
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "APIDeal");

        //    migrationBuilder.DropTable(
        //        name: "APIForeignUsers");

        //    migrationBuilder.DropTable(
        //        name: "ApiOutcomes");

        //    migrationBuilder.DropTable(
        //        name: "APIUsers");

        //    migrationBuilder.DropTable(
        //        name: "Apps");

        //    migrationBuilder.DropTable(
        //        name: "AppSync");

        //    migrationBuilder.DropTable(
        //        name: "AppVersions");

        //    migrationBuilder.DropTable(
        //        name: "AspNetRoleClaims");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserClaims");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserLogins");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserRoles");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserTokens");

        //    migrationBuilder.DropTable(
        //        name: "AuditHistory");

        //    migrationBuilder.DropTable(
        //        name: "Categories");

        //    migrationBuilder.DropTable(
        //        name: "ChecklistProblems");

        //    migrationBuilder.DropTable(
        //        name: "ChecklistTemplates");

        //    migrationBuilder.DropTable(
        //        name: "Comments");

        //    migrationBuilder.DropTable(
        //        name: "CommercialQueries");

        //    migrationBuilder.DropTable(
        //        name: "CommonAreas");

        //    migrationBuilder.DropTable(
        //        name: "DSPageRolePermissions");

        //    migrationBuilder.DropTable(
        //        name: "EmergencyIntake");

        //    migrationBuilder.DropTable(
        //        name: "EmployeeBuildings");

        //    migrationBuilder.DropTable(
        //        name: "FailedJobErrors");

        //    migrationBuilder.DropTable(
        //        name: "FailedJobs");

        //    migrationBuilder.DropTable(
        //        name: "FreshData");

        //    migrationBuilder.DropTable(
        //        name: "ImportJobErrors");

        //    migrationBuilder.DropTable(
        //        name: "ImportJobs");

        //    migrationBuilder.DropTable(
        //        name: "Locations");

        //    migrationBuilder.DropTable(
        //        name: "Notifications");

        //    migrationBuilder.DropTable(
        //        name: "OnboardingNotes");

        //    migrationBuilder.DropTable(
        //        name: "OnboardingSegments");

        //    migrationBuilder.DropTable(
        //        name: "PublicHolidays");

        //    migrationBuilder.DropTable(
        //        name: "QueryResponses");

        //    migrationBuilder.DropTable(
        //        name: "RequestAudits");

        //    migrationBuilder.DropTable(
        //        name: "RequestCommentImages");

        //    migrationBuilder.DropTable(
        //        name: "RequestImages");

        //    migrationBuilder.DropTable(
        //        name: "Requests");

        //    migrationBuilder.DropTable(
        //        name: "RoleDefinedStatuses");

        //    migrationBuilder.DropTable(
        //        name: "SectionQustions");

        //    migrationBuilder.DropTable(
        //        name: "ServiceLevelAgreements");

        //    migrationBuilder.DropTable(
        //        name: "ShortUrls");

        //    migrationBuilder.DropTable(
        //        name: "SouthPointHolidays");

        //    migrationBuilder.DropTable(
        //        name: "StateDefinedStatuses");

        //    migrationBuilder.DropTable(
        //        name: "Statuses");

        //    migrationBuilder.DropTable(
        //        name: "SubCategories");

        //    migrationBuilder.DropTable(
        //        name: "TenantKeys");

        //    migrationBuilder.DropTable(
        //        name: "Tenants");

        //    migrationBuilder.DropTable(
        //        name: "UserResponses");

        //    migrationBuilder.DropTable(
        //        name: "APILeads");

        //    migrationBuilder.DropTable(
        //        name: "APITasks");

        //    migrationBuilder.DropTable(
        //        name: "ChecklistLocations");

        //    migrationBuilder.DropTable(
        //        name: "ChecklistQuestions");

        //    migrationBuilder.DropTable(
        //        name: "Checklists");

        //    migrationBuilder.DropTable(
        //        name: "AspNetRoles");

        //    migrationBuilder.DropTable(
        //        name: "DSPage");

        //    migrationBuilder.DropTable(
        //        name: "DSPermissionTypes");

        //    migrationBuilder.DropTable(
        //        name: "Segments");

        //    migrationBuilder.DropTable(
        //        name: "Floors");

        //    migrationBuilder.DropTable(
        //        name: "Employees");

        //    migrationBuilder.DropTable(
        //        name: "Queries");

        //    migrationBuilder.DropTable(
        //        name: "Sections");

        //    migrationBuilder.DropTable(
        //        name: "Rooms");

        //    migrationBuilder.DropTable(
        //        name: "Question");

        //    migrationBuilder.DropTable(
        //        name: "APICustomField");

        //    migrationBuilder.DropTable(
        //        name: "ChecklistStates");

        //    migrationBuilder.DropTable(
        //        name: "Onboardings");

        //    migrationBuilder.DropTable(
        //        name: "TemplateMessages");

        //    migrationBuilder.DropTable(
        //        name: "Disciplines");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUsers");

        //    migrationBuilder.DropTable(
        //        name: "Buildings");

        //    migrationBuilder.DropTable(
        //        name: "Regions");
        //}
    }
}
