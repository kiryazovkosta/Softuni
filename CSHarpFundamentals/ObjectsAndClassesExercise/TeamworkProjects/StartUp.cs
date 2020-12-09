using System;

namespace TeamworkProjects
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class User
    {
        public User(string userName)
        {
            this.Name = userName;
        }

        public string Name { get; private set; }
    }

    public class Team
    {
        public Team(string name, User creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<User>();
        }

        public string Name { get; private set; }
        public User Creator { get; private set; }
        public IList<User> Members { get; private set; }

        public void AddMember(User user)
        {
            this.Members.Add(user);
        }

        public IList<string> MemberList()
        {
            var names = this.Members.Select(m => m.Name).ToList();
            names.Sort();
            return names;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine(this.Name);
            output.AppendLine($"- {this.Creator.Name}");
            for (int memberIndex = 0; memberIndex < this.MemberList().Count; memberIndex++)
            {
                if (this.Members[memberIndex].Name != this.Creator.Name)
                {
                    if (memberIndex == this.Members.Count - 1)
                    {
                        output.Append($"-- {this.Members[memberIndex].Name}");
                    }
                    else
                    {
                        output.AppendLine($"-- {this.Members[memberIndex].Name}");
                    }
                }
            }

            return output.ToString();
        }
    }
    public class StartUp
    {
        public static void Main()
        {
            var teamsCount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var teams = CreateTeams(teamsCount);
            SetMembers(teams);
            var populatedTeams = GetPopulatedTeams(teams).ToList();
            if (populatedTeams.Any())
            {
                foreach (var team in populatedTeams)
                {
                    Console.WriteLine(team);
                }
            }

            var disbandTeams = GetDisbandTeams(teams).ToList();
            Console.WriteLine("Teams to disband:");
            if (disbandTeams.Any())
            {
                foreach (var team in disbandTeams)
                {
                    Console.WriteLine(team.Name);
                }
            }

        }

        private static IEnumerable<Team> GetDisbandTeams(List<Team> teams)
        {
            var disbandTeams = teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name).ToList();
            return disbandTeams;
        }

        private static IEnumerable<Team> GetPopulatedTeams(List<Team> teams)
        {
            var populatedTeams = teams.Where(t => t.Members.Count >= 1).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name).ToList();
            return populatedTeams;
        }

        private static void SetMembers(List<Team> teams)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                var memberData = input?.Split("->") ?? new string[] { };
                if (memberData.Length == 2)
                {
                    var userName = memberData[0];
                    var teamName = memberData[1];
                    if (!TeamExists(teams, teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                        continue;
                    }

                    if (IsAlreadyAMember(teams, userName) || IsAlreadyCreator(teams, userName))
                    {
                        Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                        continue;
                    }

                    var team = GetTeam(teams, teamName);
                    team.AddMember(new User(userName));
                }
            }
        }

        private static List<Team> CreateTeams(int teamsCount)
        {
            var teams = new List<Team>();
            for (int teamIndex = 0; teamIndex < teamsCount; teamIndex++)
            {
                var teamData = Console.ReadLine()?.Split("-") ?? new string[] { };
                if (teamData.Length == 2)
                {
                    var user = new User(teamData[0]);
                    var teamName = teamData[1];

                    if (TeamExists(teams, teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        continue;
                    }

                    if (IsAlreadyCreator(teams, user.Name))
                    {
                        Console.WriteLine($"{user.Name} cannot create another team!");
                        continue;
                    }

                    var team = new Team(teamName, user);
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {user.Name}!");
                }
            }

            return teams;
        }

        private static bool TeamExists(IEnumerable<Team> teams, string teamName)
        {
            return teams.Any(t => t.Name == teamName);
        }

        private static bool IsAlreadyCreator(IEnumerable<Team> teams, string userName)
        {
            return teams.Any(t => t.Creator.Name == userName);
        }

        private static bool IsAlreadyAMember(IEnumerable<Team> teams, string userName)
        {
            return teams.Any(t => t.Members.Any(m => m.Name == userName));
        }

        private static Team GetTeam(IEnumerable<Team> teams, string name)
        {
            return teams.FirstOrDefault(t => t.Name == name);
        }
    }
}
