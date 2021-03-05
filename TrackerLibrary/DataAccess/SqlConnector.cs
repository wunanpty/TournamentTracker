using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";

        public void CompleteTournament(TournamentModel model)
        {
            
             //* using () 
             //* {
             //*      var p = new DynamicParameters();
             //*      p.add("@id", model.Id);
             //*      
             //*      connection.Execute("dbo.spTournaments_Complete", p, commandType: CommandType.StoredProcedure);
             //* }
             
            return;
        }


        public void CreatePerson(PersonModel model)
        {
            //same implementation as CreatePrize
            //...
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

            }
            
        }

        //TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model">The prize infomation.</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public void CreatePrize(PrizeModel model)
        {
            //What is the purpose of the Using block in C#?
            //If the type implements IDisposable, it automatically disposes that type.
            //Using calls Dispose() after the using-block is left, even if the code throws an exception.
            //So you usually use using for classes that require cleaning up after them, like IO.
            //the using statement tells .NET to release the object specified in the using block once it is no longer needed
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

            }

        }

        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                /*
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", model.Id);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
                */
              
            }
           
        }

        public void CreateTournament(TournamentModel model)
        {
            //using () {}
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                //saveTournament(connection, model);
                //SaveTournamentPrizes(connection, model);
                //SaveTournamentEntries(connection, model);
                //SaveTournamentRounds(connetion, model);
                //TournementLogitc.UpdateTournamentResults(model);
            }
        }



        public List<PersonModel> GetPerson_All()
        {
            //using () {}
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

            }
            return new List<PersonModel>();
        }

        public List<TeamModel> GetTeam_All()
        {
            //using () {}
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

            }
            return new List<TeamModel>();
        }

        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output = new List<TournamentModel>();

            ////using () {}
            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            //{
            //    output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

            //    // Populate prizes

            //    // Populate Teams

            //    // Populate Rounds
                    // Populate each entry (2 models)
                    // Populate each matchup (1 model)
            //}

            return output;
        }

        public void UpdateMatchup(MatchupModel model)
        {
            // Store matchup
            // Store matchup entries
            return;
        }
    }
}
