using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    /// <summary>
    /// Gerencia o placar
    /// </summary>
    class Placar
    {
        public DataTable table;
        DataRow row;

        /// <summary>
        /// "spawna" uma tabela com os nomes com valores iguais ao array passado
        /// </summary>
        /// <param name="ar">Array com os nomes que vão para o placar</param>
        public Placar(string[] ar)
        {
            //cria a tabela de nome "table" e configura suas colunas
            table = new DataTable("table");
            DataColumn collumn = new DataColumn("Nome", typeof(string));
            table.Columns.Add(collumn);
            collumn = new DataColumn("Valor", typeof(int));
            table.Columns.Add(collumn);

          //foreach (var item in collection)
            foreach (string str in ar)
            {
                row = table.NewRow();
                row["Nome"] = str;
                row["Valor"] = 0;
                table.Rows.Add(row);
            }
        }
    }
}
