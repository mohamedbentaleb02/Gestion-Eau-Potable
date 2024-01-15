using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFE
{
    public class DataAccess
    {
        private static SqlConnection conn;
        
        //Constructor
        public DataAccess()
        {
            string sql = Helper.cnnString("appEau");
            conn = new SqlConnection(sql);
        }

        public SqlDataReader queryExecuteReader(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void queryExecuteNonQuery(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader loadClients()
        {
            string sqlQuery = "SELECT * FROM adherent";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader searchClient(string motCle)
        {
            string sqlQuery = "SELECT * FROM adherent WHERE prenom LIKE '%" + motCle + "%' OR nom LIKE '%" + motCle + "%' OR CIN LIKE '%" + motCle + "%' OR nbr_police LIKE '%" + motCle + "%' OR phone LIKE '%" + motCle + "%'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getClientConsommation(string id)
        {
            string sqlQuery = "select c.id, c.adherent_id, c.nbr_quittance, c.operation_date, c.cntur_avant, c.cntur_apres, c.qntt_consommee, c.ton_prix, c.total_prix, c.taxe, c.montant_aPayer, p.mois from consommation c inner join periode_consommation p on c.id_mois = p.id_mois where adherent_id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getClientReglement(string id)
        {
            string sqlQuery = "select * from reglement where adherent_id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getClientSituation(string id)
        {
            string sqlQuery = "select * from situation where adherent_id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getClientNbrPolice(string id)
        {
            string sqlQuery = "select nbr_police from adherent where id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getConsommationInfo(string id)
        {
            string sqlQuery = "select c.id, c.adherent_id, c.nbr_quittance, c.operation_date, c.cntur_avant, c.cntur_apres, c.qntt_consommee, c.ton_prix, c.total_prix, c.taxe, c.montant_aPayer, p.mois from consommation c inner join periode_consommation p on c.id_mois = p.id_mois where c.id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getReglementInfo(string id)
        {
            string sqlQuery = "select * from reglement where id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public void addAdherent(string nom, string prenom, string cin, string nbrPolice, string phone)
        {
            string sqlQuery = "dbo.insertAdherent '" + nom + "', '" + prenom + "', '" + cin + "', '" + nbrPolice + "', '" + phone + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public SqlDataReader loadClientInfo(string id)
        {
            string sqlQuery = "select * from adherent where id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public void updateAdherent(string id, string nom, string prenom, string cin, string nbrPolice, string phone)
        {
            string sqlQuery = "update adherent set nom = '" + nom + "', prenom = '" + prenom + "', cin = '" + cin + "', nbr_police = '" + nbrPolice + "', phone = '" + phone + "' where id = '" + id + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public void deleteClient(string id)
        {
            string sqlQuery = "dbo.deleteAdherent '" + id + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public void deleteConsommation(string adherentId, string id)
        {
            string sqlQuery = "delete from consommation where adherent_id = '" + adherentId + "' and id = '" + id + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public void deleteReglement(string adherentId, string id)
        {
            string sqlQuery = "delete from reglement where adherent_id = '" + adherentId + "' and id = '" + id + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public SqlDataReader getNbrpolicelist()
        {
            string sqlQuery = "select id, nbr_police from adherent";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader loadClientNomPrenom(string id)
        {
            string sqlQuery = "select nom, prenom from adherent where id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader loadCnturAvant(string id)
        {
            string sqlQuery = "select cntur_apres from consommation where cntur_apres is not null and adherent_id = '" + id + "' and id = (select max(id) from consommation where adherent_id = '" + id + "')";
            return queryExecuteReader(sqlQuery);
        }

        public void insertConsommation(string adherentId, string operationDate, string periodeConsommation, string cnturAvant, string cnturApres, string tonPrix, string taxe)
        {
            string sqlQuery = "dbo.insertConsommation '" + adherentId + "', '" + operationDate + "', '" + periodeConsommation + "', '" + cnturAvant + "', '" + cnturApres + "', '" + tonPrix + "', '" + taxe + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public SqlDataReader getPeriodeConsommationList()
        {
            string sqlQuery = "select * from periode_consommation";
            return queryExecuteReader(sqlQuery);
        }

        public void insertReglement(string id, string date, string montant, string paiMode, string observation, string recu)
        {
            string sqlQuery = "dbo.insertReglement '" + id + "', '" + date + "', '" + montant + "', '" + paiMode + "', '" + observation + "', '" + recu + "'";
            queryExecuteNonQuery(sqlQuery);
        }

        public SqlDataReader getNbrQuittance()
        {
            string sqlQuery = "select NEXT VALUE FOR [nbr_quittanceSequence]";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader getNbrRecu()
        {
            string sqlQuery = "select NEXT VALUE FOR [nbr_recuSequence]";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader loadSituationGlobal()
        {
            string sqlQuery = "select s.*, a.nom, a.prenom, a.nbr_police from situation s inner join adherent a on s.adherent_id = a.id";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader searchClientInSituation(string motCle)
        {
            string sqlQuery = "SELECT s.*, a.nom, a.prenom, a.nbr_police from situation s inner join adherent a on s.adherent_id = a.id WHERE a.prenom LIKE '%" + motCle + "%' OR a.nom LIKE '%" + motCle + "%' OR a.nbr_police LIKE '%" + motCle + "%'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader loadClientReste(string id)
        {
            string sqlQuery = "select reste from situation where adherent_id = '" + id + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader signIn(string username, string password)
        {
            string sqlQuery = "select * from users where username='" + username + "' and userPassword='" + password + "'";
            return queryExecuteReader(sqlQuery);
        }

        public SqlDataReader loadConsommationYears()
        {
            string sqlQuery = "SELECT YEAR(operation_date) as Year FROM consommation group by YEAR(operation_date)";
            return queryExecuteReader(sqlQuery);
        }

        public void closeConnection()
        {
            conn.Close();
        }
    }
}
