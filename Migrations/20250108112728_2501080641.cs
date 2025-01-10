using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Donate.Migrations
{
    /// <inheritdoc />
    public partial class _2501080641 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
            DROP VIEW IF EXISTS public."ViewDonationItems";

            CREATE OR REPLACE VIEW public."ViewDonationItems"
             AS
             SELECT "Id",
                "ProjectId",
                "ItemTypeId",
                "ItemName",
                "Price",
                ( SELECT dit."Name"
                       FROM "DonationItemTypes" dit
                      WHERE di."ItemTypeId" = dit."Id") AS "ItemType",
                ( SELECT p."Title"
                       FROM "Projects" p
                      WHERE di."ProjectId" = p."Id") AS "Project",
                "Active"
               FROM "DonationItems" di;

            ALTER TABLE public."ViewDonationItems"
                OWNER TO postgres;
            """);

            migrationBuilder.Sql("""

            DROP VIEW IF EXISTS public."ViewProjectTasks";

            CREATE OR REPLACE VIEW public."ViewProjectTasks"
             AS
             SELECT "Id",
                "ProjectId",
                "WantedCount",
                "Description",
                "Date",
                "Status",
                "Active",
                ( SELECT p."Title"
                       FROM "Projects" p
                      WHERE p."Id" = t."ProjectId") AS "Project",
                ( SELECT count(ta."Id") AS count
                       FROM "TaskApplications" ta
                      WHERE ta."ProjectTaskId" = t."Id" AND ta."Status" = 0) AS "ApplicationCount",
                ( SELECT count(vpt."ProjectTaskId") AS count
                       FROM "VolunteerProjectTasks" vpt
                      WHERE vpt."ProjectTaskId" = t."Id") AS "ApprovedApplicationCount",
                ( SELECT string_agg(ta."VolunteerId"::text, ', '::text) AS string_agg
                       FROM "TaskApplications" ta
                      WHERE ta."ProjectTaskId" = t."Id") AS "VolunteerIds"
               FROM "Tasks" t;

            ALTER TABLE public."ViewProjectTasks"
                OWNER TO postgres;

            
            """);
            migrationBuilder.Sql(""""
            DROP VIEW IF EXISTS public."ViewProjects";

            CREATE OR REPLACE VIEW public."ViewProjects"
             AS
             SELECT p."Id",
                p."OrganizationId",
                p."Title",
                p."Description",
                p."StartDate",
                p."EndDate",
                p."Active",
                p."AppUserId",
                p."Status",
                u."Name" AS "Organization"
               FROM "Projects" p
                 JOIN "Users" u ON u."Id" = p."OrganizationId";

            ALTER TABLE public."ViewProjects"
                OWNER TO postgres;
            """");

            migrationBuilder.Sql("""
                DROP VIEW IF EXISTS public."ViewUsers";

                CREATE OR REPLACE VIEW public."ViewUsers"
                 AS
                 SELECT u."Id",
                    u."UserName",
                    u."NormalizedUserName",
                    u."Email",
                    u."NormalizedEmail",
                    u."EmailConfirmed",
                    u."PasswordHash",
                    u."SecurityStamp",
                    u."ConcurrencyStamp",
                    u."PhoneNumber",
                    u."PhoneNumberConfirmed",
                    u."TwoFactorEnabled",
                    u."LockoutEnd",
                    u."LockoutEnabled",
                    u."AccessFailedCount",
                    u."Active",
                    u."Address",
                    u."CreatedAt",
                    u."Name",
                    r."Name" AS "Role"
                   FROM "Users" u
                     JOIN "UserRoles" ur ON u."Id" = ur."UserId"
                     JOIN "Roles" r ON r."Id" = ur."RoleId";

                ALTER TABLE public."ViewUsers"
                    OWNER TO postgres;
                """);

            migrationBuilder.Sql("""
                DROP FUNCTION IF EXISTS public.delete_rejected_applications();

                CREATE OR REPLACE FUNCTION public.delete_rejected_applications()
                    RETURNS trigger
                    LANGUAGE 'plpgsql'
                    COST 100
                    VOLATILE NOT LEAKPROOF
                AS $BODY$
                BEGIN
                    IF OLD."Status" = 0 AND NEW."Status" > 0 THEN
                        DELETE FROM public."TaskApplications" WHERE "Id" = NEW."Id";
                    END IF;
                    RETURN NULL; 
                END;
                $BODY$;

                ALTER FUNCTION public.delete_rejected_applications()
                    OWNER TO postgres;
                
                """);


            migrationBuilder.Sql("""
                DROP TRIGGER IF EXISTS trigger_delete_rejected_applications ON public."TaskApplications";

                CREATE OR REPLACE TRIGGER trigger_delete_rejected_applications
                    AFTER UPDATE OF "Status"
                    ON public."TaskApplications"
                    FOR EACH ROW
                    WHEN (new."Status" > 0)
                    EXECUTE FUNCTION public.delete_rejected_applications();
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
