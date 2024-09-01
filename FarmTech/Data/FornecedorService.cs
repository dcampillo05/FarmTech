using System.Data;
using System;
using System.Data.SqlClient;

namespace FarmTech.Data
{
    public class FornecedorService
    {
        private readonly string _connectionString;

        public FornecedorService()
        {
            _connectionString = @"Server = DESKTOP-IU450N3\SQLEXPRESS; Database = dbFarmTech; Trusted_Connection = True;";
        }

        public void AddFornecedor(Fornecedor fornecedor)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("INSERT INTO tbFornecedor (Nome, CNPJ, Email, Telefone) VALUES (@Nome, @CNPJ, @Email, @Telefone)", cn);
                cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public Fornecedor QueryFornecedor(string nome)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM tbFornecedor WHERE Nome = @Nome", cn);
                cmd.Parameters.AddWithValue("@Nome", nome);

                cn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Fornecedor
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Nome = reader["Nome"].ToString(),
                            CNPJ = reader["CNPJ"].ToString(),
                            Email = reader["Email"].ToString(),
                            Telefone = reader["Telefone"].ToString()
                        };
                    }
                }
                cn.Close();
            }
            return null;
        }

        public void AlterFornecedor(Fornecedor fornecedor)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("UPDATE tbFornecedor SET Nome = @Nome, CNPJ = @CNPJ, Email = @Email, Telefone = @Telefone WHERE ID = @ID", cn);
                cmd.Parameters.AddWithValue("@ID", fornecedor.ID);
                cmd.Parameters.AddWithValue("@Nome", fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CNPJ", fornecedor.CNPJ);
                cmd.Parameters.AddWithValue("@Email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void DeleteFornecedor(string nome)
        {
            using (var cn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("DELETE FROM tbFornecedor WHERE Nome = @Nome", cn);
                cmd.Parameters.AddWithValue("@Nome", nome);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

    }
}
