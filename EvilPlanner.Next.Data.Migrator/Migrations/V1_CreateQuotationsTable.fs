namespace EvilPlanner.Next.Data.Migrator.Migrations

open FluentMigrator

[<Migration(1L)>]
type V1_CreateQuotationsTable() =
    inherit Migration()

    override this.Up () =
        this.Create.Table("Quotations") |> ignore

    override this.Down() =
        this.Delete.Table("Quotations") |> ignore
