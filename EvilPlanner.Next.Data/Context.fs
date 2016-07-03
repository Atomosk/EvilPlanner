namespace EvilPlanner.Next.Data

open Microsoft.EntityFrameworkCore

type EvilPlannerContext() =
    inherit DbContext()

    member val Quotations : DbSet<Quotation> = null with get, set

    override __.OnConfiguring optionsBuilder =
        optionsBuilder.UseSqlite "Filename=./evil-planner.db" |> ignore
