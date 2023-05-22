using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FamilyBudjet
{
    class DataBaseProcedure// модуль, который содержит описание хранимых процедур для добавления/редактирования и удаления данных
    {
        
        public static SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
        private SqlCommand cmd = new SqlCommand("Empty", sqlConnection);

        private void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        public void spAdd_articles(int id_category, string title, bool plus)
        {
            spConfiguration("Add_articles");
            cmd.Parameters.AddWithValue("@id_category", id_category);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@plus", plus);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_articles(int id_category, string title, bool plus, int id_article)
        {
            spConfiguration("Upd_articles");
            cmd.Parameters.AddWithValue("@id_category", id_category);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@plus", plus);
            cmd.Parameters.AddWithValue("@id_article", id_article);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_articles(int id_article)
        {
            spConfiguration("Del_articles");
            cmd.Parameters.AddWithValue("@id_article", id_article);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_category(string title_category)
        {
            spConfiguration("Add_category");
            cmd.Parameters.AddWithValue("@title_category", title_category);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_category(string title_category, int id_category)
        {
            spConfiguration("Upd_category");
            cmd.Parameters.AddWithValue("@id_category", id_category);
            cmd.Parameters.AddWithValue("@title_category", title_category);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_category(int id_category)
        {
            spConfiguration("Del_category");
            cmd.Parameters.AddWithValue("@id_category", id_category);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_type_member(string title_type_member)
        {
            spConfiguration("Add_type_member");
            cmd.Parameters.AddWithValue("@title_type_member", title_type_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_type_member(string title_type_member, int id_type_member)
        {
            spConfiguration("Upd_type_member");
            cmd.Parameters.AddWithValue("@id_type_member", id_type_member);
            cmd.Parameters.AddWithValue("@title_type_member", title_type_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_type_member(int id_type_member)
        {
            spConfiguration("Del_type_member");
            cmd.Parameters.AddWithValue("@id_type_member", id_type_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_family_member(string name_member, int id_type_member, string telephone)
        {
            spConfiguration("Add_family_member");
            cmd.Parameters.AddWithValue("@name_member", name_member);
            cmd.Parameters.AddWithValue("@id_type_member", id_type_member);
            cmd.Parameters.AddWithValue("@telephone", telephone);       
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_family_member(string name_member, int id_type_member, string telephone, int id_family_member)
        {
            spConfiguration("Upd_family_member");
            cmd.Parameters.AddWithValue("@name_member", name_member);
            cmd.Parameters.AddWithValue("@id_type_member", id_type_member);
            cmd.Parameters.AddWithValue("@telephone", telephone);
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_family_member(int id_family_member)
        {
            spConfiguration("Del_family_member");
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_plan_budjet(int id_article, decimal amount, int num_month, int num_year)
        {
            spConfiguration("Add_plan_budjet");
            cmd.Parameters.AddWithValue("@id_article", id_article);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@num_month", num_month);
            cmd.Parameters.AddWithValue("@num_year", num_year);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_plan_budjet(int id_article, decimal amount, int num_month, int num_year, int id_plan)
        {
            spConfiguration("Upd_plan_budjet");
            cmd.Parameters.AddWithValue("@id_article", id_article);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@num_month", num_month);
            cmd.Parameters.AddWithValue("@num_year", num_year);
            cmd.Parameters.AddWithValue("@id_plan", id_plan);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_plan_budjet(int id_plan)
        {
            spConfiguration("Del_plan_budjet");
            cmd.Parameters.AddWithValue("@id_plan", id_plan);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_operations(int id_article, int id_family_member, DateTime date_operation, decimal amount)
        {
            spConfiguration("Add_operations");
            cmd.Parameters.AddWithValue("@id_article", id_article);
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            cmd.Parameters.AddWithValue("@date_operation", date_operation);
            cmd.Parameters.AddWithValue("@amount", amount);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_operations(int id_article, int id_family_member, DateTime date_operation, decimal amount, int id_operation)
        {
            spConfiguration("Upd_operations");
            cmd.Parameters.AddWithValue("@id_article", id_article);
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            cmd.Parameters.AddWithValue("@date_operation", date_operation);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@id_operation", id_operation);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_operations(int id_operation)
        {
            spConfiguration("Del_operation");
            cmd.Parameters.AddWithValue("@id_operation", id_operation);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_kredits(string title_kredit, string object_kredit, decimal amount, int cnt_month, float percent_kredit)
        {
            spConfiguration("Add_kredits");
            cmd.Parameters.AddWithValue("@title_kredit", title_kredit);
            cmd.Parameters.AddWithValue("@object_kredit", object_kredit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@cnt_month", cnt_month);
            cmd.Parameters.AddWithValue("@percent_kredit", percent_kredit);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_kredits(string title_kredit, string object_kredit, decimal amount, int cnt_month, float percent_kredit, int id_kredit)
        {
            spConfiguration("Upd_kredits");
            cmd.Parameters.AddWithValue("@title_kredit", title_kredit);
            cmd.Parameters.AddWithValue("@object_kredit", object_kredit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@cnt_month", cnt_month);
            cmd.Parameters.AddWithValue("@percent_kredit", percent_kredit);
            cmd.Parameters.AddWithValue("@id_kredit", id_kredit);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_kredits(int id_kredit)
        {
            spConfiguration("Del_kredits");
            cmd.Parameters.AddWithValue("@id_kredit", id_kredit);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_payments(int id_kredit, decimal amount, DateTime date_payment, int id_family_member)
        {
            spConfiguration("Add_payments");
            cmd.Parameters.AddWithValue("@id_kredit", id_kredit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@date_payment", date_payment);
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_payments(int id_kredit, decimal amount, DateTime date_payment, int id_family_member, int id_payment)
        {
            spConfiguration("Upd_payments");
            cmd.Parameters.AddWithValue("@id_kredit", id_kredit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@date_payment", date_payment);
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            cmd.Parameters.AddWithValue("@id_payment", id_payment);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_payments(int id_payment)
        {
            spConfiguration("Del_payments");
            cmd.Parameters.AddWithValue("@id_payment", id_payment);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }
        public void spAdd_targets(string title_target, string description)
        {
            spConfiguration("Add_targets");
            cmd.Parameters.AddWithValue("@title_target", title_target);
            cmd.Parameters.AddWithValue("@description", description);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_targets(string title_target, string description, int id_target)
        {
            spConfiguration("Upd_targets");
            cmd.Parameters.AddWithValue("@title_target", title_target);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@id_target", id_target);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_targets(int id_target)
        {
            spConfiguration("Del_targets");
            cmd.Parameters.AddWithValue("@id_target", id_target);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_deposits_on_target(int id_family_member, int id_target, DateTime date_deposit, decimal amount)
        {
            spConfiguration("Add_deposits_on_target");
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            cmd.Parameters.AddWithValue("@id_target", id_target);
            cmd.Parameters.AddWithValue("@date_deposit", date_deposit);
            cmd.Parameters.AddWithValue("@amount", amount);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_deposits_on_target(int id_family_member, int id_target, DateTime date_deposit, decimal amount, int id_deposit_on_target)
        {
            spConfiguration("Upd_deposits_on_target");
            cmd.Parameters.AddWithValue("@id_family_member", id_family_member);
            cmd.Parameters.AddWithValue("@id_target", id_target);
            cmd.Parameters.AddWithValue("@date_deposit", date_deposit);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@id_deposit_on_target", id_deposit_on_target);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_deposits_on_target(int id_deposit_on_target)
        {
            spConfiguration("Del_deposits_on_target");
            cmd.Parameters.AddWithValue("@id_deposit_on_target", id_deposit_on_target);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_Zhurnal(int id_user, string action)
        {
            spConfiguration("Add_Zhurnal");
            cmd.Parameters.AddWithValue("@id_user", id_user);
            cmd.Parameters.AddWithValue("@action", action);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spAdd_User(string name_user, string login, string password, string role)
        {
            spConfiguration("Add_User");
            cmd.Parameters.AddWithValue("@name_user", name_user);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spUpd_User(string name_user, string login, string password, string role, int id_user)
        {
            spConfiguration("Upd_User");
            cmd.Parameters.AddWithValue("@name_user", name_user);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@id_user", id_user);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }

        public void spDel_User(int id_user)
        {
            spConfiguration("Del_User");
            cmd.Parameters.AddWithValue("@id_user", id_user);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            sqlConnection.Close();
        }
    }
}