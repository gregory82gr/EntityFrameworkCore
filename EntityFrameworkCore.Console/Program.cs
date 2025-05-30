using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;

// using EntityFrameworkCore.Domain;
using var context =new FootballLeageDbContext();
//await context.Database.MigrateAsync();

//var newCoach = new Coach
//{
//    Name = "Jose Mourinho",
//    CreatedDate = DateTime.Now
//};

//var newCoach1 = new Coach
//{
//    Name = "Theodore Whitmore",
//    CreatedDate = DateTime.Now
//};

//var newCoach2 = new Coach
//{
//    Name = "pep Guardiola",
//    CreatedDate = DateTime.Now
//};
//await context.Coaches.AddAsync(newCoach2);
//await context.SaveChangesAsync();

//List<Coach> coaches = new List<Coach>
//{
//    newCoach,
//    newCoach1
//};

//await context.Coaches.AddRangeAsync(coaches);
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//await context.SaveChangesAsync();
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//var coach = await context.Coaches.FindAsync(2);
//coach.Name = "Trevoir Williams";
//coach.CreatedDate = DateTime.Now;
//await context.SaveChangesAsync();

//var coach1 = await context.Coaches
//    .AsNoTracking()
//    .FirstOrDefaultAsync(x => x.Id == 3);
//coach1.Name = "Testing no tracking behavior";

//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
////context.Update(coach1);
//context.Entry(coach1).State = EntityState.Modified;
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);
//await context.SaveChangesAsync();
//Console.WriteLine(context.ChangeTracker.DebugView.LongView);

//var coach= await context.Coaches.FindAsync(4);
//context.Entry(coach).State = EntityState.Deleted;
//await context.SaveChangesAsync();

//Related data
//var match=new Match
//{
//    Date = new  DateTime(2023,10,1),
//    TicketPrice = 20,
//    HomeTeamId = 2,
//    AwayTeamId = 1,
//    HomeTeamScore=0,
//    AwayTeamScore = 0

//};

//await context.AddAsync(match);
//await context.SaveChangesAsync();

//var match1 = new Match
//{
//    Date = new DateTime(2023, 10, 1),
//    TicketPrice = 20,
//    HomeTeamId = 0,
//    AwayTeamId = 10,
//    HomeTeamScore = 0,
//    AwayTeamScore = 0

//};

//await context.AddAsync(match1);
//await context.SaveChangesAsync();

//Insert parent/child relationship

//var team = new Team
//{
//    Name = "Manchester United",
//    Coach= new Coach
//    {
//        Name = "Jose Mourinho",

//    }
//};

//await context.AddAsync(team);
//await context.SaveChangesAsync();

//Insert parent with children
var league = new League
{
    Name = "La liga",
    Teams = new List<Team>
    {
        new Team
        {
            Name = "Real Madrid",
            Coach = new Coach
            {
                Name = "Real Coach",
            }
        },
        new Team
        {
            Name = "Barcelona",
            Coach = new Coach
            {
                Name = "Barcelona Coach",
            }
        },
         new Team
        {
            Name = "Atletiko",
            Coach = new Coach
            {
                Name = "Atletiko Coach",
            }
        }
    }
};

await context.AddAsync(league);
await context.SaveChangesAsync();